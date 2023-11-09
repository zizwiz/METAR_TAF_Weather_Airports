
namespace Metar_Taf_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_egmj = new System.Windows.Forms.TabPage();
            this.webView_egmj = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_egss = new System.Windows.Forms.TabPage();
            this.webView_egss = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_eggw = new System.Windows.Forms.TabPage();
            this.webView_eggw = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_notams = new System.Windows.Forms.TabPage();
            this.webView_notams_egmj = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_met_office = new System.Windows.Forms.TabPage();
            this.webView_weather_met = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_bbc = new System.Windows.Forms.TabPage();
            this.webView_weather_bbc = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_synoptic = new System.Windows.Forms.TabPage();
            this.webView_synoptic = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_browser = new System.Windows.Forms.TabPage();
            this.webView_browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpbx_towns = new System.Windows.Forms.GroupBox();
            this.rdobtn_Gt_Gransden = new System.Windows.Forms.RadioButton();
            this.rdobtn_cambridge = new System.Windows.Forms.RadioButton();
            this.btn_navigate_to = new System.Windows.Forms.Button();
            this.txtbx_navigate_to_url = new System.Windows.Forms.TextBox();
            this.cmbobx_airports = new System.Windows.Forms.ComboBox();
            this.tab_altimeter = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpbx_QNH = new System.Windows.Forms.GroupBox();
            this.lbl_sea_level_ft = new System.Windows.Forms.Label();
            this.lbl_qnh_pressure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calculate_altimiter = new System.Windows.Forms.Button();
            this.grpbx_to = new System.Windows.Forms.GroupBox();
            this.lbl_to_pressure = new System.Windows.Forms.Label();
            this.lbl_to_mb = new System.Windows.Forms.Label();
            this.lbl_to_ft = new System.Windows.Forms.Label();
            this.txtbx_to_altitude = new System.Windows.Forms.TextBox();
            this.grpbx_present = new System.Windows.Forms.GroupBox();
            this.lbl_present_mb = new System.Windows.Forms.Label();
            this.lbl_present_ft = new System.Windows.Forms.Label();
            this.txtbx_present_pressure = new System.Windows.Forms.TextBox();
            this.txtbx_present_altitude = new System.Windows.Forms.TextBox();
            this.btn_altimeter_reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_egmj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmj)).BeginInit();
            this.tab_egss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss)).BeginInit();
            this.tab_eggw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_eggw)).BeginInit();
            this.tab_notams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_notams_egmj)).BeginInit();
            this.tab_met_office.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_met)).BeginInit();
            this.tab_bbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_bbc)).BeginInit();
            this.tab_synoptic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_synoptic)).BeginInit();
            this.tab_browser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_browser)).BeginInit();
            this.panel3.SuspendLayout();
            this.grpbx_towns.SuspendLayout();
            this.tab_altimeter.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpbx_QNH.SuspendLayout();
            this.grpbx_to.SuspendLayout();
            this.grpbx_present.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 784);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 618);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_egmj);
            this.tabControl1.Controls.Add(this.tab_egss);
            this.tabControl1.Controls.Add(this.tab_eggw);
            this.tabControl1.Controls.Add(this.tab_notams);
            this.tabControl1.Controls.Add(this.tab_met_office);
            this.tabControl1.Controls.Add(this.tab_bbc);
            this.tabControl1.Controls.Add(this.tab_synoptic);
            this.tabControl1.Controls.Add(this.tab_browser);
            this.tabControl1.Controls.Add(this.tab_altimeter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_egmj
            // 
            this.tab_egmj.Controls.Add(this.webView_egmj);
            this.tab_egmj.Location = new System.Drawing.Point(4, 29);
            this.tab_egmj.Name = "tab_egmj";
            this.tab_egmj.Size = new System.Drawing.Size(1261, 585);
            this.tab_egmj.TabIndex = 5;
            this.tab_egmj.Text = "Lt Gransden (EGMJ)";
            this.tab_egmj.UseVisualStyleBackColor = true;
            // 
            // webView_egmj
            // 
            this.webView_egmj.AllowExternalDrop = true;
            this.webView_egmj.CreationProperties = null;
            this.webView_egmj.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egmj.Location = new System.Drawing.Point(0, 0);
            this.webView_egmj.Name = "webView_egmj";
            this.webView_egmj.Size = new System.Drawing.Size(1261, 585);
            this.webView_egmj.TabIndex = 0;
            this.webView_egmj.ZoomFactor = 1D;
            // 
            // tab_egss
            // 
            this.tab_egss.Controls.Add(this.webView_egss);
            this.tab_egss.Location = new System.Drawing.Point(4, 29);
            this.tab_egss.Name = "tab_egss";
            this.tab_egss.Padding = new System.Windows.Forms.Padding(3);
            this.tab_egss.Size = new System.Drawing.Size(1261, 585);
            this.tab_egss.TabIndex = 0;
            this.tab_egss.Text = "Stansted (EGSS)";
            this.tab_egss.UseVisualStyleBackColor = true;
            // 
            // webView_egss
            // 
            this.webView_egss.AllowExternalDrop = true;
            this.webView_egss.CreationProperties = null;
            this.webView_egss.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egss.Location = new System.Drawing.Point(3, 3);
            this.webView_egss.Name = "webView_egss";
            this.webView_egss.Size = new System.Drawing.Size(1255, 579);
            this.webView_egss.TabIndex = 0;
            this.webView_egss.ZoomFactor = 1D;
            // 
            // tab_eggw
            // 
            this.tab_eggw.Controls.Add(this.webView_eggw);
            this.tab_eggw.Location = new System.Drawing.Point(4, 29);
            this.tab_eggw.Name = "tab_eggw";
            this.tab_eggw.Padding = new System.Windows.Forms.Padding(3);
            this.tab_eggw.Size = new System.Drawing.Size(1261, 585);
            this.tab_eggw.TabIndex = 1;
            this.tab_eggw.Text = "Luton (EGGW)";
            this.tab_eggw.UseVisualStyleBackColor = true;
            // 
            // webView_eggw
            // 
            this.webView_eggw.AllowExternalDrop = true;
            this.webView_eggw.CreationProperties = null;
            this.webView_eggw.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_eggw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_eggw.Location = new System.Drawing.Point(3, 3);
            this.webView_eggw.Name = "webView_eggw";
            this.webView_eggw.Size = new System.Drawing.Size(1255, 579);
            this.webView_eggw.TabIndex = 0;
            this.webView_eggw.ZoomFactor = 1D;
            // 
            // tab_notams
            // 
            this.tab_notams.Controls.Add(this.webView_notams_egmj);
            this.tab_notams.Location = new System.Drawing.Point(4, 29);
            this.tab_notams.Name = "tab_notams";
            this.tab_notams.Size = new System.Drawing.Size(1261, 585);
            this.tab_notams.TabIndex = 6;
            this.tab_notams.Text = "Notams (EGMJ)";
            this.tab_notams.UseVisualStyleBackColor = true;
            // 
            // webView_notams_egmj
            // 
            this.webView_notams_egmj.AllowExternalDrop = true;
            this.webView_notams_egmj.CreationProperties = null;
            this.webView_notams_egmj.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_notams_egmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_notams_egmj.Location = new System.Drawing.Point(0, 0);
            this.webView_notams_egmj.Name = "webView_notams_egmj";
            this.webView_notams_egmj.Size = new System.Drawing.Size(1261, 585);
            this.webView_notams_egmj.TabIndex = 0;
            this.webView_notams_egmj.ZoomFactor = 1D;
            // 
            // tab_met_office
            // 
            this.tab_met_office.Controls.Add(this.webView_weather_met);
            this.tab_met_office.Location = new System.Drawing.Point(4, 29);
            this.tab_met_office.Name = "tab_met_office";
            this.tab_met_office.Size = new System.Drawing.Size(1261, 585);
            this.tab_met_office.TabIndex = 2;
            this.tab_met_office.Text = "Weather Met office";
            this.tab_met_office.UseVisualStyleBackColor = true;
            // 
            // webView_weather_met
            // 
            this.webView_weather_met.AllowExternalDrop = true;
            this.webView_weather_met.CreationProperties = null;
            this.webView_weather_met.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_weather_met.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_weather_met.Location = new System.Drawing.Point(0, 0);
            this.webView_weather_met.Name = "webView_weather_met";
            this.webView_weather_met.Size = new System.Drawing.Size(1261, 585);
            this.webView_weather_met.TabIndex = 0;
            this.webView_weather_met.ZoomFactor = 1D;
            // 
            // tab_bbc
            // 
            this.tab_bbc.Controls.Add(this.webView_weather_bbc);
            this.tab_bbc.Location = new System.Drawing.Point(4, 29);
            this.tab_bbc.Name = "tab_bbc";
            this.tab_bbc.Size = new System.Drawing.Size(1261, 585);
            this.tab_bbc.TabIndex = 3;
            this.tab_bbc.Text = "Weather BBC";
            this.tab_bbc.UseVisualStyleBackColor = true;
            // 
            // webView_weather_bbc
            // 
            this.webView_weather_bbc.AllowExternalDrop = true;
            this.webView_weather_bbc.CreationProperties = null;
            this.webView_weather_bbc.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_weather_bbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_weather_bbc.Location = new System.Drawing.Point(0, 0);
            this.webView_weather_bbc.Name = "webView_weather_bbc";
            this.webView_weather_bbc.Size = new System.Drawing.Size(1261, 585);
            this.webView_weather_bbc.TabIndex = 0;
            this.webView_weather_bbc.ZoomFactor = 1D;
            // 
            // tab_synoptic
            // 
            this.tab_synoptic.Controls.Add(this.webView_synoptic);
            this.tab_synoptic.Location = new System.Drawing.Point(4, 29);
            this.tab_synoptic.Name = "tab_synoptic";
            this.tab_synoptic.Size = new System.Drawing.Size(1261, 585);
            this.tab_synoptic.TabIndex = 4;
            this.tab_synoptic.Text = "Synoptic Chart";
            this.tab_synoptic.UseVisualStyleBackColor = true;
            // 
            // webView_synoptic
            // 
            this.webView_synoptic.AllowExternalDrop = true;
            this.webView_synoptic.CreationProperties = null;
            this.webView_synoptic.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_synoptic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_synoptic.Location = new System.Drawing.Point(0, 0);
            this.webView_synoptic.Name = "webView_synoptic";
            this.webView_synoptic.Size = new System.Drawing.Size(1261, 585);
            this.webView_synoptic.TabIndex = 0;
            this.webView_synoptic.ZoomFactor = 1D;
            // 
            // tab_browser
            // 
            this.tab_browser.Controls.Add(this.webView_browser);
            this.tab_browser.Location = new System.Drawing.Point(4, 29);
            this.tab_browser.Name = "tab_browser";
            this.tab_browser.Size = new System.Drawing.Size(1261, 585);
            this.tab_browser.TabIndex = 7;
            this.tab_browser.Text = "Browser";
            this.tab_browser.UseVisualStyleBackColor = true;
            // 
            // webView_browser
            // 
            this.webView_browser.AllowExternalDrop = true;
            this.webView_browser.CreationProperties = null;
            this.webView_browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_browser.Location = new System.Drawing.Point(0, 0);
            this.webView_browser.Name = "webView_browser";
            this.webView_browser.Size = new System.Drawing.Size(1261, 585);
            this.webView_browser.TabIndex = 0;
            this.webView_browser.ZoomFactor = 1D;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 74);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbobx_airports);
            this.panel3.Controls.Add(this.grpbx_towns);
            this.panel3.Controls.Add(this.btn_navigate_to);
            this.panel3.Controls.Add(this.txtbx_navigate_to_url);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1269, 74);
            this.panel3.TabIndex = 2;
            // 
            // grpbx_towns
            // 
            this.grpbx_towns.Controls.Add(this.rdobtn_Gt_Gransden);
            this.grpbx_towns.Controls.Add(this.rdobtn_cambridge);
            this.grpbx_towns.Location = new System.Drawing.Point(26, 9);
            this.grpbx_towns.Name = "grpbx_towns";
            this.grpbx_towns.Size = new System.Drawing.Size(276, 58);
            this.grpbx_towns.TabIndex = 4;
            this.grpbx_towns.TabStop = false;
            // 
            // rdobtn_Gt_Gransden
            // 
            this.rdobtn_Gt_Gransden.AutoSize = true;
            this.rdobtn_Gt_Gransden.Location = new System.Drawing.Point(136, 18);
            this.rdobtn_Gt_Gransden.Name = "rdobtn_Gt_Gransden";
            this.rdobtn_Gt_Gransden.Size = new System.Drawing.Size(127, 24);
            this.rdobtn_Gt_Gransden.TabIndex = 3;
            this.rdobtn_Gt_Gransden.Text = "Gt Gransden";
            this.rdobtn_Gt_Gransden.UseVisualStyleBackColor = true;
            // 
            // rdobtn_cambridge
            // 
            this.rdobtn_cambridge.AutoSize = true;
            this.rdobtn_cambridge.Checked = true;
            this.rdobtn_cambridge.Location = new System.Drawing.Point(19, 18);
            this.rdobtn_cambridge.Name = "rdobtn_cambridge";
            this.rdobtn_cambridge.Size = new System.Drawing.Size(111, 24);
            this.rdobtn_cambridge.TabIndex = 2;
            this.rdobtn_cambridge.TabStop = true;
            this.rdobtn_cambridge.Text = "Cambridge";
            this.rdobtn_cambridge.UseVisualStyleBackColor = true;
            this.rdobtn_cambridge.CheckedChanged += new System.EventHandler(this.rdobtn_cambridge_CheckedChanged);
            // 
            // btn_navigate_to
            // 
            this.btn_navigate_to.Location = new System.Drawing.Point(1053, 17);
            this.btn_navigate_to.Name = "btn_navigate_to";
            this.btn_navigate_to.Size = new System.Drawing.Size(132, 44);
            this.btn_navigate_to.TabIndex = 1;
            this.btn_navigate_to.Text = "&Go";
            this.btn_navigate_to.UseVisualStyleBackColor = true;
            this.btn_navigate_to.Click += new System.EventHandler(this.btn_navigate_to_Click);
            // 
            // txtbx_navigate_to_url
            // 
            this.txtbx_navigate_to_url.Location = new System.Drawing.Point(594, 26);
            this.txtbx_navigate_to_url.Name = "txtbx_navigate_to_url";
            this.txtbx_navigate_to_url.Size = new System.Drawing.Size(429, 26);
            this.txtbx_navigate_to_url.TabIndex = 0;
            this.txtbx_navigate_to_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_navigate_to_url_KeyPress);
            // 
            // cmbobx_airports
            // 
            this.cmbobx_airports.FormattingEnabled = true;
            this.cmbobx_airports.Items.AddRange(new object[] {
            "AAC Middle Wallop",
            "Aberdeen Airport",
            "Aberporth Airport",
            "Albourne",
            "Alderney Airport",
            "Andrewsfield Aerodrome",
            "Anglesey Airport",
            "Ascot Racecourse Heliport",
            "Ashcroft",
            "Audley End Airfield",
            "Aylesbury",
            "Bagby Airfield",
            "Ballykelly",
            "Barra Airport",
            "Barrow/Walney Island Airport",
            "Beccles Airfield",
            "Bedford Aerodrome",
            "Belfast International Airport",
            "Bembridge Airport",
            "Benbecula Airport",
            "Beverley/Linley Hill Airfield",
            "Bicester Airfield",
            "Birmingham Airport",
            "Blackbushe Airport",
            "Blackpool Airport",
            "Bodmin Aerodrome",
            "Bourn Airfield",
            "Bournemouth Airport",
            "Breighton Aerodrome",
            "Brimpton",
            "Bristol Airport",
            "Brooklands",
            "Brough Aerodrome",
            "Bruntingthorpe Aerodrome",
            "Caernarfon Airport",
            "Cambridge City Airport",
            "Campbeltown Airport ",
            "Cardiff Airport",
            "Cardiff Heliport",
            "Carlisle Lake District Airport",
            "Castle Mill Airfield",
            "Chalgrove Airfield",
            "Challock Airfield",
            "Cheltenham Racecourse Heliport",
            "Chester Hawarden Airport",
            "Chichester/Goodwood Airport",
            "City Airport & Manchester Heliport",
            "City of Derry Airport",
            "Clacton Airport",
            "Colerne",
            "Coll Airport",
            "Colonsay Airport",
            "Compton Abbas Airfield",
            "Cotswold Airport",
            "Cottesmore",
            "Coventry Airport",
            "Cranfield Airport",
            "Crosland Moor Airfield",
            "Crowfield Airfield",
            "Culter Heliport",
            "Cumbernauld Airport",
            "Damyns Hall Aerodrome",
            "Deanland Lewes",
            "Denham Aerodrome",
            "Derby Airfield",
            "Doncaster Sheffield Airport",
            "Dundee Airport",
            "Dunkeswell Aerodrome",
            "Dunsfold Aerodrome",
            "Duxford Aerodrome",
            "Eaglescott Airfield",
            "Earls Colne Airfield",
            "East Midlands Airport",
            "Eday Airport",
            "Edinburgh Airport",
            "Elmsett Airfield",
            "Elstree Aerodrome",
            "Elvington Airfield",
            "Enniskillen",
            "Enstone Airfield",
            "Exeter Airport",
            "Fair Isle Airport",
            "Fairoaks Airport",
            "Farnborough Airport",
            "Farthing Corner",
            "Fenland Airfield",
            "Fife Airport",
            "Filton",
            "Fishburn Airfield",
            "Fowlmere Airfield",
            "Full Sutton Airfield",
            "George Best Belfast City Airport",
            "Glasgow Airport",
            "Glasgow City Heliport",
            "Glasgow Prestwick Airport",
            "Gloucestershire Airport",
            "Goodwood Racecourse Heliport",
            "Great Yarmouth",
            "Guernsey Airport",
            "Haverfordwest Airport",
            "Headcorn Aerodrome",
            "Henstridge Airfield",
            "Hinton-in-the-Hedges Airfield",
            "Holyhead Heliport",
            "Hucknall",
            "Humberside Airport",
            "Inverness Airport",
            "Islay Airport",
            "Isle of Man Airport",
            "Isle of Skye",
            "Isle of Wight/Sandown Airport",
            "Jersey Airport",
            "Kinloss Barracks",
            "Kirkwall Airport",
            "Land\'s End Airport",
            "Langford Lodge",
            "Lasham Airfield",
            "Leconfield",
            "Lee on Solent",
            "Leeds Bradford Airport",
            "Leeds East Airport",
            "Leeds Heliport",
            "Leicester Airport",
            "Leuchars Station",
            "Little Gransden Airfield",
            "Liverpool John Lennon Airport",
            "Llanbedr",
            "Llanbedr Airport",
            "London Biggin Hill Airport",
            "London City Airport",
            "London Gatwick Airport",
            "London Heathrow Airport",
            "London Luton",
            "London Oxford Airport",
            "London Southend Airport",
            "London Stansted Airport",
            "London Westland Heliport",
            "Long Marston",
            "Longside",
            "Lydd Airport",
            "Manchester",
            "Manchester Airport",
            "Manston Airport",
            "Marshland",
            "Maypole",
            "MoD Boscombe Down",
            "MOD St Athan",
            "Netheravon Airfield",
            "Netherthorpe Airfield",
            "Newcastle International Airport",
            "Newmarket Heath",
            "Newquay Airport / RAF St Mawgan",
            "Newtownards Airport",
            "North Ronaldsay Airport",
            "North Weald Airfield",
            "Norwich Airport",
            "Nottingham Airport",
            "Oaksey Park Airfield",
            "Oban Airport",
            "Old Buckenham Airfield",
            "Old Sarum Airfield",
            "Panshanger Aerodrome",
            "Papa Westray Airport",
            "Pembrey Airport",
            "Penzance Heliport",
            "Perranporth Airfield",
            "Perth Airport",
            "Peterborough",
            "Peterborough Business Airport",
            "Plymouth",
            "Popham Airfield",
            "Portland Heliport",
            "RAF Abingdon",
            "RAF Barkston Heath",
            "RAF Benson",
            "RAF Boulmer",
            "RAF Brize Norton",
            "RAF Coltishall",
            "RAF Coningsby",
            "RAF Cosford",
            "RAF Cranwell",
            "RAF Dishforth",
            "RAF Fairford",
            "RAF Halton",
            "RAF Henlow",
            "RAF Honington",
            "RAF Hullavington",
            "RAF Lakenheath",
            "RAF Leeming",
            "RAF Linton-on-Ouse",
            "RAF Lossiemouth",
            "RAF Lyneham",
            "RAF Marham",
            "RAF Mildenhall",
            "RAF Mona",
            "RAF Northolt",
            "RAF Odiham",
            "RAF Scampton",
            "RAF Shawbury",
            "RAF Syerston",
            "RAF Ternhill",
            "RAF Topcliffe",
            "RAF Upavon (Disused)",
            "RAF Waddington",
            "RAF Wittering",
            "RAF Woodvale",
            "RAF Wroughton",
            "RAF Wyton",
            "Redhill Aerodrome",
            "Retford Gamston Airport",
            "RNAS Culdrose",
            "RNAS Merryfield",
            "RNAS Predannack",
            "RNAS Yeovilton",
            "Rochester Airport",
            "Royal Marines Base Chivenor",
            "Salisbury Plain Aerodrome",
            "Sanday Airport",
            "Sandtoft Airfield",
            "Scatsta",
            "Seething Airfield",
            "Sherburn-in-Elmet Airfield",
            "Shipdham Airfield",
            "Shobdon Aerodrome",
            "Shoreham Airport",
            "Shotton Airfield/Peterlee Parachute Centre",
            "Shuttleworth Aerodrome",
            "Silverstone",
            "Skegness",
            "Sleap Airfield",
            "Southampton Airport",
            "Southport",
            "St Athan",
            "St Mary\'s Airport",
            "Stapleford Aerodrome",
            "Stornoway Airport",
            "Stronsay Airport",
            "Strubby Airfield",
            "Sturgate Airfield",
            "Sumburgh Airport",
            "Swansea Airport",
            "Sywell Aerodrome",
            "Tatenhill Airfield",
            "Teesside International Airport",
            "Thorne",
            "Thruxton Aerodrome",
            "Thurrock",
            "Tilstock",
            "Tingwall Airport",
            "Tiree Airport",
            "Tresco Heliport",
            "Truro Aerodrome",
            "Turweston Aerodrome",
            "Unst Airport",
            "Warton Aerodrome",
            "Wattisham Airfield",
            "Wellesbourne Mountford Aerodrome",
            "Welshpool Airport",
            "West Freugh",
            "Westray Airport",
            "Whalsay Airstrip",
            "White Waltham Airfield",
            "Wick Airport",
            "Wickenby Aerodrome",
            "Wolverhampton Airport",
            "Wrexham",
            "Wycombe Air Park",
            "Yeovil Aerodrome"});
            this.cmbobx_airports.Location = new System.Drawing.Point(308, 26);
            this.cmbobx_airports.Name = "cmbobx_airports";
            this.cmbobx_airports.Size = new System.Drawing.Size(260, 28);
            this.cmbobx_airports.TabIndex = 5;
            this.cmbobx_airports.SelectedIndexChanged += new System.EventHandler(this.cmbobx_airports_SelectedIndexChanged);
            // 
            // tab_altimeter
            // 
            this.tab_altimeter.Controls.Add(this.panel4);
            this.tab_altimeter.Location = new System.Drawing.Point(4, 29);
            this.tab_altimeter.Name = "tab_altimeter";
            this.tab_altimeter.Size = new System.Drawing.Size(1261, 585);
            this.tab_altimeter.TabIndex = 8;
            this.tab_altimeter.Text = "Altimeter";
            this.tab_altimeter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_altimeter_reset);
            this.panel4.Controls.Add(this.grpbx_QNH);
            this.panel4.Controls.Add(this.btn_calculate_altimiter);
            this.panel4.Controls.Add(this.grpbx_to);
            this.panel4.Controls.Add(this.grpbx_present);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1261, 585);
            this.panel4.TabIndex = 0;
            // 
            // grpbx_QNH
            // 
            this.grpbx_QNH.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_QNH.Controls.Add(this.lbl_sea_level_ft);
            this.grpbx_QNH.Controls.Add(this.lbl_qnh_pressure);
            this.grpbx_QNH.Controls.Add(this.label1);
            this.grpbx_QNH.Controls.Add(this.label2);
            this.grpbx_QNH.Location = new System.Drawing.Point(228, 198);
            this.grpbx_QNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Name = "grpbx_QNH";
            this.grpbx_QNH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Size = new System.Drawing.Size(204, 126);
            this.grpbx_QNH.TabIndex = 24;
            this.grpbx_QNH.TabStop = false;
            this.grpbx_QNH.Text = "QNH";
            // 
            // lbl_sea_level_ft
            // 
            this.lbl_sea_level_ft.Location = new System.Drawing.Point(15, 34);
            this.lbl_sea_level_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sea_level_ft.Name = "lbl_sea_level_ft";
            this.lbl_sea_level_ft.Size = new System.Drawing.Size(132, 18);
            this.lbl_sea_level_ft.TabIndex = 25;
            this.lbl_sea_level_ft.Text = "0";
            // 
            // lbl_qnh_pressure
            // 
            this.lbl_qnh_pressure.Location = new System.Drawing.Point(15, 74);
            this.lbl_qnh_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qnh_pressure.Name = "lbl_qnh_pressure";
            this.lbl_qnh_pressure.Size = new System.Drawing.Size(132, 18);
            this.lbl_qnh_pressure.TabIndex = 24;
            this.lbl_qnh_pressure.Text = "....";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "mb";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(156, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "ft";
            // 
            // btn_calculate_altimiter
            // 
            this.btn_calculate_altimiter.Location = new System.Drawing.Point(864, 407);
            this.btn_calculate_altimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calculate_altimiter.Name = "btn_calculate_altimiter";
            this.btn_calculate_altimiter.Size = new System.Drawing.Size(174, 52);
            this.btn_calculate_altimiter.TabIndex = 22;
            this.btn_calculate_altimiter.Text = "Calculate";
            this.btn_calculate_altimiter.UseVisualStyleBackColor = true;
            this.btn_calculate_altimiter.Click += new System.EventHandler(this.btn_calculate_altimiter_Click);
            // 
            // grpbx_to
            // 
            this.grpbx_to.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_to.Controls.Add(this.lbl_to_pressure);
            this.grpbx_to.Controls.Add(this.lbl_to_mb);
            this.grpbx_to.Controls.Add(this.lbl_to_ft);
            this.grpbx_to.Controls.Add(this.txtbx_to_altitude);
            this.grpbx_to.Location = new System.Drawing.Point(832, 198);
            this.grpbx_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Name = "grpbx_to";
            this.grpbx_to.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Size = new System.Drawing.Size(200, 126);
            this.grpbx_to.TabIndex = 21;
            this.grpbx_to.TabStop = false;
            this.grpbx_to.Text = "Destination QFE";
            // 
            // lbl_to_pressure
            // 
            this.lbl_to_pressure.Location = new System.Drawing.Point(9, 78);
            this.lbl_to_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_pressure.Name = "lbl_to_pressure";
            this.lbl_to_pressure.Size = new System.Drawing.Size(132, 18);
            this.lbl_to_pressure.TabIndex = 23;
            this.lbl_to_pressure.Text = "....";
            // 
            // lbl_to_mb
            // 
            this.lbl_to_mb.Location = new System.Drawing.Point(156, 78);
            this.lbl_to_mb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_mb.Name = "lbl_to_mb";
            this.lbl_to_mb.Size = new System.Drawing.Size(50, 31);
            this.lbl_to_mb.TabIndex = 22;
            this.lbl_to_mb.Text = "mb";
            // 
            // lbl_to_ft
            // 
            this.lbl_to_ft.Location = new System.Drawing.Point(156, 38);
            this.lbl_to_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_ft.Name = "lbl_to_ft";
            this.lbl_to_ft.Size = new System.Drawing.Size(26, 31);
            this.lbl_to_ft.TabIndex = 21;
            this.lbl_to_ft.Text = "ft";
            // 
            // txtbx_to_altitude
            // 
            this.txtbx_to_altitude.Location = new System.Drawing.Point(9, 34);
            this.txtbx_to_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_to_altitude.Name = "txtbx_to_altitude";
            this.txtbx_to_altitude.Size = new System.Drawing.Size(136, 26);
            this.txtbx_to_altitude.TabIndex = 19;
            // 
            // grpbx_present
            // 
            this.grpbx_present.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_present.Controls.Add(this.lbl_present_mb);
            this.grpbx_present.Controls.Add(this.lbl_present_ft);
            this.grpbx_present.Controls.Add(this.txtbx_present_pressure);
            this.grpbx_present.Controls.Add(this.txtbx_present_altitude);
            this.grpbx_present.Location = new System.Drawing.Point(528, 198);
            this.grpbx_present.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Name = "grpbx_present";
            this.grpbx_present.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Size = new System.Drawing.Size(204, 126);
            this.grpbx_present.TabIndex = 20;
            this.grpbx_present.TabStop = false;
            this.grpbx_present.Text = "Present QFE";
            // 
            // lbl_present_mb
            // 
            this.lbl_present_mb.Location = new System.Drawing.Point(156, 74);
            this.lbl_present_mb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_present_mb.Name = "lbl_present_mb";
            this.lbl_present_mb.Size = new System.Drawing.Size(44, 31);
            this.lbl_present_mb.TabIndex = 18;
            this.lbl_present_mb.Text = "mb";
            // 
            // lbl_present_ft
            // 
            this.lbl_present_ft.Location = new System.Drawing.Point(156, 34);
            this.lbl_present_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_present_ft.Name = "lbl_present_ft";
            this.lbl_present_ft.Size = new System.Drawing.Size(26, 31);
            this.lbl_present_ft.TabIndex = 17;
            this.lbl_present_ft.Text = "ft";
            // 
            // txtbx_present_pressure
            // 
            this.txtbx_present_pressure.Location = new System.Drawing.Point(9, 69);
            this.txtbx_present_pressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_pressure.Name = "txtbx_present_pressure";
            this.txtbx_present_pressure.Size = new System.Drawing.Size(136, 26);
            this.txtbx_present_pressure.TabIndex = 16;
            // 
            // txtbx_present_altitude
            // 
            this.txtbx_present_altitude.Location = new System.Drawing.Point(9, 29);
            this.txtbx_present_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_altitude.Name = "txtbx_present_altitude";
            this.txtbx_present_altitude.Size = new System.Drawing.Size(136, 26);
            this.txtbx_present_altitude.TabIndex = 15;
            // 
            // btn_altimeter_reset
            // 
            this.btn_altimeter_reset.Location = new System.Drawing.Point(578, 407);
            this.btn_altimeter_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_altimeter_reset.Name = "btn_altimeter_reset";
            this.btn_altimeter_reset.Size = new System.Drawing.Size(174, 52);
            this.btn_altimeter_reset.TabIndex = 25;
            this.btn_altimeter_reset.Text = "Reset";
            this.btn_altimeter_reset.UseVisualStyleBackColor = true;
            this.btn_altimeter_reset.Click += new System.EventHandler(this.btn_altimeter_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Metar-Taf Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_egmj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmj)).EndInit();
            this.tab_egss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss)).EndInit();
            this.tab_eggw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_eggw)).EndInit();
            this.tab_notams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_notams_egmj)).EndInit();
            this.tab_met_office.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_met)).EndInit();
            this.tab_bbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_bbc)).EndInit();
            this.tab_synoptic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_synoptic)).EndInit();
            this.tab_browser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_browser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpbx_towns.ResumeLayout(false);
            this.grpbx_towns.PerformLayout();
            this.tab_altimeter.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpbx_QNH.ResumeLayout(false);
            this.grpbx_to.ResumeLayout(false);
            this.grpbx_to.PerformLayout();
            this.grpbx_present.ResumeLayout(false);
            this.grpbx_present.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_egss;
        private System.Windows.Forms.TabPage tab_eggw;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egss;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_eggw;
        private System.Windows.Forms.TabPage tab_met_office;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_weather_met;
        private System.Windows.Forms.TabPage tab_bbc;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_weather_bbc;
        private System.Windows.Forms.TabPage tab_synoptic;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_synoptic;
        private System.Windows.Forms.TabPage tab_egmj;
        private System.Windows.Forms.TabPage tab_notams;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_notams_egmj;
        private System.Windows.Forms.Button btn_navigate_to;
        private System.Windows.Forms.TextBox txtbx_navigate_to_url;
        private System.Windows.Forms.TabPage tab_browser;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_browser;
        private System.Windows.Forms.GroupBox grpbx_towns;
        private System.Windows.Forms.RadioButton rdobtn_Gt_Gransden;
        private System.Windows.Forms.RadioButton rdobtn_cambridge;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_egmj;
        private System.Windows.Forms.ComboBox cmbobx_airports;
        private System.Windows.Forms.TabPage tab_altimeter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpbx_QNH;
        private System.Windows.Forms.Label lbl_sea_level_ft;
        private System.Windows.Forms.Label lbl_qnh_pressure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calculate_altimiter;
        private System.Windows.Forms.GroupBox grpbx_to;
        private System.Windows.Forms.Label lbl_to_pressure;
        private System.Windows.Forms.Label lbl_to_mb;
        private System.Windows.Forms.Label lbl_to_ft;
        private System.Windows.Forms.TextBox txtbx_to_altitude;
        private System.Windows.Forms.GroupBox grpbx_present;
        private System.Windows.Forms.Label lbl_present_mb;
        private System.Windows.Forms.Label lbl_present_ft;
        private System.Windows.Forms.TextBox txtbx_present_pressure;
        private System.Windows.Forms.TextBox txtbx_present_altitude;
        private System.Windows.Forms.Button btn_altimeter_reset;
    }
}

