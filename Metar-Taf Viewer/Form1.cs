﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;
using Metar_Taf_Viewer.navigation;
using Metar_Taf_Viewer.Altimeter;
using Metar_Taf_Viewer.common_data;

namespace Metar_Taf_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //write the dlls before initialising.
            File.WriteAllBytes("Microsoft.Web.WebView2.Core.dll", Properties.Resources.Microsoft_Web_WebView2_Core);
            File.WriteAllBytes("Microsoft.Web.WebView2.WinForms.dll", Properties.Resources.Microsoft_Web_WebView2_WinForms);

            string arcitectureProcessArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();

            if (arcitectureProcessArchitecture == "X64")
            {
                //64bit 
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources._64_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "X86")
            {
                // 32bit
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources._32_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "Arm64")
            {
                //ARM64bit 
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources.arm64_WebView2Loader);
            }



            InitializeComponent();

            // Resize += new EventHandler(Form_Resize);
            //webView_browser.NavigationStarting += EnsureHttps;
        }

        //private void Form_Resize(object sender, EventArgs e)
        //{
        //    webView_browser.Size = ClientSize - new System.Drawing.Size(webView_browser.Location);
        //    btn_navigate_to.Left = ClientSize.Width - btn_navigate_to.Width;
        //    txtbx_navigate_to_url.Width = btn_navigate_to.Left - txtbx_navigate_to_url.Left;
        //}

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_altimeter.Visible = false;

            await webView_egmj.EnsureCoreWebView2Async();
            await webView_egss.EnsureCoreWebView2Async();
            await webView_eggw.EnsureCoreWebView2Async();
            await webView_notams_egmj.EnsureCoreWebView2Async();
            await webView_weather_met.EnsureCoreWebView2Async();
            await webView_weather_bbc.EnsureCoreWebView2Async();
            await webView_synoptic.EnsureCoreWebView2Async();
            await webView_browser.EnsureCoreWebView2Async();
            await webView_gransden_lodge_weather.EnsureCoreWebView2Async();
            await webView_rasp.EnsureCoreWebView2Async();

            webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
            webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");
            webView_notams_egmj.CoreWebView2.Navigate("   https://www.notaminfo.com/ukmap?destination=node%2F39");
            webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941"); //Gamlinggay = 2648899 Gt Gransden = 2648095
            webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u1214b469"); //waresley = gcrbu1fn7
            webView_synoptic.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
            webView_gransden_lodge_weather.CoreWebView2.Navigate("https://members.camgliding.uk/members/GRLweather.aspx");
            webView_rasp.CoreWebView2.Navigate("https://rasp.stratus.org.uk/index.php/meteograms?tp=GRL");

            cmbobx_airport_info.SelectedIndex = 0;
            cmbobx_gransden_lodge.SelectedIndex = 0;

        }

        private void btn_navigate_to_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
        }

        private void txtbx_navigate_to_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Navigation.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
            }
        }

        private void rdobtn_cambridge_CheckedChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_bbc)
            {
                if (rdobtn_Gt_Gransden.Checked)
                {
                    webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2648095"); //Gt Gransden
                }
                else
                {
                    webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941"); //Cambridge
                }
            }
            else if (tabControl1.SelectedTab == tab_met_office)
            {
                if (rdobtn_Gt_Gransden.Checked)
                {
                    webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/gcrbu1fn7"); //waresley
                }
                else
                {
                    webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u1214b469");  //Cambridge
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //someValue = condition ? newValue : someOtherValue;
            //grpbx_towns.Visible = (tabControl1.SelectedTab == tab_bbc);

            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            grpbx_altimeter.Visible = false;
            btn_gransden_lodge_photo_update.Visible = false;

            if ((tabControl1.SelectedTab == tab_bbc) || (tabControl1.SelectedTab == tab_met_office))
            {
                grpbx_towns.Visible = true;
            }

            if (tabControl1.SelectedTab == tab_bbc)
            {
                string Town = GetTownDisplayed(webView_weather_bbc.Source.ToString());

                rdobtn_Gt_Gransden.Checked = (Town == "2648095");
                rdobtn_cambridge.Checked = (Town == "2653941");
            }
            else if (tabControl1.SelectedTab == tab_met_office)
            {
                string Town = GetTownDisplayed(webView_weather_met.Source.ToString());

                rdobtn_Gt_Gransden.Checked = (Town == "gcrbu1fn7");
                rdobtn_cambridge.Checked = (Town == "u1214b469");
            }

            if (tabControl1.SelectedTab == tab_browser)
            {
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                grpbx_browser_navigation.Visible = true;
            }

            if (tabControl1.SelectedTab == tab_altimeter)
            {
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                grpbx_altimeter.Visible = true;
            }

            if (tabControl1.SelectedTab == tab_gransden_lodge)
            {
                cmbobx_gransden_lodge.Visible = true;
                cmbobx_gransden_lodge.SelectedIndex = 0;
            }
        }


        public static String GetTownDisplayed(String url)
        {
            Uri uri = new Uri(url);
            return uri.Segments.Last().TrimEnd('/');
        }

        private void btn_calculate_altimiter_Click(object sender, EventArgs e)
        {
            //Calculate settings for altitude at destination
            /*
             * var values = MyFunction();
               var firstValue = values.Item1;
               var secondValue = values.Item2;
               var thirdValue = values.Item3;

                (string, string, string)MyFunction()

             */

            var values = altimeter.Calculate_altimeter(txtbx_present_pressure.Text, txtbx_present_altitude.Text, txtbx_to_altitude.Text);

            var firstValue = values.Item1;
            var secondValue = values.Item2;

            if ((firstValue != "F") && (secondValue != "F"))
            {
                lbl_to_pressure.Text = firstValue;
                lbl_qnh_pressure.Text = secondValue;
            }
            else
            {
                MsgBox.Show("Check you have filled in all the information correctly", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbobx_airport_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_altimeter)
            {
                string[] data = airport_data.GetAirportInfo(cmbobx_airport_info.Text);

                lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";

                if (rdobtn_present.Checked)
                {
                    lbl_p_airport_name.Text = "Airport Name = " + data[2];
                    lbl_p_icao_code.Text = "ICAO Code = " + data[1];
                    lbl_p_latitude_deg.Text = "Latitude degrees = " + data[3];
                    lbl_p_latitude_dec.Text = "Latitude decimal = " + data[4];
                    lbl_p_longitude_deg.Text = "Longitude degrees = " + data[5];
                    lbl_p_longitude_dec.Text = "Logitude decimal = " + data[6];
                    lbl_p_elevation_m.Text = "Elevation = " + data[7] + "m";
                    txtbx_present_altitude.Text = data[8];
                }
                else
                {
                    lbl_d_airport_name.Text = "Airport Name = " + data[2];
                    lbl_d_icao_code.Text = "ICAO Code = " + data[1];
                    lbl_d_latitude_deg.Text = "Latitude degrees = " + data[3];
                    lbl_d_latitude_dec.Text = "Latitude decimal = " + data[4];
                    lbl_d_longitude_deg.Text = "Longitude degrees = " + data[5];
                    lbl_d_longitude_dec.Text = "Logitude decimal = " + data[6];
                    lbl_d_elevation_m.Text = "Elevation = " + data[7] + "m";
                    txtbx_to_altitude.Text = data[8];
                }
            }
            else if (tabControl1.SelectedTab == tab_browser)
            {
                string URI = "https://metar-taf.com/" + airport_data.GetAirportInfo(cmbobx_airport_info.Text)[1];
                webView_browser.CoreWebView2.Navigate(URI);
                txtbx_navigate_to_url.Text = URI;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("airport_data.xml");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_egmj)
            {
                webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            }
            else if (tabControl1.SelectedTab == tab_egss)
            {
                webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
            }
            else if (tabControl1.SelectedTab == tab_egmj)
            {
                webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            }
            else if (tabControl1.SelectedTab == tab_eggw)
            {
                webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");
            }
            else if (tabControl1.SelectedTab == tab_notams)
            {
                webView_notams_egmj.CoreWebView2.Navigate("   https://www.notaminfo.com/ukmap?destination=node%2F39");
            }
            else if (tabControl1.SelectedTab == tab_bbc)
            {
                webView_weather_bbc.CoreWebView2.Navigate(
                    "https://www.bbc.co.uk/weather/2653941"); //Gamlinggay = 2648899 Gt Gransden = 2648095
                rdobtn_cambridge.Checked = true;
            }
            else if (tabControl1.SelectedTab == tab_met_office)
            {
                webView_weather_met.CoreWebView2.Navigate(
                    "https://metoffice.gov.uk/weather/forecast/u1214b469"); //waresley = gcrbu1fn7
                rdobtn_cambridge.Checked = true;
            }
            else if (tabControl1.SelectedTab == tab_synoptic)
            {
                webView_synoptic.CoreWebView2.Navigate(
                    "https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
            }
            else if (tabControl1.SelectedTab == tab_gransden_lodge)
            {
                cmbobx_gransden_lodge.SelectedIndex = 0;
            }
            else if (tabControl1.SelectedTab == tab_browser)
            {
                txtbx_navigate_to_url.Text = "";
                cmbobx_airport_info.SelectedIndex = 0;
                webView_browser.CoreWebView2.Navigate("about:blank");
            }
            else if (tabControl1.SelectedTab == tab_altimeter)
            {
                txtbx_present_pressure.Text = txtbx_present_altitude.Text = txtbx_to_altitude.Text =
                    lbl_p_airport_name.Text = lbl_p_icao_code.Text = lbl_p_latitude_deg.Text =
                        lbl_p_latitude_dec.Text = lbl_p_longitude_deg.Text = lbl_p_longitude_dec.Text =
                            lbl_p_elevation_m.Text = lbl_d_airport_name.Text = lbl_d_icao_code.Text =
                                lbl_d_latitude_deg.Text = lbl_d_latitude_dec.Text = lbl_d_longitude_deg.Text =
                                        lbl_d_longitude_dec.Text = lbl_d_elevation_m.Text =
                                            lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";
            }
            else if (tabControl1.SelectedTab == tab_rasp)
            {
                webView_rasp.CoreWebView2.Navigate("https://rasp.stratus.org.uk/index.php/meteograms?tp=GRL");
            }

        }

        private void cmbobx_gransden_lodge_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_gransden_lodge_photo_update.Visible = false;

            if (cmbobx_gransden_lodge.Text == "General Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                   "https://members.camgliding.uk/members/GRLweather.aspx");
            }
            else if (cmbobx_gransden_lodge.Text == "Navigation Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/xcplanning/weather.aspx");
            }
            else if (cmbobx_gransden_lodge.Text == "Radar Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/tracking/");
            }
            else if (cmbobx_gransden_lodge.Text == "South Camera")
            {
                btn_gransden_lodge_photo_update.Visible = true;
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camsouth.jpg");
            }
            else if (cmbobx_gransden_lodge.Text == "West Camera")
            {
                btn_gransden_lodge_photo_update.Visible = true;
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camwest.jpg");
            }
        }

        private void btn_gransden_lodge_photo_update_Click(object sender, EventArgs e)
        {
            if (cmbobx_gransden_lodge.Text == "South Camera")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camsouth.jpg");
            }
            else if (cmbobx_gransden_lodge.Text == "West Camera")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camwest.jpg");
            }
        }
    }
}
