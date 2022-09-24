
namespace BasariCariKart
{
    partial class frmCariKartEkle
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
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtAdrIl = new System.Windows.Forms.TextBox();
            this.lblAdrIl = new System.Windows.Forms.Label();
            this.txtAdrAdi = new System.Windows.Forms.TextBox();
            this.lblAdrAdi = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtUnvan2 = new System.Windows.Forms.TextBox();
            this.lblUnvan2 = new System.Windows.Forms.Label();
            this.txtUnvan1 = new System.Windows.Forms.TextBox();
            this.lblUnvan1 = new System.Windows.Forms.Label();
            this.lblAdr = new System.Windows.Forms.Label();
            this.txtAdrIlce = new System.Windows.Forms.TextBox();
            this.lblAdrIlce = new System.Windows.Forms.Label();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.txtYetMail = new System.Windows.Forms.TextBox();
            this.txtYetAdi = new System.Windows.Forms.TextBox();
            this.lblYetAdi = new System.Windows.Forms.Label();
            this.txtYetTelNo = new System.Windows.Forms.TextBox();
            this.lblYetTelNo = new System.Windows.Forms.Label();
            this.txtYetSoyadi = new System.Windows.Forms.TextBox();
            this.lblYetSoyadi = new System.Windows.Forms.Label();
            this.lblYetMail = new System.Windows.Forms.Label();
            this.btnCariAdd = new System.Windows.Forms.Button();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.lblCariKodu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(172, 190);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(143, 23);
            this.txtTelNo.TabIndex = 4;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(172, 66);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Multiline = true;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(143, 23);
            this.txtTcNo.TabIndex = 1;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(44, 66);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(83, 17);
            this.lblTcNo.TabIndex = 16;
            this.lblTcNo.Text = "Vergi/Tc No";
            // 
            // txtAdrIl
            // 
            this.txtAdrIl.Location = new System.Drawing.Point(480, 66);
            this.txtAdrIl.MaxLength = 30;
            this.txtAdrIl.Multiline = true;
            this.txtAdrIl.Name = "txtAdrIl";
            this.txtAdrIl.Size = new System.Drawing.Size(143, 23);
            this.txtAdrIl.TabIndex = 11;
            // 
            // lblAdrIl
            // 
            this.lblAdrIl.AutoSize = true;
            this.lblAdrIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrIl.Location = new System.Drawing.Point(378, 66);
            this.lblAdrIl.Name = "lblAdrIl";
            this.lblAdrIl.Size = new System.Drawing.Size(55, 17);
            this.lblAdrIl.TabIndex = 26;
            this.lblAdrIl.Text = "Adres İl";
            // 
            // txtAdrAdi
            // 
            this.txtAdrAdi.Location = new System.Drawing.Point(480, 24);
            this.txtAdrAdi.MaxLength = 75;
            this.txtAdrAdi.Multiline = true;
            this.txtAdrAdi.Name = "txtAdrAdi";
            this.txtAdrAdi.Size = new System.Drawing.Size(143, 23);
            this.txtAdrAdi.TabIndex = 10;
            // 
            // lblAdrAdi
            // 
            this.lblAdrAdi.AutoSize = true;
            this.lblAdrAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrAdi.Location = new System.Drawing.Point(378, 24);
            this.lblAdrAdi.Name = "lblAdrAdi";
            this.lblAdrAdi.Size = new System.Drawing.Size(69, 17);
            this.lblAdrAdi.TabIndex = 25;
            this.lblAdrAdi.Text = "Adres Adı";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(172, 232);
            this.txtMail.MaxLength = 50;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(143, 23);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(44, 232);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(77, 17);
            this.lblMail.TabIndex = 20;
            this.lblMail.Text = "Mail Adresi";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(44, 190);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(50, 17);
            this.lblTelNo.TabIndex = 19;
            this.lblTelNo.Text = "Tel No";
            // 
            // txtUnvan2
            // 
            this.txtUnvan2.Location = new System.Drawing.Point(172, 150);
            this.txtUnvan2.MaxLength = 75;
            this.txtUnvan2.Multiline = true;
            this.txtUnvan2.Name = "txtUnvan2";
            this.txtUnvan2.ReadOnly = true;
            this.txtUnvan2.Size = new System.Drawing.Size(143, 23);
            this.txtUnvan2.TabIndex = 3;
            // 
            // lblUnvan2
            // 
            this.lblUnvan2.AutoSize = true;
            this.lblUnvan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan2.Location = new System.Drawing.Point(44, 150);
            this.lblUnvan2.Name = "lblUnvan2";
            this.lblUnvan2.Size = new System.Drawing.Size(110, 17);
            this.lblUnvan2.TabIndex = 18;
            this.lblUnvan2.Text = "Unvan2(Soyadı)";
            // 
            // txtUnvan1
            // 
            this.txtUnvan1.Location = new System.Drawing.Point(172, 108);
            this.txtUnvan1.MaxLength = 75;
            this.txtUnvan1.Multiline = true;
            this.txtUnvan1.Name = "txtUnvan1";
            this.txtUnvan1.Size = new System.Drawing.Size(143, 23);
            this.txtUnvan1.TabIndex = 2;
            // 
            // lblUnvan1
            // 
            this.lblUnvan1.AutoSize = true;
            this.lblUnvan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan1.Location = new System.Drawing.Point(44, 108);
            this.lblUnvan1.Name = "lblUnvan1";
            this.lblUnvan1.Size = new System.Drawing.Size(87, 17);
            this.lblUnvan1.TabIndex = 17;
            this.lblUnvan1.Text = "Unvan1(Adı)";
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdr.Location = new System.Drawing.Point(378, 150);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(45, 17);
            this.lblAdr.TabIndex = 28;
            this.lblAdr.Text = "Adres";
            // 
            // txtAdrIlce
            // 
            this.txtAdrIlce.Location = new System.Drawing.Point(480, 108);
            this.txtAdrIlce.MaxLength = 30;
            this.txtAdrIlce.Multiline = true;
            this.txtAdrIlce.Name = "txtAdrIlce";
            this.txtAdrIlce.Size = new System.Drawing.Size(143, 23);
            this.txtAdrIlce.TabIndex = 12;
            // 
            // lblAdrIlce
            // 
            this.lblAdrIlce.AutoSize = true;
            this.lblAdrIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrIlce.Location = new System.Drawing.Point(378, 108);
            this.lblAdrIlce.Name = "lblAdrIlce";
            this.lblAdrIlce.Size = new System.Drawing.Size(70, 17);
            this.lblAdrIlce.TabIndex = 27;
            this.lblAdrIlce.Text = "Adres İlçe";
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(480, 150);
            this.txtAdr.MaxLength = 250;
            this.txtAdr.Multiline = true;
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(291, 213);
            this.txtAdr.TabIndex = 13;
            // 
            // txtYetMail
            // 
            this.txtYetMail.Location = new System.Drawing.Point(172, 402);
            this.txtYetMail.MaxLength = 50;
            this.txtYetMail.Multiline = true;
            this.txtYetMail.Name = "txtYetMail";
            this.txtYetMail.Size = new System.Drawing.Size(143, 23);
            this.txtYetMail.TabIndex = 9;
            // 
            // txtYetAdi
            // 
            this.txtYetAdi.Location = new System.Drawing.Point(172, 276);
            this.txtYetAdi.MaxLength = 75;
            this.txtYetAdi.Multiline = true;
            this.txtYetAdi.Name = "txtYetAdi";
            this.txtYetAdi.Size = new System.Drawing.Size(143, 23);
            this.txtYetAdi.TabIndex = 6;
            // 
            // lblYetAdi
            // 
            this.lblYetAdi.AutoSize = true;
            this.lblYetAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetAdi.Location = new System.Drawing.Point(44, 276);
            this.lblYetAdi.Name = "lblYetAdi";
            this.lblYetAdi.Size = new System.Drawing.Size(69, 17);
            this.lblYetAdi.TabIndex = 21;
            this.lblYetAdi.Text = "Yetkili Adı";
            // 
            // txtYetTelNo
            // 
            this.txtYetTelNo.Location = new System.Drawing.Point(172, 360);
            this.txtYetTelNo.MaxLength = 10;
            this.txtYetTelNo.Multiline = true;
            this.txtYetTelNo.Name = "txtYetTelNo";
            this.txtYetTelNo.Size = new System.Drawing.Size(143, 23);
            this.txtYetTelNo.TabIndex = 8;
            this.txtYetTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblYetTelNo
            // 
            this.lblYetTelNo.AutoSize = true;
            this.lblYetTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetTelNo.Location = new System.Drawing.Point(44, 360);
            this.lblYetTelNo.Name = "lblYetTelNo";
            this.lblYetTelNo.Size = new System.Drawing.Size(91, 17);
            this.lblYetTelNo.TabIndex = 23;
            this.lblYetTelNo.Text = "Yetkili Tel No";
            // 
            // txtYetSoyadi
            // 
            this.txtYetSoyadi.Location = new System.Drawing.Point(172, 318);
            this.txtYetSoyadi.MaxLength = 75;
            this.txtYetSoyadi.Multiline = true;
            this.txtYetSoyadi.Name = "txtYetSoyadi";
            this.txtYetSoyadi.Size = new System.Drawing.Size(143, 23);
            this.txtYetSoyadi.TabIndex = 7;
            // 
            // lblYetSoyadi
            // 
            this.lblYetSoyadi.AutoSize = true;
            this.lblYetSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetSoyadi.Location = new System.Drawing.Point(44, 318);
            this.lblYetSoyadi.Name = "lblYetSoyadi";
            this.lblYetSoyadi.Size = new System.Drawing.Size(92, 17);
            this.lblYetSoyadi.TabIndex = 22;
            this.lblYetSoyadi.Text = "Yetkili Soyadı";
            // 
            // lblYetMail
            // 
            this.lblYetMail.AutoSize = true;
            this.lblYetMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetMail.Location = new System.Drawing.Point(44, 402);
            this.lblYetMail.Name = "lblYetMail";
            this.lblYetMail.Size = new System.Drawing.Size(118, 17);
            this.lblYetMail.TabIndex = 24;
            this.lblYetMail.Text = "Yetkili Mail Adresi";
            // 
            // btnCariAdd
            // 
            this.btnCariAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariAdd.Location = new System.Drawing.Point(480, 380);
            this.btnCariAdd.Name = "btnCariAdd";
            this.btnCariAdd.Size = new System.Drawing.Size(130, 45);
            this.btnCariAdd.TabIndex = 14;
            this.btnCariAdd.Text = "Cari Ekle";
            this.btnCariAdd.UseVisualStyleBackColor = true;
            this.btnCariAdd.Click += new System.EventHandler(this.btnCariAdd_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(172, 24);
            this.txtCariKodu.MaxLength = 30;
            this.txtCariKodu.Multiline = true;
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(143, 23);
            this.txtCariKodu.TabIndex = 0;
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.AutoSize = true;
            this.lblCariKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariKodu.Location = new System.Drawing.Point(44, 24);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(70, 17);
            this.lblCariKodu.TabIndex = 15;
            this.lblCariKodu.Text = "Cari Kodu";
            // 
            // frmCariKartEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.lblCariKodu);
            this.Controls.Add(this.btnCariAdd);
            this.Controls.Add(this.lblYetMail);
            this.Controls.Add(this.txtYetMail);
            this.Controls.Add(this.txtYetAdi);
            this.Controls.Add(this.lblYetAdi);
            this.Controls.Add(this.txtYetTelNo);
            this.Controls.Add(this.lblYetTelNo);
            this.Controls.Add(this.txtYetSoyadi);
            this.Controls.Add(this.lblYetSoyadi);
            this.Controls.Add(this.txtAdr);
            this.Controls.Add(this.lblAdr);
            this.Controls.Add(this.txtAdrIlce);
            this.Controls.Add(this.lblAdrIlce);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.txtAdrIl);
            this.Controls.Add(this.lblAdrIl);
            this.Controls.Add(this.txtAdrAdi);
            this.Controls.Add(this.lblAdrAdi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtUnvan2);
            this.Controls.Add(this.lblUnvan2);
            this.Controls.Add(this.txtUnvan1);
            this.Controls.Add(this.lblUnvan1);
            this.Name = "frmCariKartEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kart Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtAdrIl;
        private System.Windows.Forms.Label lblAdrIl;
        private System.Windows.Forms.TextBox txtAdrAdi;
        private System.Windows.Forms.Label lblAdrAdi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtUnvan2;
        private System.Windows.Forms.Label lblUnvan2;
        private System.Windows.Forms.TextBox txtUnvan1;
        private System.Windows.Forms.Label lblUnvan1;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.TextBox txtAdrIlce;
        private System.Windows.Forms.Label lblAdrIlce;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.TextBox txtYetMail;
        private System.Windows.Forms.TextBox txtYetAdi;
        private System.Windows.Forms.Label lblYetAdi;
        private System.Windows.Forms.TextBox txtYetTelNo;
        private System.Windows.Forms.Label lblYetTelNo;
        private System.Windows.Forms.TextBox txtYetSoyadi;
        private System.Windows.Forms.Label lblYetSoyadi;
        private System.Windows.Forms.Label lblYetMail;
        private System.Windows.Forms.Button btnCariAdd;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label lblCariKodu;
    }
}