
namespace BasariCariKart
{
    partial class frmYetList
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
            this.btnYetAdd = new System.Windows.Forms.Button();
            this.btnYetUpdate = new System.Windows.Forms.Button();
            this.btnYetDelete = new System.Windows.Forms.Button();
            this.dataGridViewYet = new System.Windows.Forms.DataGridView();
            this.lblYetMail = new System.Windows.Forms.Label();
            this.txtYetMail = new System.Windows.Forms.TextBox();
            this.txtYetAdi = new System.Windows.Forms.TextBox();
            this.lblYetAdi = new System.Windows.Forms.Label();
            this.txtYetTelNo = new System.Windows.Forms.TextBox();
            this.lblYetTelNo = new System.Windows.Forms.Label();
            this.txtYetSoyadi = new System.Windows.Forms.TextBox();
            this.lblYetSoyadi = new System.Windows.Forms.Label();
            this.cmbYetAdres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYetAdd
            // 
            this.btnYetAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetAdd.Location = new System.Drawing.Point(175, 291);
            this.btnYetAdd.Name = "btnYetAdd";
            this.btnYetAdd.Size = new System.Drawing.Size(117, 45);
            this.btnYetAdd.TabIndex = 5;
            this.btnYetAdd.Text = "Yetkili Ekle";
            this.btnYetAdd.UseVisualStyleBackColor = true;
            this.btnYetAdd.Click += new System.EventHandler(this.btnYetAdd_Click);
            // 
            // btnYetUpdate
            // 
            this.btnYetUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetUpdate.Location = new System.Drawing.Point(175, 342);
            this.btnYetUpdate.Name = "btnYetUpdate";
            this.btnYetUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnYetUpdate.TabIndex = 6;
            this.btnYetUpdate.Text = "Güncelle";
            this.btnYetUpdate.UseVisualStyleBackColor = true;
            this.btnYetUpdate.Click += new System.EventHandler(this.btnYetUpdate_Click);
            // 
            // btnYetDelete
            // 
            this.btnYetDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetDelete.Location = new System.Drawing.Point(175, 393);
            this.btnYetDelete.Name = "btnYetDelete";
            this.btnYetDelete.Size = new System.Drawing.Size(117, 45);
            this.btnYetDelete.TabIndex = 7;
            this.btnYetDelete.Text = "Sil";
            this.btnYetDelete.UseVisualStyleBackColor = true;
            this.btnYetDelete.Click += new System.EventHandler(this.btnYetDelete_Click);
            // 
            // dataGridViewYet
            // 
            this.dataGridViewYet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewYet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYet.Location = new System.Drawing.Point(307, 76);
            this.dataGridViewYet.MultiSelect = false;
            this.dataGridViewYet.Name = "dataGridViewYet";
            this.dataGridViewYet.ReadOnly = true;
            this.dataGridViewYet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYet.Size = new System.Drawing.Size(485, 393);
            this.dataGridViewYet.TabIndex = 10;
            this.dataGridViewYet.SelectionChanged += new System.EventHandler(this.dataGridViewYet_SelectionChanged);
            // 
            // lblYetMail
            // 
            this.lblYetMail.AutoSize = true;
            this.lblYetMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetMail.Location = new System.Drawing.Point(21, 160);
            this.lblYetMail.Name = "lblYetMail";
            this.lblYetMail.Size = new System.Drawing.Size(118, 17);
            this.lblYetMail.TabIndex = 14;
            this.lblYetMail.Text = "Yetkili Mail Adresi";
            // 
            // txtYetMail
            // 
            this.txtYetMail.Location = new System.Drawing.Point(149, 160);
            this.txtYetMail.MaxLength = 50;
            this.txtYetMail.Multiline = true;
            this.txtYetMail.Name = "txtYetMail";
            this.txtYetMail.Size = new System.Drawing.Size(143, 23);
            this.txtYetMail.TabIndex = 3;
            // 
            // txtYetAdi
            // 
            this.txtYetAdi.Location = new System.Drawing.Point(149, 34);
            this.txtYetAdi.MaxLength = 75;
            this.txtYetAdi.Multiline = true;
            this.txtYetAdi.Name = "txtYetAdi";
            this.txtYetAdi.Size = new System.Drawing.Size(143, 23);
            this.txtYetAdi.TabIndex = 0;
            // 
            // lblYetAdi
            // 
            this.lblYetAdi.AutoSize = true;
            this.lblYetAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetAdi.Location = new System.Drawing.Point(21, 34);
            this.lblYetAdi.Name = "lblYetAdi";
            this.lblYetAdi.Size = new System.Drawing.Size(69, 17);
            this.lblYetAdi.TabIndex = 11;
            this.lblYetAdi.Text = "Yetkili Adı";
            // 
            // txtYetTelNo
            // 
            this.txtYetTelNo.Location = new System.Drawing.Point(149, 118);
            this.txtYetTelNo.MaxLength = 10;
            this.txtYetTelNo.Multiline = true;
            this.txtYetTelNo.Name = "txtYetTelNo";
            this.txtYetTelNo.Size = new System.Drawing.Size(143, 23);
            this.txtYetTelNo.TabIndex = 2;
            this.txtYetTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblYetTelNo
            // 
            this.lblYetTelNo.AutoSize = true;
            this.lblYetTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetTelNo.Location = new System.Drawing.Point(21, 118);
            this.lblYetTelNo.Name = "lblYetTelNo";
            this.lblYetTelNo.Size = new System.Drawing.Size(91, 17);
            this.lblYetTelNo.TabIndex = 13;
            this.lblYetTelNo.Text = "Yetkili Tel No";
            // 
            // txtYetSoyadi
            // 
            this.txtYetSoyadi.Location = new System.Drawing.Point(149, 76);
            this.txtYetSoyadi.MaxLength = 75;
            this.txtYetSoyadi.Multiline = true;
            this.txtYetSoyadi.Name = "txtYetSoyadi";
            this.txtYetSoyadi.Size = new System.Drawing.Size(143, 23);
            this.txtYetSoyadi.TabIndex = 1;
            // 
            // lblYetSoyadi
            // 
            this.lblYetSoyadi.AutoSize = true;
            this.lblYetSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetSoyadi.Location = new System.Drawing.Point(21, 76);
            this.lblYetSoyadi.Name = "lblYetSoyadi";
            this.lblYetSoyadi.Size = new System.Drawing.Size(92, 17);
            this.lblYetSoyadi.TabIndex = 12;
            this.lblYetSoyadi.Text = "Yetkili Soyadı";
            // 
            // cmbYetAdres
            // 
            this.cmbYetAdres.FormattingEnabled = true;
            this.cmbYetAdres.Location = new System.Drawing.Point(149, 200);
            this.cmbYetAdres.Name = "cmbYetAdres";
            this.cmbYetAdres.Size = new System.Drawing.Size(143, 21);
            this.cmbYetAdres.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yetkili Adresi";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(52, 291);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 45);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmYetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYetAdres);
            this.Controls.Add(this.lblYetMail);
            this.Controls.Add(this.txtYetMail);
            this.Controls.Add(this.txtYetAdi);
            this.Controls.Add(this.lblYetAdi);
            this.Controls.Add(this.txtYetTelNo);
            this.Controls.Add(this.lblYetTelNo);
            this.Controls.Add(this.txtYetSoyadi);
            this.Controls.Add(this.lblYetSoyadi);
            this.Controls.Add(this.btnYetAdd);
            this.Controls.Add(this.btnYetUpdate);
            this.Controls.Add(this.btnYetDelete);
            this.Controls.Add(this.dataGridViewYet);
            this.Name = "frmYetList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Listesi";
            this.Load += new System.EventHandler(this.frmYetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYetAdd;
        private System.Windows.Forms.Button btnYetUpdate;
        private System.Windows.Forms.Button btnYetDelete;
        private System.Windows.Forms.DataGridView dataGridViewYet;
        private System.Windows.Forms.Label lblYetMail;
        private System.Windows.Forms.TextBox txtYetMail;
        private System.Windows.Forms.TextBox txtYetAdi;
        private System.Windows.Forms.Label lblYetAdi;
        private System.Windows.Forms.TextBox txtYetTelNo;
        private System.Windows.Forms.Label lblYetTelNo;
        private System.Windows.Forms.TextBox txtYetSoyadi;
        private System.Windows.Forms.Label lblYetSoyadi;
        private System.Windows.Forms.ComboBox cmbYetAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
    }
}