using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Metar_Taf_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Resize += new EventHandler(Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView_browser.Size = ClientSize - new System.Drawing.Size(webView_browser.Location);
            btn_navigate_to.Left = ClientSize.Width - btn_navigate_to.Width;
            txtbx_navigate_to_url.Width = btn_navigate_to.Left - txtbx_navigate_to_url.Left;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
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


        }

        private void btn_navigate_to_Click(object sender, EventArgs e)
        {
            if (webView_browser != null && webView_browser.CoreWebView2 != null)
            {
                webView_browser.CoreWebView2.Navigate(txtbx_navigate_to_url.Text);
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

            if ((tabControl1.SelectedTab == tab_bbc) || (tabControl1.SelectedTab == tab_met_office))
            {
                grpbx_towns.Visible = true;

            }
            else
            {
                grpbx_towns.Visible = false;
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
        }


        public static String GetTownDisplayed(String url)
        {
            Uri uri = new Uri(url);
            return uri.Segments.Last().TrimEnd('/');
        }

    }
}
