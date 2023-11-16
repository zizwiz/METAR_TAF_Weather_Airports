
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
            this.tab_altimeter = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_calculate_altimiter = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grpbx_to = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_to_pressure = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_to_altitude = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grpbx_present = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtbx_present_altitude = new System.Windows.Forms.TextBox();
            this.txtbx_present_pressure = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grpbx_QNH = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_sea_level_ft = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_qnh_pressure = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.grpbx_altimeter = new System.Windows.Forms.GroupBox();
            this.rdobtn_destination = new System.Windows.Forms.RadioButton();
            this.rdobtn_present = new System.Windows.Forms.RadioButton();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpbx_browser_navigation = new System.Windows.Forms.GroupBox();
            this.btn_navigate_to = new System.Windows.Forms.Button();
            this.txtbx_navigate_to_url = new System.Windows.Forms.TextBox();
            this.cmbobx_airport_info = new System.Windows.Forms.ComboBox();
            this.grpbx_towns = new System.Windows.Forms.GroupBox();
            this.rdobtn_Gt_Gransden = new System.Windows.Forms.RadioButton();
            this.rdobtn_cambridge = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lbl_p_airport_name = new System.Windows.Forms.Label();
            this.lbl_p_icao_code = new System.Windows.Forms.Label();
            this.lbl_p_latitude_dec = new System.Windows.Forms.Label();
            this.lbl_p_latitude_deg = new System.Windows.Forms.Label();
            this.lbl_p_longitude_dec = new System.Windows.Forms.Label();
            this.lbl_p_longitude_deg = new System.Windows.Forms.Label();
            this.lbl_p_elevation_m = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lbl_d_elevation_m = new System.Windows.Forms.Label();
            this.lbl_d_longitude_dec = new System.Windows.Forms.Label();
            this.lbl_d_longitude_deg = new System.Windows.Forms.Label();
            this.lbl_d_latitude_dec = new System.Windows.Forms.Label();
            this.lbl_d_latitude_deg = new System.Windows.Forms.Label();
            this.lbl_d_icao_code = new System.Windows.Forms.Label();
            this.lbl_d_airport_name = new System.Windows.Forms.Label();
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
            this.tab_altimeter.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grpbx_to.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel8.SuspendLayout();
            this.grpbx_present.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grpbx_QNH.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.grpbx_altimeter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpbx_browser_navigation.SuspendLayout();
            this.grpbx_towns.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel34.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 784);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 598);
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
            this.tabControl1.Size = new System.Drawing.Size(1269, 598);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_egmj
            // 
            this.tab_egmj.Controls.Add(this.webView_egmj);
            this.tab_egmj.Location = new System.Drawing.Point(4, 29);
            this.tab_egmj.Name = "tab_egmj";
            this.tab_egmj.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_egmj.Size = new System.Drawing.Size(1261, 565);
            this.webView_egmj.TabIndex = 0;
            this.webView_egmj.ZoomFactor = 1D;
            // 
            // tab_egss
            // 
            this.tab_egss.Controls.Add(this.webView_egss);
            this.tab_egss.Location = new System.Drawing.Point(4, 29);
            this.tab_egss.Name = "tab_egss";
            this.tab_egss.Padding = new System.Windows.Forms.Padding(3);
            this.tab_egss.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_egss.Size = new System.Drawing.Size(1255, 559);
            this.webView_egss.TabIndex = 0;
            this.webView_egss.ZoomFactor = 1D;
            // 
            // tab_eggw
            // 
            this.tab_eggw.Controls.Add(this.webView_eggw);
            this.tab_eggw.Location = new System.Drawing.Point(4, 29);
            this.tab_eggw.Name = "tab_eggw";
            this.tab_eggw.Padding = new System.Windows.Forms.Padding(3);
            this.tab_eggw.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_eggw.Size = new System.Drawing.Size(1255, 559);
            this.webView_eggw.TabIndex = 0;
            this.webView_eggw.ZoomFactor = 1D;
            // 
            // tab_notams
            // 
            this.tab_notams.Controls.Add(this.webView_notams_egmj);
            this.tab_notams.Location = new System.Drawing.Point(4, 29);
            this.tab_notams.Name = "tab_notams";
            this.tab_notams.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_notams_egmj.Size = new System.Drawing.Size(1261, 565);
            this.webView_notams_egmj.TabIndex = 0;
            this.webView_notams_egmj.ZoomFactor = 1D;
            // 
            // tab_met_office
            // 
            this.tab_met_office.Controls.Add(this.webView_weather_met);
            this.tab_met_office.Location = new System.Drawing.Point(4, 29);
            this.tab_met_office.Name = "tab_met_office";
            this.tab_met_office.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_weather_met.Size = new System.Drawing.Size(1261, 565);
            this.webView_weather_met.TabIndex = 0;
            this.webView_weather_met.ZoomFactor = 1D;
            // 
            // tab_bbc
            // 
            this.tab_bbc.Controls.Add(this.webView_weather_bbc);
            this.tab_bbc.Location = new System.Drawing.Point(4, 29);
            this.tab_bbc.Name = "tab_bbc";
            this.tab_bbc.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_weather_bbc.Size = new System.Drawing.Size(1261, 565);
            this.webView_weather_bbc.TabIndex = 0;
            this.webView_weather_bbc.ZoomFactor = 1D;
            // 
            // tab_synoptic
            // 
            this.tab_synoptic.Controls.Add(this.webView_synoptic);
            this.tab_synoptic.Location = new System.Drawing.Point(4, 29);
            this.tab_synoptic.Name = "tab_synoptic";
            this.tab_synoptic.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_synoptic.Size = new System.Drawing.Size(1261, 565);
            this.webView_synoptic.TabIndex = 0;
            this.webView_synoptic.ZoomFactor = 1D;
            // 
            // tab_browser
            // 
            this.tab_browser.Controls.Add(this.webView_browser);
            this.tab_browser.Location = new System.Drawing.Point(4, 29);
            this.tab_browser.Name = "tab_browser";
            this.tab_browser.Size = new System.Drawing.Size(1261, 565);
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
            this.webView_browser.Size = new System.Drawing.Size(1261, 565);
            this.webView_browser.TabIndex = 0;
            this.webView_browser.ZoomFactor = 1D;
            // 
            // tab_altimeter
            // 
            this.tab_altimeter.Controls.Add(this.panel4);
            this.tab_altimeter.Location = new System.Drawing.Point(4, 29);
            this.tab_altimeter.Name = "tab_altimeter";
            this.tab_altimeter.Size = new System.Drawing.Size(1261, 565);
            this.tab_altimeter.TabIndex = 8;
            this.tab_altimeter.Text = "Altimeter";
            this.tab_altimeter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1261, 565);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel19, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel20, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel23, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel24, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1261, 565);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(507, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 74);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_calculate_altimiter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(885, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 74);
            this.panel6.TabIndex = 26;
            // 
            // btn_calculate_altimiter
            // 
            this.btn_calculate_altimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calculate_altimiter.Location = new System.Drawing.Point(0, 0);
            this.btn_calculate_altimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calculate_altimiter.Name = "btn_calculate_altimiter";
            this.btn_calculate_altimiter.Size = new System.Drawing.Size(246, 74);
            this.btn_calculate_altimiter.TabIndex = 22;
            this.btn_calculate_altimiter.Text = "Calculate";
            this.btn_calculate_altimiter.UseVisualStyleBackColor = true;
            this.btn_calculate_altimiter.Click += new System.EventHandler(this.btn_calculate_altimiter_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grpbx_to);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(885, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 359);
            this.panel7.TabIndex = 27;
            // 
            // grpbx_to
            // 
            this.grpbx_to.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_to.Controls.Add(this.tableLayoutPanel5);
            this.grpbx_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_to.Location = new System.Drawing.Point(0, 0);
            this.grpbx_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Name = "grpbx_to";
            this.grpbx_to.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Size = new System.Drawing.Size(246, 359);
            this.grpbx_to.TabIndex = 21;
            this.grpbx_to.TabStop = false;
            this.grpbx_to.Text = "Destination QFE";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel21, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtbx_to_altitude, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel22, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_to_pressure, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel18, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(238, 330);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // lbl_to_pressure
            // 
            this.lbl_to_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_to_pressure.Location = new System.Drawing.Point(4, 50);
            this.lbl_to_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_pressure.Name = "lbl_to_pressure";
            this.lbl_to_pressure.Size = new System.Drawing.Size(170, 30);
            this.lbl_to_pressure.TabIndex = 23;
            this.lbl_to_pressure.Text = "....";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label3);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(191, 13);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(44, 24);
            this.panel21.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "ft";
            // 
            // txtbx_to_altitude
            // 
            this.txtbx_to_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_to_altitude.Location = new System.Drawing.Point(4, 15);
            this.txtbx_to_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_to_altitude.Name = "txtbx_to_altitude";
            this.txtbx_to_altitude.Size = new System.Drawing.Size(170, 26);
            this.txtbx_to_altitude.TabIndex = 19;
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(191, 43);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(44, 4);
            this.panel22.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(192, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "mb";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grpbx_present);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(507, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(246, 359);
            this.panel8.TabIndex = 28;
            // 
            // grpbx_present
            // 
            this.grpbx_present.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_present.Controls.Add(this.tableLayoutPanel4);
            this.grpbx_present.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_present.Location = new System.Drawing.Point(0, 0);
            this.grpbx_present.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Name = "grpbx_present";
            this.grpbx_present.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Size = new System.Drawing.Size(246, 359);
            this.grpbx_present.TabIndex = 20;
            this.grpbx_present.TabStop = false;
            this.grpbx_present.Text = "Present QFE";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel15, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel17, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel30, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel37, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel16, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(238, 330);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtbx_present_altitude);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 13);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(172, 24);
            this.panel15.TabIndex = 0;
            // 
            // txtbx_present_altitude
            // 
            this.txtbx_present_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_present_altitude.Location = new System.Drawing.Point(0, 0);
            this.txtbx_present_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_altitude.Name = "txtbx_present_altitude";
            this.txtbx_present_altitude.Size = new System.Drawing.Size(172, 26);
            this.txtbx_present_altitude.TabIndex = 15;
            // 
            // txtbx_present_pressure
            // 
            this.txtbx_present_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_present_pressure.Location = new System.Drawing.Point(0, 0);
            this.txtbx_present_pressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_pressure.Name = "txtbx_present_pressure";
            this.txtbx_present_pressure.Size = new System.Drawing.Size(172, 26);
            this.txtbx_present_pressure.TabIndex = 16;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(191, 13);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(44, 24);
            this.panel17.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "ft";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "mb";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grpbx_QNH);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(129, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(246, 359);
            this.panel9.TabIndex = 29;
            // 
            // grpbx_QNH
            // 
            this.grpbx_QNH.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_QNH.Controls.Add(this.tableLayoutPanel3);
            this.grpbx_QNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_QNH.Location = new System.Drawing.Point(0, 0);
            this.grpbx_QNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Name = "grpbx_QNH";
            this.grpbx_QNH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Size = new System.Drawing.Size(246, 359);
            this.grpbx_QNH.TabIndex = 24;
            this.grpbx_QNH.TabStop = false;
            this.grpbx_QNH.Text = "QNH";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel12, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel13, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel14, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 330);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl_sea_level_ft);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(172, 44);
            this.panel11.TabIndex = 0;
            // 
            // lbl_sea_level_ft
            // 
            this.lbl_sea_level_ft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sea_level_ft.Location = new System.Drawing.Point(0, 0);
            this.lbl_sea_level_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sea_level_ft.Name = "lbl_sea_level_ft";
            this.lbl_sea_level_ft.Size = new System.Drawing.Size(172, 44);
            this.lbl_sea_level_ft.TabIndex = 25;
            this.lbl_sea_level_ft.Text = "0";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbl_qnh_pressure);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 73);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(172, 44);
            this.panel12.TabIndex = 1;
            // 
            // lbl_qnh_pressure
            // 
            this.lbl_qnh_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_qnh_pressure.Location = new System.Drawing.Point(0, 0);
            this.lbl_qnh_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qnh_pressure.Name = "lbl_qnh_pressure";
            this.lbl_qnh_pressure.Size = new System.Drawing.Size(172, 44);
            this.lbl_qnh_pressure.TabIndex = 24;
            this.lbl_qnh_pressure.Text = "....";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(191, 23);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(44, 44);
            this.panel13.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "ft";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(191, 73);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(44, 44);
            this.panel14.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "mb";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(129, 448);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 74);
            this.panel10.TabIndex = 30;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(507, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(246, 34);
            this.panel19.TabIndex = 31;
            // 
            // grpbx_altimeter
            // 
            this.grpbx_altimeter.Controls.Add(this.rdobtn_destination);
            this.grpbx_altimeter.Controls.Add(this.rdobtn_present);
            this.grpbx_altimeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_altimeter.Location = new System.Drawing.Point(0, 0);
            this.grpbx_altimeter.Name = "grpbx_altimeter";
            this.grpbx_altimeter.Size = new System.Drawing.Size(138, 88);
            this.grpbx_altimeter.TabIndex = 1;
            this.grpbx_altimeter.TabStop = false;
            // 
            // rdobtn_destination
            // 
            this.rdobtn_destination.AutoSize = true;
            this.rdobtn_destination.Location = new System.Drawing.Point(6, 52);
            this.rdobtn_destination.Name = "rdobtn_destination";
            this.rdobtn_destination.Size = new System.Drawing.Size(115, 24);
            this.rdobtn_destination.TabIndex = 0;
            this.rdobtn_destination.TabStop = true;
            this.rdobtn_destination.Text = "Destination";
            this.rdobtn_destination.UseVisualStyleBackColor = true;
            // 
            // rdobtn_present
            // 
            this.rdobtn_present.AutoSize = true;
            this.rdobtn_present.Checked = true;
            this.rdobtn_present.Location = new System.Drawing.Point(6, 22);
            this.rdobtn_present.Name = "rdobtn_present";
            this.rdobtn_present.Size = new System.Drawing.Size(89, 24);
            this.rdobtn_present.TabIndex = 0;
            this.rdobtn_present.TabStop = true;
            this.rdobtn_present.Text = "Present";
            this.rdobtn_present.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(885, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(246, 34);
            this.panel20.TabIndex = 32;
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(129, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(246, 34);
            this.panel23.TabIndex = 33;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(381, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(120, 34);
            this.panel24.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 74);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1269, 94);
            this.panel3.TabIndex = 2;
            // 
            // grpbx_browser_navigation
            // 
            this.grpbx_browser_navigation.Controls.Add(this.tableLayoutPanel8);
            this.grpbx_browser_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_browser_navigation.Location = new System.Drawing.Point(0, 0);
            this.grpbx_browser_navigation.Name = "grpbx_browser_navigation";
            this.grpbx_browser_navigation.Size = new System.Drawing.Size(584, 88);
            this.grpbx_browser_navigation.TabIndex = 5;
            this.grpbx_browser_navigation.TabStop = false;
            // 
            // btn_navigate_to
            // 
            this.btn_navigate_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigate_to.Location = new System.Drawing.Point(0, 0);
            this.btn_navigate_to.Name = "btn_navigate_to";
            this.btn_navigate_to.Size = new System.Drawing.Size(94, 57);
            this.btn_navigate_to.TabIndex = 1;
            this.btn_navigate_to.Text = "&Go";
            this.btn_navigate_to.UseVisualStyleBackColor = true;
            this.btn_navigate_to.Click += new System.EventHandler(this.btn_navigate_to_Click);
            // 
            // txtbx_navigate_to_url
            // 
            this.txtbx_navigate_to_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_navigate_to_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_navigate_to_url.Location = new System.Drawing.Point(0, 0);
            this.txtbx_navigate_to_url.Name = "txtbx_navigate_to_url";
            this.txtbx_navigate_to_url.Size = new System.Drawing.Size(470, 26);
            this.txtbx_navigate_to_url.TabIndex = 0;
            this.txtbx_navigate_to_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_navigate_to_url_KeyPress);
            // 
            // cmbobx_airport_info
            // 
            this.cmbobx_airport_info.FormattingEnabled = true;
            this.cmbobx_airport_info.Items.AddRange(new object[] {
            " Choose Airport Below",
            "AAC Middle Wallop",
            "Aberdeen Airport",
            "Aberporth Airport",
            "Aintree Heliport",
            "Alderney Airport",
            "Andrewsfield Aerodrome",
            "Anglesey Airport",
            "Anwick",
            "Ascot Racecourse Heliport",
            "Ashcroft",
            "Audley End Airfield",
            "Bagby Airfield",
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
            "Bruntingthorpe Aerodrome",
            "Caernarfon Airport",
            "Cambridge City Airport",
            "Campbeltown Airport ",
            "Cardiff Airport",
            "Cardiff Heliport",
            "Carlisle Lake District Airport",
            "Chalgrove Airfield",
            "Challock Airfield",
            "Cheltenham Racecourse Heliport",
            "Chester Hawarden Airport",
            "Chichester/Goodwood Airport",
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
            "Deenethorpe",
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
            "Holyhead Heliport",
            "Humberside Airport",
            "Hunsdon",
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
            "Leicester Airport",
            "Leuchars Station",
            "Little Gransden Airfield",
            "Liverpool John Lennon Airport",
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
            "Main Hall Farm Airfield",
            "Manchester Airport",
            "Manchester Barton Aerodrome",
            "Manston Airport",
            "Marshland",
            "Maypole",
            "MoD Boscombe Down",
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
            "Papa Westray Airport",
            "Pembrey Airport",
            "Penzance Heliport",
            "Perranporth Airfield",
            "Perth Airport",
            "Peterborough Business Airport",
            "Peterborough Sibson",
            "Plymouth",
            "Popham Airfield",
            "Portland Heliport",
            "RAF Barkston Heath",
            "RAF Benson",
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
            "RAF Lakenheath",
            "RAF Leeming",
            "RAF Linton-on-Ouse",
            "RAF Lossiemouth",
            "RAF Lyneham",
            "RAF Marham",
            "RAF Mildenhall",
            "RAF Northolt",
            "RAF Odiham",
            "RAF Scampton",
            "RAF Shawbury",
            "RAF Ternhill",
            "RAF Topcliffe",
            "RAF Waddington",
            "RAF Wittering",
            "RAF Woodvale",
            "RAF Wyton",
            "Redhill Aerodrome",
            "Retford Gamston Airport",
            "RNAS Culdrose",
            "RNAS Yeovilton",
            "Rochester Airport",
            "Royal Marines Base Chivenor",
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
            "Thruxton Aerodrome",
            "Thurrock",
            "Tilstock",
            "Tingwall Airport",
            "Tiree Airport",
            "Tresco Heliport",
            "Truro Aerodrome",
            "Turweston Aerodrome",
            "Unst Airport",
            "Upavon",
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
            "Wycombe Air Park",
            "Yeovil Aerodrome"});
            this.cmbobx_airport_info.Location = new System.Drawing.Point(6, 32);
            this.cmbobx_airport_info.Name = "cmbobx_airport_info";
            this.cmbobx_airport_info.Size = new System.Drawing.Size(318, 28);
            this.cmbobx_airport_info.Sorted = true;
            this.cmbobx_airport_info.TabIndex = 0;
            this.cmbobx_airport_info.SelectedIndexChanged += new System.EventHandler(this.cmbobx_airport_info_SelectedIndexChanged);
            // 
            // grpbx_towns
            // 
            this.grpbx_towns.Controls.Add(this.rdobtn_Gt_Gransden);
            this.grpbx_towns.Controls.Add(this.rdobtn_cambridge);
            this.grpbx_towns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_towns.Location = new System.Drawing.Point(0, 0);
            this.grpbx_towns.Name = "grpbx_towns";
            this.grpbx_towns.Size = new System.Drawing.Size(149, 88);
            this.grpbx_towns.TabIndex = 4;
            this.grpbx_towns.TabStop = false;
            // 
            // rdobtn_Gt_Gransden
            // 
            this.rdobtn_Gt_Gransden.AutoSize = true;
            this.rdobtn_Gt_Gransden.Location = new System.Drawing.Point(15, 52);
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
            this.rdobtn_cambridge.Location = new System.Drawing.Point(15, 22);
            this.rdobtn_cambridge.Name = "rdobtn_cambridge";
            this.rdobtn_cambridge.Size = new System.Drawing.Size(111, 24);
            this.rdobtn_cambridge.TabIndex = 2;
            this.rdobtn_cambridge.TabStop = true;
            this.rdobtn_cambridge.Text = "Cambridge";
            this.rdobtn_cambridge.UseVisualStyleBackColor = true;
            this.rdobtn_cambridge.CheckedChanged += new System.EventHandler(this.rdobtn_cambridge_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 9;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel6.Controls.Add(this.panel25, 8, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel26, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel27, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel28, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel29, 6, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1269, 74);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(199, 68);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btn_close);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(1067, 3);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(199, 68);
            this.panel25.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btn_reset);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(197, 68);
            this.panel26.TabIndex = 1;
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(269, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(197, 68);
            this.panel27.TabIndex = 2;
            // 
            // panel28
            // 
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(535, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(197, 68);
            this.panel28.TabIndex = 3;
            // 
            // panel29
            // 
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(801, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(197, 68);
            this.panel29.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel31, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel32, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel33, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel34, 6, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1269, 94);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.grpbx_towns);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(3, 3);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(149, 88);
            this.panel31.TabIndex = 0;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.grpbx_altimeter);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(173, 3);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(138, 88);
            this.panel32.TabIndex = 1;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.cmbobx_airport_info);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(332, 3);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(329, 88);
            this.panel33.TabIndex = 2;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.grpbx_browser_navigation);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(682, 3);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(584, 88);
            this.panel34.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.Controls.Add(this.panel35, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel36, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(578, 63);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.txtbx_navigate_to_url);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(3, 3);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(470, 57);
            this.panel35.TabIndex = 0;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.btn_navigate_to);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(481, 3);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(94, 57);
            this.panel36.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(197, 68);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.txtbx_present_pressure);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(3, 53);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(172, 24);
            this.panel30.TabIndex = 4;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.label6);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Location = new System.Drawing.Point(191, 53);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(44, 24);
            this.panel37.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.AutoScroll = true;
            this.tableLayoutPanel4.SetColumnSpan(this.panel16, 3);
            this.panel16.Controls.Add(this.lbl_p_elevation_m);
            this.panel16.Controls.Add(this.lbl_p_longitude_dec);
            this.panel16.Controls.Add(this.lbl_p_longitude_deg);
            this.panel16.Controls.Add(this.lbl_p_latitude_dec);
            this.panel16.Controls.Add(this.lbl_p_latitude_deg);
            this.panel16.Controls.Add(this.lbl_p_icao_code);
            this.panel16.Controls.Add(this.lbl_p_airport_name);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 93);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(232, 234);
            this.panel16.TabIndex = 6;
            // 
            // lbl_p_airport_name
            // 
            this.lbl_p_airport_name.AutoSize = true;
            this.lbl_p_airport_name.Location = new System.Drawing.Point(3, 15);
            this.lbl_p_airport_name.Name = "lbl_p_airport_name";
            this.lbl_p_airport_name.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_airport_name.TabIndex = 0;
            this.lbl_p_airport_name.Text = "..";
            // 
            // lbl_p_icao_code
            // 
            this.lbl_p_icao_code.AutoSize = true;
            this.lbl_p_icao_code.Location = new System.Drawing.Point(3, 35);
            this.lbl_p_icao_code.Name = "lbl_p_icao_code";
            this.lbl_p_icao_code.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_icao_code.TabIndex = 1;
            this.lbl_p_icao_code.Text = "..";
            // 
            // lbl_p_latitude_dec
            // 
            this.lbl_p_latitude_dec.AutoSize = true;
            this.lbl_p_latitude_dec.Location = new System.Drawing.Point(3, 92);
            this.lbl_p_latitude_dec.Name = "lbl_p_latitude_dec";
            this.lbl_p_latitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_latitude_dec.TabIndex = 3;
            this.lbl_p_latitude_dec.Text = "..";
            // 
            // lbl_p_latitude_deg
            // 
            this.lbl_p_latitude_deg.AutoSize = true;
            this.lbl_p_latitude_deg.Location = new System.Drawing.Point(3, 72);
            this.lbl_p_latitude_deg.Name = "lbl_p_latitude_deg";
            this.lbl_p_latitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_latitude_deg.TabIndex = 2;
            this.lbl_p_latitude_deg.Text = "..";
            // 
            // lbl_p_longitude_dec
            // 
            this.lbl_p_longitude_dec.AutoSize = true;
            this.lbl_p_longitude_dec.Location = new System.Drawing.Point(3, 148);
            this.lbl_p_longitude_dec.Name = "lbl_p_longitude_dec";
            this.lbl_p_longitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_longitude_dec.TabIndex = 5;
            this.lbl_p_longitude_dec.Text = "..";
            // 
            // lbl_p_longitude_deg
            // 
            this.lbl_p_longitude_deg.AutoSize = true;
            this.lbl_p_longitude_deg.Location = new System.Drawing.Point(3, 128);
            this.lbl_p_longitude_deg.Name = "lbl_p_longitude_deg";
            this.lbl_p_longitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_longitude_deg.TabIndex = 4;
            this.lbl_p_longitude_deg.Text = "..";
            // 
            // lbl_p_elevation_m
            // 
            this.lbl_p_elevation_m.AutoSize = true;
            this.lbl_p_elevation_m.Location = new System.Drawing.Point(3, 187);
            this.lbl_p_elevation_m.Name = "lbl_p_elevation_m";
            this.lbl_p_elevation_m.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_elevation_m.TabIndex = 6;
            this.lbl_p_elevation_m.Text = "..";
            // 
            // panel18
            // 
            this.panel18.AutoScroll = true;
            this.tableLayoutPanel5.SetColumnSpan(this.panel18, 3);
            this.panel18.Controls.Add(this.lbl_d_elevation_m);
            this.panel18.Controls.Add(this.lbl_d_longitude_dec);
            this.panel18.Controls.Add(this.lbl_d_longitude_deg);
            this.panel18.Controls.Add(this.lbl_d_latitude_dec);
            this.panel18.Controls.Add(this.lbl_d_latitude_deg);
            this.panel18.Controls.Add(this.lbl_d_icao_code);
            this.panel18.Controls.Add(this.lbl_d_airport_name);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(3, 93);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(232, 234);
            this.panel18.TabIndex = 24;
            // 
            // lbl_d_elevation_m
            // 
            this.lbl_d_elevation_m.AutoSize = true;
            this.lbl_d_elevation_m.Location = new System.Drawing.Point(3, 187);
            this.lbl_d_elevation_m.Name = "lbl_d_elevation_m";
            this.lbl_d_elevation_m.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_elevation_m.TabIndex = 13;
            this.lbl_d_elevation_m.Text = "..";
            // 
            // lbl_d_longitude_dec
            // 
            this.lbl_d_longitude_dec.AutoSize = true;
            this.lbl_d_longitude_dec.Location = new System.Drawing.Point(3, 148);
            this.lbl_d_longitude_dec.Name = "lbl_d_longitude_dec";
            this.lbl_d_longitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_longitude_dec.TabIndex = 12;
            this.lbl_d_longitude_dec.Text = "..";
            // 
            // lbl_d_longitude_deg
            // 
            this.lbl_d_longitude_deg.AutoSize = true;
            this.lbl_d_longitude_deg.Location = new System.Drawing.Point(3, 128);
            this.lbl_d_longitude_deg.Name = "lbl_d_longitude_deg";
            this.lbl_d_longitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_longitude_deg.TabIndex = 11;
            this.lbl_d_longitude_deg.Text = "..";
            // 
            // lbl_d_latitude_dec
            // 
            this.lbl_d_latitude_dec.AutoSize = true;
            this.lbl_d_latitude_dec.Location = new System.Drawing.Point(3, 92);
            this.lbl_d_latitude_dec.Name = "lbl_d_latitude_dec";
            this.lbl_d_latitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_latitude_dec.TabIndex = 10;
            this.lbl_d_latitude_dec.Text = "..";
            // 
            // lbl_d_latitude_deg
            // 
            this.lbl_d_latitude_deg.AutoSize = true;
            this.lbl_d_latitude_deg.Location = new System.Drawing.Point(3, 72);
            this.lbl_d_latitude_deg.Name = "lbl_d_latitude_deg";
            this.lbl_d_latitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_latitude_deg.TabIndex = 9;
            this.lbl_d_latitude_deg.Text = "..";
            // 
            // lbl_d_icao_code
            // 
            this.lbl_d_icao_code.AutoSize = true;
            this.lbl_d_icao_code.Location = new System.Drawing.Point(3, 35);
            this.lbl_d_icao_code.Name = "lbl_d_icao_code";
            this.lbl_d_icao_code.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_icao_code.TabIndex = 8;
            this.lbl_d_icao_code.Text = "..";
            // 
            // lbl_d_airport_name
            // 
            this.lbl_d_airport_name.AutoSize = true;
            this.lbl_d_airport_name.Location = new System.Drawing.Point(3, 15);
            this.lbl_d_airport_name.Name = "lbl_d_airport_name";
            this.lbl_d_airport_name.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_airport_name.TabIndex = 7;
            this.lbl_d_airport_name.Text = "..";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
            this.tab_altimeter.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.grpbx_to.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.grpbx_present.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.grpbx_QNH.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.grpbx_altimeter.ResumeLayout(false);
            this.grpbx_altimeter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grpbx_browser_navigation.ResumeLayout(false);
            this.grpbx_towns.ResumeLayout(false);
            this.grpbx_towns.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
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
        private System.Windows.Forms.TextBox txtbx_to_altitude;
        private System.Windows.Forms.GroupBox grpbx_present;
        private System.Windows.Forms.TextBox txtbx_present_pressure;
        private System.Windows.Forms.TextBox txtbx_present_altitude;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.RadioButton rdobtn_destination;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.ComboBox cmbobx_airport_info;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.GroupBox grpbx_altimeter;
        private System.Windows.Forms.RadioButton rdobtn_present;
        private System.Windows.Forms.GroupBox grpbx_browser_navigation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbl_p_elevation_m;
        private System.Windows.Forms.Label lbl_p_longitude_dec;
        private System.Windows.Forms.Label lbl_p_longitude_deg;
        private System.Windows.Forms.Label lbl_p_latitude_dec;
        private System.Windows.Forms.Label lbl_p_latitude_deg;
        private System.Windows.Forms.Label lbl_p_icao_code;
        private System.Windows.Forms.Label lbl_p_airport_name;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lbl_d_elevation_m;
        private System.Windows.Forms.Label lbl_d_longitude_dec;
        private System.Windows.Forms.Label lbl_d_longitude_deg;
        private System.Windows.Forms.Label lbl_d_latitude_dec;
        private System.Windows.Forms.Label lbl_d_latitude_deg;
        private System.Windows.Forms.Label lbl_d_icao_code;
        private System.Windows.Forms.Label lbl_d_airport_name;
    }
}

