
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
            this.btn_navigate_to.Location = new System.Drawing.Point(1102, 17);
            this.btn_navigate_to.Name = "btn_navigate_to";
            this.btn_navigate_to.Size = new System.Drawing.Size(132, 44);
            this.btn_navigate_to.TabIndex = 1;
            this.btn_navigate_to.Text = "&Go";
            this.btn_navigate_to.UseVisualStyleBackColor = true;
            this.btn_navigate_to.Click += new System.EventHandler(this.btn_navigate_to_Click);
            // 
            // txtbx_navigate_to_url
            // 
            this.txtbx_navigate_to_url.Location = new System.Drawing.Point(642, 26);
            this.txtbx_navigate_to_url.Name = "txtbx_navigate_to_url";
            this.txtbx_navigate_to_url.Size = new System.Drawing.Size(429, 26);
            this.txtbx_navigate_to_url.TabIndex = 0;
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
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egmj;
        private System.Windows.Forms.TabPage tab_notams;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_notams_egmj;
        private System.Windows.Forms.Button btn_navigate_to;
        private System.Windows.Forms.TextBox txtbx_navigate_to_url;
        private System.Windows.Forms.TabPage tab_browser;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_browser;
        private System.Windows.Forms.GroupBox grpbx_towns;
        private System.Windows.Forms.RadioButton rdobtn_Gt_Gransden;
        private System.Windows.Forms.RadioButton rdobtn_cambridge;
    }
}

