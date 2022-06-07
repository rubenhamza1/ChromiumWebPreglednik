namespace WebPreglednikVS
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.tsbNewTab = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBrowser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.tsbBack,
            this.tsbForward,
            this.tsbNewTab,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = global::WebPreglednikVS.Properties.Resources.home_icon_free_11549922775iqxl34wxso;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(36, 36);
            this.tsbHome.Text = "Home";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = global::WebPreglednikVS.Properties.Resources.arrowleft;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(36, 36);
            this.tsbBack.Text = "Back";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Image = global::WebPreglednikVS.Properties.Resources.arrowright;
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(36, 36);
            this.tsbForward.Text = "Forward";
            this.tsbForward.Click += new System.EventHandler(this.tsbForward_Click);
            // 
            // tsbNewTab
            // 
            this.tsbNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewTab.Image = global::WebPreglednikVS.Properties.Resources.newtab;
            this.tsbNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewTab.Name = "tsbNewTab";
            this.tsbNewTab.Size = new System.Drawing.Size(36, 36);
            this.tsbNewTab.Text = "New Tab";
            this.tsbNewTab.Click += new System.EventHandler(this.tsbNewTab_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::WebPreglednikVS.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(36, 36);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(970, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBrowser
            // 
            this.txtBrowser.Location = new System.Drawing.Point(12, 42);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Size = new System.Drawing.Size(952, 20);
            this.txtBrowser.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 601);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1275, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBrowser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBrowser;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripButton tsbNewTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}

