
namespace BasariCariKart
{
    partial class frmLogScr
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
            this.Giriş = new System.Windows.Forms.TabPage();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.lblUId = new System.Windows.Forms.Label();
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.cmbAuth = new System.Windows.Forms.ComboBox();
            this.txtSPass = new System.Windows.Forms.TextBox();
            this.lblSPass = new System.Windows.Forms.Label();
            this.txtSUId = new System.Windows.Forms.TextBox();
            this.lblSUId = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.Giriş.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Giriş
            // 
            this.Giriş.BackColor = System.Drawing.Color.Transparent;
            this.Giriş.Controls.Add(this.btnGiris);
            this.Giriş.Controls.Add(this.txtPass);
            this.Giriş.Controls.Add(this.lblPass);
            this.Giriş.Controls.Add(this.txtUId);
            this.Giriş.Controls.Add(this.lblUId);
            this.Giriş.Location = new System.Drawing.Point(4, 22);
            this.Giriş.Name = "Giriş";
            this.Giriş.Padding = new System.Windows.Forms.Padding(3);
            this.Giriş.Size = new System.Drawing.Size(304, 193);
            this.Giriş.TabIndex = 0;
            this.Giriş.Text = "Giriş";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(175, 117);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(88, 31);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(130, 74);
            this.txtPass.MaxLength = 30;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(37, 75);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(37, 17);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Şifre";
            // 
            // txtUId
            // 
            this.txtUId.Location = new System.Drawing.Point(130, 42);
            this.txtUId.MaxLength = 30;
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(133, 20);
            this.txtUId.TabIndex = 5;
            // 
            // lblUId
            // 
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUId.Location = new System.Drawing.Point(37, 43);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(84, 17);
            this.lblUId.TabIndex = 8;
            this.lblUId.Text = "Kullanıcı Adı";
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.Giriş);
            this.tabLogin.Controls.Add(this.tabSettings);
            this.tabLogin.Location = new System.Drawing.Point(12, 12);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(312, 219);
            this.tabLogin.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.Transparent;
            this.tabSettings.Controls.Add(this.btnKaydet);
            this.tabSettings.Controls.Add(this.btnTest);
            this.tabSettings.Controls.Add(this.cmbServer);
            this.tabSettings.Controls.Add(this.cmbAuth);
            this.tabSettings.Controls.Add(this.txtSPass);
            this.tabSettings.Controls.Add(this.lblSPass);
            this.tabSettings.Controls.Add(this.txtSUId);
            this.tabSettings.Controls.Add(this.lblSUId);
            this.tabSettings.Controls.Add(this.lblAuth);
            this.tabSettings.Controls.Add(this.lblServer);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(304, 193);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Ayarlar";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.Location = new System.Drawing.Point(196, 146);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 31);
            this.btnTest.TabIndex = 21;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(151, 19);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(133, 21);
            this.cmbServer.TabIndex = 20;
            // 
            // cmbAuth
            // 
            this.cmbAuth.FormattingEnabled = true;
            this.cmbAuth.Items.AddRange(new object[] {
            "Windows",
            "Sql Server"});
            this.cmbAuth.Location = new System.Drawing.Point(151, 49);
            this.cmbAuth.Name = "cmbAuth";
            this.cmbAuth.Size = new System.Drawing.Size(133, 21);
            this.cmbAuth.TabIndex = 19;
            this.cmbAuth.SelectedIndexChanged += new System.EventHandler(this.cmbAuth_SelectedIndexChanged);
            // 
            // txtSPass
            // 
            this.txtSPass.Location = new System.Drawing.Point(151, 109);
            this.txtSPass.MaxLength = 30;
            this.txtSPass.Name = "txtSPass";
            this.txtSPass.ReadOnly = true;
            this.txtSPass.Size = new System.Drawing.Size(133, 20);
            this.txtSPass.TabIndex = 16;
            this.txtSPass.UseSystemPasswordChar = true;
            // 
            // lblSPass
            // 
            this.lblSPass.AutoSize = true;
            this.lblSPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSPass.Location = new System.Drawing.Point(6, 109);
            this.lblSPass.Name = "lblSPass";
            this.lblSPass.Size = new System.Drawing.Size(37, 17);
            this.lblSPass.TabIndex = 18;
            this.lblSPass.Text = "Şifre";
            // 
            // txtSUId
            // 
            this.txtSUId.Location = new System.Drawing.Point(151, 79);
            this.txtSUId.MaxLength = 30;
            this.txtSUId.Name = "txtSUId";
            this.txtSUId.ReadOnly = true;
            this.txtSUId.Size = new System.Drawing.Size(133, 20);
            this.txtSUId.TabIndex = 15;
            // 
            // lblSUId
            // 
            this.lblSUId.AutoSize = true;
            this.lblSUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSUId.Location = new System.Drawing.Point(6, 79);
            this.lblSUId.Name = "lblSUId";
            this.lblSUId.Size = new System.Drawing.Size(84, 17);
            this.lblSUId.TabIndex = 17;
            this.lblSUId.Text = "Kullanıcı Adı";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuth.Location = new System.Drawing.Point(6, 49);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(132, 17);
            this.lblAuth.TabIndex = 14;
            this.lblAuth.Text = "Doğrulama Yöntemi";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServer.Location = new System.Drawing.Point(6, 19);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(80, 17);
            this.lblServer.TabIndex = 13;
            this.lblServer.Text = "Sunucu Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(102, 146);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 31);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmLogScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 243);
            this.Controls.Add(this.tabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLogScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.frmLogScr_Load);
            this.Giriş.ResumeLayout(false);
            this.Giriş.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Giriş;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cmbAuth;
        private System.Windows.Forms.TextBox txtSPass;
        private System.Windows.Forms.Label lblSPass;
        private System.Windows.Forms.TextBox txtSUId;
        private System.Windows.Forms.Label lblSUId;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnKaydet;
    }
}