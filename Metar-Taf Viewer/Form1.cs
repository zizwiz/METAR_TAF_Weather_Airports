using System;
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
            InitializeComponent();
            Resize += new EventHandler(Form_Resize);
            //webView_browser.NavigationStarting += EnsureHttps;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView_browser.Size = ClientSize - new System.Drawing.Size(webView_browser.Location);
            btn_navigate_to.Left = ClientSize.Width - btn_navigate_to.Width;
            txtbx_navigate_to_url.Width = btn_navigate_to.Left - txtbx_navigate_to_url.Left;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            grpbx_towns.Visible = false;

            await webView_egmj.EnsureCoreWebView2Async();
            await webView_egss.EnsureCoreWebView2Async();
            await webView_eggw.EnsureCoreWebView2Async();
            await webView_notams_egmj.EnsureCoreWebView2Async();
            await webView_weather_met.EnsureCoreWebView2Async();
            await webView_weather_bbc.EnsureCoreWebView2Async();
            await webView_synoptic.EnsureCoreWebView2Async();
            await webView_browser.EnsureCoreWebView2Async();

            webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
            webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");
            webView_notams_egmj.CoreWebView2.Navigate("   https://www.notaminfo.com/ukmap?destination=node%2F39");
            webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941"); //Gamlinggay = 2648899 Gt Gransden = 2648095
            webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u1214b469"); //waresley = gcrbu1fn7
            webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941");
            webView_synoptic.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");

            cmbobx_airport_info.SelectedIndex = 0;
            cmbobx_airport_info.Visible = false;
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
            grpbx_towns.Visible = false;

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
                cmbobx_airport_info.Visible = true;
            }

            if (tabControl1.SelectedTab == tab_altimeter)
            {
                cmbobx_airport_info.Visible = true;
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

        private void btn_altimeter_reset_Click(object sender, EventArgs e)
        {
            // reset all the data
            txtbx_present_pressure.Text = txtbx_present_altitude.Text = txtbx_to_altitude.Text =
            lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";
        }

        private void cmbobx_airport_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_altimeter)
            {
                lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";

                if (rdobtn_present.Checked)
                {
                    txtbx_present_altitude.Text = airport_data.GetAirportInfo(cmbobx_airport_info.Text)[8];
                }
                else
                {
                    txtbx_to_altitude.Text = airport_data.GetAirportInfo(cmbobx_airport_info.Text)[8];
                }
            }
            else if (tabControl1.SelectedTab == tab_browser)
            {
                webView_browser.CoreWebView2.Navigate("https://metar-taf.com/" +
                      airport_data.GetAirportInfo(cmbobx_airport_info.Text)[1]);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("airport_data.xml");
        }

       


        //void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        //{
        //    String uri = args.Uri;
        //    if (!uri.StartsWith("https://"))
        //    {
        //        args.Cancel = true;
        //    }
        //}
    }
}
