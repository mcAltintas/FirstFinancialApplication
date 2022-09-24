
namespace BasariCariKart
{
    partial class frmCariKart
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
            this.btnAdrList = new System.Windows.Forms.Button();
            this.btnYetList = new System.Windows.Forms.Button();
            this.btnCariEkle = new System.Windows.Forms.Button();
            this.dataGridViewCari = new System.Windows.Forms.DataGridView();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtUnvan2 = new System.Windows.Forms.TextBox();
            this.lblUnvan2 = new System.Windows.Forms.Label();
            this.txtUnvan1 = new System.Windows.Forms.TextBox();
            this.lblUnvan1 = new System.Windows.Forms.Label();
            this.btnCariUpdate = new System.Windows.Forms.Button();
            this.btnCariDelete = new System.Windows.Forms.Button();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.lblCariKodu = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCari)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdrList
            // 
            this.btnAdrList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdrList.Location = new System.Drawing.Point(149, 12);
            this.btnAdrList.Name = "btnAdrList";
            this.btnAdrList.Size = new System.Drawing.Size(130, 45);
            this.btnAdrList.TabIndex = 1;
            this.btnAdrList.Text = "Adresler";
            this.btnAdrList.UseVisualStyleBackColor = true;
            this.btnAdrList.Click += new System.EventHandler(this.btnAdresler_Click);
            // 
            // btnYetList
            // 
            this.btnYetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetList.Location = new System.Drawing.Point(283, 12);
            this.btnYetList.Name = "btnYetList";
            this.btnYetList.Size = new System.Drawing.Size(130, 45);
            this.btnYetList.TabIndex = 2;
            this.btnYetList.Text = "Yetkililer";
            this.btnYetList.UseVisualStyleBackColor = true;
            this.btnYetList.Click += new System.EventHandler(this.btnYetList_Click);
            // 
            // btnCariEkle
            // 
            this.btnCariEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariEkle.Location = new System.Drawing.Point(15, 12);
            this.btnCariEkle.Name = "btnCariEkle";
            this.btnCariEkle.Size = new System.Drawing.Size(130, 45);
            this.btnCariEkle.TabIndex = 0;
            this.btnCariEkle.Text = "Cari Ekle";
            this.btnCariEkle.UseVisualStyleBackColor = true;
            this.btnCariEkle.Click += new System.EventHandler(this.btnCariEkle_Click);
            // 
            // dataGridViewCari
            // 
            this.dataGridViewCari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCari.Location = new System.Drawing.Point(283, 80);
            this.dataGridViewCari.MultiSelect = false;
            this.dataGridViewCari.Name = "dataGridViewCari";
            this.dataGridViewCari.ReadOnly = true;
            this.dataGridViewCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCari.Size = new System.Drawing.Size(509, 391);
            this.dataGridViewCari.TabIndex = 13;
            this.dataGridViewCari.SelectionChanged += new System.EventHandler(this.dataGridViewAdr_SelectionChanged);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(123, 240);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(143, 23);
            this.txtTelNo.TabIndex = 7;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(123, 116);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Multiline = true;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(103, 23);
            this.txtTcNo.TabIndex = 4;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(12, 122);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(83, 17);
            this.lblTcNo.TabIndex = 15;
            this.lblTcNo.Text = "Vergi/Tc No";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(123, 282);
            this.txtMail.MaxLength = 50;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(143, 23);
            this.txtMail.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(12, 288);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(77, 17);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "Mail Adresi";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(12, 246);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(50, 17);
            this.lblTelNo.TabIndex = 18;
            this.lblTelNo.Text = "Tel No";
            // 
            // txtUnvan2
            // 
            this.txtUnvan2.Location = new System.Drawing.Point(123, 200);
            this.txtUnvan2.MaxLength = 75;
            this.txtUnvan2.Multiline = true;
            this.txtUnvan2.Name = "txtUnvan2";
            this.txtUnvan2.Size = new System.Drawing.Size(143, 23);
            this.txtUnvan2.TabIndex = 6;
            // 
            // lblUnvan2
            // 
            this.lblUnvan2.AutoSize = true;
            this.lblUnvan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan2.Location = new System.Drawing.Point(12, 206);
            this.lblUnvan2.Name = "lblUnvan2";
            this.lblUnvan2.Size = new System.Drawing.Size(110, 17);
            this.lblUnvan2.TabIndex = 17;
            this.lblUnvan2.Text = "Unvan2(Soyadı)";
            // 
            // txtUnvan1
            // 
            this.txtUnvan1.Location = new System.Drawing.Point(123, 158);
            this.txtUnvan1.MaxLength = 75;
            this.txtUnvan1.Multiline = true;
            this.txtUnvan1.Name = "txtUnvan1";
            this.txtUnvan1.Size = new System.Drawing.Size(143, 23);
            this.txtUnvan1.TabIndex = 5;
            // 
            // lblUnvan1
            // 
            this.lblUnvan1.AutoSize = true;
            this.lblUnvan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan1.Location = new System.Drawing.Point(12, 164);
            this.lblUnvan1.Name = "lblUnvan1";
            this.lblUnvan1.Size = new System.Drawing.Size(87, 17);
            this.lblUnvan1.TabIndex = 16;
            this.lblUnvan1.Text = "Unvan1(Adı)";
            // 
            // btnCariUpdate
            // 
            this.btnCariUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariUpdate.Location = new System.Drawing.Point(149, 376);
            this.btnCariUpdate.Name = "btnCariUpdate";
            this.btnCariUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnCariUpdate.TabIndex = 9;
            this.btnCariUpdate.Text = "Güncelle";
            this.btnCariUpdate.UseVisualStyleBackColor = true;
            this.btnCariUpdate.Click += new System.EventHandler(this.btnCariUpdate_Click);
            // 
            // btnCariDelete
            // 
            this.btnCariDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariDelete.Location = new System.Drawing.Point(149, 427);
            this.btnCariDelete.Name = "btnCariDelete";
            this.btnCariDelete.Size = new System.Drawing.Size(117, 45);
            this.btnCariDelete.TabIndex = 10;
            this.btnCariDelete.Text = "Sil";
            this.btnCariDelete.UseVisualStyleBackColor = true;
            this.btnCariDelete.Click += new System.EventHandler(this.btnCariDelete_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(123, 74);
            this.txtCariKodu.MaxLength = 30;
            this.txtCariKodu.Multiline = true;
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(143, 23);
            this.txtCariKodu.TabIndex = 3;
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.AutoSize = true;
            this.lblCariKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariKodu.Location = new System.Drawing.Point(12, 80);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(70, 17);
            this.lblCariKodu.TabIndex = 14;
            this.lblCariKodu.Text = "Cari Kodu";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(149, 325);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 45);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(230, 116);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(36, 23);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmCariKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.lblCariKodu);
            this.Controls.Add(this.btnCariUpdate);
            this.Controls.Add(this.btnCariDelete);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtUnvan2);
            this.Controls.Add(this.lblUnvan2);
            this.Controls.Add(this.txtUnvan1);
            this.Controls.Add(this.lblUnvan1);
            this.Controls.Add(this.dataGridViewCari);
            this.Controls.Add(this.btnCariEkle);
            this.Controls.Add(this.btnAdrList);
            this.Controls.Add(this.btnYetList);
            this.Name = "frmCariKart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdrList;
        private System.Windows.Forms.Button btnYetList;
        private System.Windows.Forms.Button btnCariEkle;
        private System.Windows.Forms.DataGridView dataGridViewCari;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtUnvan2;
        private System.Windows.Forms.Label lblUnvan2;
        private System.Windows.Forms.TextBox txtUnvan1;
        private System.Windows.Forms.Label lblUnvan1;
        private System.Windows.Forms.Button btnCariUpdate;
        private System.Windows.Forms.Button btnCariDelete;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label lblCariKodu;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
    }
}

