
namespace BasariCariKart
{
    partial class frmAdrList
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
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.lblAdr = new System.Windows.Forms.Label();
            this.txtAdrIlce = new System.Windows.Forms.TextBox();
            this.lblAdrIlce = new System.Windows.Forms.Label();
            this.txtAdrIl = new System.Windows.Forms.TextBox();
            this.lblAdrIl = new System.Windows.Forms.Label();
            this.txtAdrAdi = new System.Windows.Forms.TextBox();
            this.lblAdrAdi = new System.Windows.Forms.Label();
            this.dataGridViewAdr = new System.Windows.Forms.DataGridView();
            this.btnAdrUpdate = new System.Windows.Forms.Button();
            this.btnAdrDelete = new System.Windows.Forms.Button();
            this.btnAdrAdd = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(87, 134);
            this.txtAdr.MaxLength = 250;
            this.txtAdr.Multiline = true;
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(257, 141);
            this.txtAdr.TabIndex = 3;
            // 
            // lblAdr
            // 
            this.lblAdr.AutoSize = true;
            this.lblAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdr.Location = new System.Drawing.Point(12, 135);
            this.lblAdr.Name = "lblAdr";
            this.lblAdr.Size = new System.Drawing.Size(45, 17);
            this.lblAdr.TabIndex = 13;
            this.lblAdr.Text = "Adres";
            // 
            // txtAdrIlce
            // 
            this.txtAdrIlce.Location = new System.Drawing.Point(87, 92);
            this.txtAdrIlce.MaxLength = 30;
            this.txtAdrIlce.Multiline = true;
            this.txtAdrIlce.Name = "txtAdrIlce";
            this.txtAdrIlce.Size = new System.Drawing.Size(143, 23);
            this.txtAdrIlce.TabIndex = 2;
            // 
            // lblAdrIlce
            // 
            this.lblAdrIlce.AutoSize = true;
            this.lblAdrIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrIlce.Location = new System.Drawing.Point(12, 93);
            this.lblAdrIlce.Name = "lblAdrIlce";
            this.lblAdrIlce.Size = new System.Drawing.Size(70, 17);
            this.lblAdrIlce.TabIndex = 12;
            this.lblAdrIlce.Text = "Adres İlçe";
            // 
            // txtAdrIl
            // 
            this.txtAdrIl.Location = new System.Drawing.Point(87, 50);
            this.txtAdrIl.MaxLength = 30;
            this.txtAdrIl.Multiline = true;
            this.txtAdrIl.Name = "txtAdrIl";
            this.txtAdrIl.Size = new System.Drawing.Size(143, 23);
            this.txtAdrIl.TabIndex = 1;
            // 
            // lblAdrIl
            // 
            this.lblAdrIl.AutoSize = true;
            this.lblAdrIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrIl.Location = new System.Drawing.Point(12, 51);
            this.lblAdrIl.Name = "lblAdrIl";
            this.lblAdrIl.Size = new System.Drawing.Size(55, 17);
            this.lblAdrIl.TabIndex = 11;
            this.lblAdrIl.Text = "Adres İl";
            // 
            // txtAdrAdi
            // 
            this.txtAdrAdi.Location = new System.Drawing.Point(87, 8);
            this.txtAdrAdi.MaxLength = 75;
            this.txtAdrAdi.Multiline = true;
            this.txtAdrAdi.Name = "txtAdrAdi";
            this.txtAdrAdi.Size = new System.Drawing.Size(143, 23);
            this.txtAdrAdi.TabIndex = 0;
            // 
            // lblAdrAdi
            // 
            this.lblAdrAdi.AutoSize = true;
            this.lblAdrAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdrAdi.Location = new System.Drawing.Point(12, 9);
            this.lblAdrAdi.Name = "lblAdrAdi";
            this.lblAdrAdi.Size = new System.Drawing.Size(69, 17);
            this.lblAdrAdi.TabIndex = 10;
            this.lblAdrAdi.Text = "Adres Adı";
            // 
            // dataGridViewAdr
            // 
            this.dataGridViewAdr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdr.Location = new System.Drawing.Point(360, 51);
            this.dataGridViewAdr.MultiSelect = false;
            this.dataGridViewAdr.Name = "dataGridViewAdr";
            this.dataGridViewAdr.ReadOnly = true;
            this.dataGridViewAdr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdr.Size = new System.Drawing.Size(432, 423);
            this.dataGridViewAdr.TabIndex = 9;
            this.dataGridViewAdr.SelectionChanged += new System.EventHandler(this.dataGridViewAdr_SelectionChanged);
            // 
            // btnAdrUpdate
            // 
            this.btnAdrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdrUpdate.Location = new System.Drawing.Point(227, 342);
            this.btnAdrUpdate.Name = "btnAdrUpdate";
            this.btnAdrUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnAdrUpdate.TabIndex = 5;
            this.btnAdrUpdate.Text = "Güncelle";
            this.btnAdrUpdate.UseVisualStyleBackColor = true;
            this.btnAdrUpdate.Click += new System.EventHandler(this.btnAdrUpdate_Click);
            // 
            // btnAdrDelete
            // 
            this.btnAdrDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdrDelete.Location = new System.Drawing.Point(227, 393);
            this.btnAdrDelete.Name = "btnAdrDelete";
            this.btnAdrDelete.Size = new System.Drawing.Size(117, 45);
            this.btnAdrDelete.TabIndex = 6;
            this.btnAdrDelete.Text = "Sil";
            this.btnAdrDelete.UseVisualStyleBackColor = true;
            this.btnAdrDelete.Click += new System.EventHandler(this.btnAdrDelete_Click);
            // 
            // btnAdrAdd
            // 
            this.btnAdrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdrAdd.Location = new System.Drawing.Point(227, 291);
            this.btnAdrAdd.Name = "btnAdrAdd";
            this.btnAdrAdd.Size = new System.Drawing.Size(117, 45);
            this.btnAdrAdd.TabIndex = 4;
            this.btnAdrAdd.Text = "Adres Ekle";
            this.btnAdrAdd.UseVisualStyleBackColor = true;
            this.btnAdrAdd.Click += new System.EventHandler(this.btnAdrAdd_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(104, 291);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 45);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmAdrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAdrAdd);
            this.Controls.Add(this.btnAdrUpdate);
            this.Controls.Add(this.btnAdrDelete);
            this.Controls.Add(this.dataGridViewAdr);
            this.Controls.Add(this.txtAdr);
            this.Controls.Add(this.lblAdr);
            this.Controls.Add(this.txtAdrIlce);
            this.Controls.Add(this.lblAdrIlce);
            this.Controls.Add(this.txtAdrIl);
            this.Controls.Add(this.lblAdrIl);
            this.Controls.Add(this.txtAdrAdi);
            this.Controls.Add(this.lblAdrAdi);
            this.Name = "frmAdrList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adres Listesi";
            this.Load += new System.EventHandler(this.frmAdrList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.Label lblAdr;
        private System.Windows.Forms.TextBox txtAdrIlce;
        private System.Windows.Forms.Label lblAdrIlce;
        private System.Windows.Forms.TextBox txtAdrIl;
        private System.Windows.Forms.Label lblAdrIl;
        private System.Windows.Forms.TextBox txtAdrAdi;
        private System.Windows.Forms.Label lblAdrAdi;
        private System.Windows.Forms.DataGridView dataGridViewAdr;
        private System.Windows.Forms.Button btnAdrUpdate;
        private System.Windows.Forms.Button btnAdrDelete;
        private System.Windows.Forms.Button btnAdrAdd;
        private System.Windows.Forms.Button btnTemizle;
    }
}