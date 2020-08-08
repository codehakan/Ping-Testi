namespace Ping_Testi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_localPING = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_internetPING = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modem_sunucu = new System.Windows.Forms.Label();
            this.hat_sunucu = new System.Windows.Forms.Label();
            this.lol_sunucu = new System.Windows.Forms.Label();
            this.lbl_lolPING = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.csgo_sunucu = new System.Windows.Forms.Label();
            this.lbl_csgoPING = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.csgo_sunucu);
            this.groupControl1.Controls.Add(this.lbl_csgoPING);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.lol_sunucu);
            this.groupControl1.Controls.Add(this.lbl_lolPING);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.hat_sunucu);
            this.groupControl1.Controls.Add(this.modem_sunucu);
            this.groupControl1.Controls.Add(this.lbl_internetPING);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.lbl_localPING);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(370, 178);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sunucular / Servers";
            // 
            // lbl_localPING
            // 
            this.lbl_localPING.AutoSize = true;
            this.lbl_localPING.Enabled = false;
            this.lbl_localPING.Location = new System.Drawing.Point(169, 55);
            this.lbl_localPING.Name = "lbl_localPING";
            this.lbl_localPING.Size = new System.Drawing.Size(35, 17);
            this.lbl_localPING.TabIndex = 1;
            this.lbl_localPING.Text = "- ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modem";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 196);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(370, 34);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Ping Değerlerini Ölç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lbl_internetPING
            // 
            this.lbl_internetPING.AutoSize = true;
            this.lbl_internetPING.Enabled = false;
            this.lbl_internetPING.Location = new System.Drawing.Point(169, 86);
            this.lbl_internetPING.Name = "lbl_internetPING";
            this.lbl_internetPING.Size = new System.Drawing.Size(35, 17);
            this.lbl_internetPING.TabIndex = 3;
            this.lbl_internetPING.Text = "- ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hat ";
            // 
            // modem_sunucu
            // 
            this.modem_sunucu.AutoSize = true;
            this.modem_sunucu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modem_sunucu.Font = new System.Drawing.Font("Tahoma", 7F);
            this.modem_sunucu.Location = new System.Drawing.Point(264, 56);
            this.modem_sunucu.Name = "modem_sunucu";
            this.modem_sunucu.Size = new System.Drawing.Size(87, 16);
            this.modem_sunucu.TabIndex = 4;
            this.modem_sunucu.Text = "Sunucu Adresi";
            // 
            // hat_sunucu
            // 
            this.hat_sunucu.AutoSize = true;
            this.hat_sunucu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hat_sunucu.Font = new System.Drawing.Font("Tahoma", 7F);
            this.hat_sunucu.Location = new System.Drawing.Point(264, 84);
            this.hat_sunucu.Name = "hat_sunucu";
            this.hat_sunucu.Size = new System.Drawing.Size(87, 16);
            this.hat_sunucu.TabIndex = 5;
            this.hat_sunucu.Text = "Sunucu Adresi";
            // 
            // lol_sunucu
            // 
            this.lol_sunucu.AutoSize = true;
            this.lol_sunucu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lol_sunucu.Font = new System.Drawing.Font("Tahoma", 7F);
            this.lol_sunucu.Location = new System.Drawing.Point(264, 114);
            this.lol_sunucu.Name = "lol_sunucu";
            this.lol_sunucu.Size = new System.Drawing.Size(87, 16);
            this.lol_sunucu.TabIndex = 8;
            this.lol_sunucu.Text = "Sunucu Adresi";
            // 
            // lbl_lolPING
            // 
            this.lbl_lolPING.AutoSize = true;
            this.lbl_lolPING.Enabled = false;
            this.lbl_lolPING.Location = new System.Drawing.Point(169, 116);
            this.lbl_lolPING.Name = "lbl_lolPING";
            this.lbl_lolPING.Size = new System.Drawing.Size(35, 17);
            this.lbl_lolPING.TabIndex = 7;
            this.lbl_lolPING.Text = "- ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "League of Legends";
            // 
            // csgo_sunucu
            // 
            this.csgo_sunucu.AutoSize = true;
            this.csgo_sunucu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.csgo_sunucu.Font = new System.Drawing.Font("Tahoma", 7F);
            this.csgo_sunucu.Location = new System.Drawing.Point(264, 143);
            this.csgo_sunucu.Name = "csgo_sunucu";
            this.csgo_sunucu.Size = new System.Drawing.Size(87, 16);
            this.csgo_sunucu.TabIndex = 11;
            this.csgo_sunucu.Text = "Sunucu Adresi";
            // 
            // lbl_csgoPING
            // 
            this.lbl_csgoPING.AutoSize = true;
            this.lbl_csgoPING.Enabled = false;
            this.lbl_csgoPING.Location = new System.Drawing.Point(169, 145);
            this.lbl_csgoPING.Name = "lbl_csgoPING";
            this.lbl_csgoPING.Size = new System.Drawing.Size(35, 17);
            this.lbl_csgoPING.TabIndex = 10;
            this.lbl_csgoPING.Text = "- ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "CS:GO";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 246);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(379, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "reload58 - hakanbey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Testi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbl_localPING;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lbl_internetPING;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hat_sunucu;
        private System.Windows.Forms.Label modem_sunucu;
        private System.Windows.Forms.Label lol_sunucu;
        private System.Windows.Forms.Label lbl_lolPING;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label csgo_sunucu;
        private System.Windows.Forms.Label lbl_csgoPING;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

