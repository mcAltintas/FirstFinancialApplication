using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasariCariKart
{
    public partial class frmCariKartEkle : Form

    {

        private string conStr = "";

        private IniHelper iniHelper = new IniHelper(Application.StartupPath + "\\" + "settings.ini");

        public frmCariKartEkle()
        {
            InitializeComponent();

            conStr = iniHelper.Read("Sql", "ConnectionString");

        }

        private void Ekle()
        {
            DialogResult dlg = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    cnn.Open();
                    SqlCommand cm = cnn.CreateCommand();
                    SqlTransaction trn = cnn.BeginTransaction();
                    cm.Transaction = trn;

                    cm.CommandText = "insert into CARI_HESAPLAR (CAR_KODU, CAR_VERGI_TC_NO, CAR_UNVAN1, CAR_UNVAN2, CAR_TEL_NO, CAR_MAIL) values (@cariKodu, @tcNo, @unvan1, @unvan2, @telNo, @mail)";

                    cm.Parameters.Clear();

                    cm.Parameters.AddWithValue("@cariKodu", txtCariKodu.Text); // 3 tablo icin
                    cm.Parameters.AddWithValue("@tcNo", txtTcNo.Text);
                    cm.Parameters.AddWithValue("@unvan1", txtUnvan1.Text);
                    cm.Parameters.AddWithValue("@unvan2", txtUnvan2.Text);
                    cm.Parameters.AddWithValue("@telNo", txtTelNo.Text);
                    cm.Parameters.AddWithValue("@mail", txtMail.Text);

                    int cariAffect = Convert.ToInt32(cm.ExecuteNonQuery());
                    if (cariAffect <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Cari kaydedilemedi!");
                        return;
                    }

                    cm.CommandText = "insert into CARI_HESAP_ADRESLERI (ADR_CARI_KODU, ADR_ADI, ADR_IL, ADR_ILCE, ADR_SATIR) values (@cariKodu, @adrAdi, @il, @ilce, @adrSatir); select SCOPE_IDENTITY()";

                    cm.Parameters.AddWithValue("@adrAdi", txtAdrAdi.Text);
                    cm.Parameters.AddWithValue("@il", txtAdrIl.Text);
                    cm.Parameters.AddWithValue("@ilce", txtAdrIlce.Text);
                    cm.Parameters.AddWithValue("@adrSatir", txtAdr.Text);

                    int adrId = Convert.ToInt32(cm.ExecuteScalar());
                    if (adrId <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Adres kaydedilemedi! Yapılan işlemler geri alındı!");
                        return;
                    }

                    cm.CommandText = "insert into CARI_HESAP_YETKILILERI (YET_CARI_KODU, YET_ADI, YET_SOYADI, YET_TEL_NO, YET_MAIL, YET_ADR_ID) values (@cariKodu, @yetAdi, @yetSoyAdi, @yetTel, @yetMail, @yetAdr);";

                    cm.Parameters.AddWithValue("@yetAdi", txtYetAdi.Text);
                    cm.Parameters.AddWithValue("@yetSoyAdi", txtYetSoyadi.Text);
                    cm.Parameters.AddWithValue("@yetTel", txtYetTelNo.Text);
                    cm.Parameters.AddWithValue("@yetMail", txtYetMail.Text);
                    cm.Parameters.AddWithValue("@yetAdr", adrId);


                    int yetkiliAffect = cm.ExecuteNonQuery();
                    if (yetkiliAffect <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Yetkililer kaydedilemedi! Yapılan işlemler geri alındı!!");
                        return;
                    }

                    trn.Commit();

                    MessageBox.Show("Ekleme işlemi başarılı!");

                }
            }
        }

        private void btnCariAdd_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text.Length < 10)
            {
                MessageBox.Show("Tc / Vergi numarası alanı 10 karakterden kısa olamaz!");
                return;
            }

            if (txtTelNo.Text.Length < 10)
            {
                MessageBox.Show("Telefon numarası alanı 10 karakterden oluşmak zorundadır!");
                return;
            }
            if (txtTelNo.Text.Length < 10)
            {
                MessageBox.Show("Yetkili telefon numarası alanı 10 karakterden oluşmak zorundadır!");
                return;
            }

            Ekle();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {

            if (txtTcNo.Text.Length == 11)
            {
                txtUnvan2.ReadOnly = false;
            }
            else
            {
                txtUnvan2.ReadOnly = true;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }
    }
}
