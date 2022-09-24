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
    public partial class frmCariKart : Form
    {
        private string conStr = "";

        private IniHelper iniHelper = new IniHelper(Application.StartupPath + "\\" + "settings.ini");

        public frmCariKart()
        {
            InitializeComponent();

            conStr = iniHelper.Read("Sql", "ConnectionStringMaster");

            DBControl();

            conStr = iniHelper.Read("Sql", "ConnectionString");

            CarileriListele();

        }


        private void CarileriListele()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                cnn.ChangeDatabase("BASARI_DB");
                SqlCommand cm = cnn.CreateCommand();
                cm.CommandText = "select * from CARI_HESAPLAR";
                DataTable dt = new DataTable();
                dt.Load(cm.ExecuteReader());
                dataGridViewCari.DataSource = dt;
            }
        }

        private void DBControl()
        {

            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();

                cm.CommandText = "select database_id from sys.databases where Name = 'BASARI_DB'";

                object existDB = cm.ExecuteScalar();

                if (existDB != null)
                {
                    return;
                }

                cm.CommandText = "create database BASARI_DB; select database_id from sys.databases where Name = 'BASARI_DB'";

                existDB = cm.ExecuteScalar();

                if (existDB == null)
                {
                    MessageBox.Show("Veritabanı oluşturulamadı!");
                    return;
                }

                cnn.ChangeDatabase("BASARI_DB");

                SqlTransaction trn = cnn.BeginTransaction();
                cm.Transaction = trn;

                cm.CommandText = "create table CARI_HESAPLAR(ID int IDENTITY(1,1), CAR_KODU nvarchar(30), CAR_VERGI_TC_NO nvarchar(11), CAR_UNVAN1 nvarchar(75), CAR_UNVAN2 nvarchar(75), CAR_TEL_NO nvarchar(10), CAR_MAIL nvarchar(50)); SELECT TABLE_NAME FROM BASARI_DB.INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'CARI_HESAPLAR'";

                object existTbl = cm.ExecuteScalar();

                if (existTbl == null)
                {
                    trn.Rollback();
                    MessageBox.Show("Cari hesaplar tablosu oluşturulamadı!");
                    cm.CommandText = "drop database BASARI_DB";
                    cm.ExecuteNonQuery();
                    return;
                }

                cm.CommandText = "create table CARI_HESAP_ADRESLERI(ADR_ID int IDENTITY(1,1), ADR_CARI_KODU nvarchar(30), ADR_ADI nvarchar(75), ADR_IL nvarchar(30), ADR_ILCE nvarchar(30), ADR_SATIR nvarchar(250)); SELECT TABLE_NAME FROM BASARI_DB.INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'CARI_HESAP_ADRESLERI'";

                existTbl = cm.ExecuteScalar();

                if (existTbl == null)
                {
                    trn.Rollback();
                    MessageBox.Show("Cari adresler tablosu oluşturulamadı!");
                    cm.CommandText = "drop database BASARI_DB";
                    cm.ExecuteNonQuery();
                    return;
                }

                cm.CommandText = "create table CARI_HESAP_YETKILILERI(YET_ID int IDENTITY(1,1), YET_CARI_KODU nvarchar(30), YET_ADI nvarchar(75), YET_SOYADI nvarchar(75), YET_TEL_NO nvarchar(10), YET_MAIL nvarchar(50), YET_ADR_ID int); SELECT TABLE_NAME FROM BASARI_DB.INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'CARI_HESAP_YETKILILERI'";

                existTbl = cm.ExecuteScalar();

                if (existTbl == null)
                {
                    trn.Rollback();
                    MessageBox.Show("Cari yetkililer tablosu oluşturulamadı!");
                    cm.CommandText = "drop database BASARI_DB";
                    cm.ExecuteNonQuery();
                    return;
                }

                trn.Commit();
            }
        }

        private void btnAdresler_Click(object sender, EventArgs e)
        {
            frmAdrList frm = new frmAdrList();
            var cariKodu = txtCariKodu.Text;
            frm.CariKodu = cariKodu;
            frm.Show();
        }

        private void btnYetList_Click(object sender, EventArgs e)
        {
            frmYetList frm = new frmYetList();
            var cariKodu = txtCariKodu.Text;
            frm.CariKodu = cariKodu;
            frm.Show();
        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {
            frmCariKartEkle frm = new frmCariKartEkle();
            //var cariKodu = dataGridViewCari.CurrentRow.Cells["CAR_KODU"].Value.ToString();
            //frm.CariKodu = cariKodu;
            if (frm.ShowDialog() == DialogResult.OK)
                CarileriListele();
        }

        private void Guncelle()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                var cID = Convert.ToInt32(dataGridViewCari.CurrentRow.Cells["ID"].Value);
                cm.CommandText = "update CARI_HESAPLAR set CAR_KODU = @carKodu, CAR_VERGI_TC_NO = @tcNo, CAR_UNVAN1 = @unvan1, CAR_UNVAN2 = @unvan2, CAR_TEL_NO = @telNo, CAR_MAIL = @mail where ID = @ID";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@carKodu", txtCariKodu.Text);
                cm.Parameters.AddWithValue("@tcNo", txtTcNo.Text);
                cm.Parameters.AddWithValue("@unvan1", txtUnvan1.Text);
                cm.Parameters.AddWithValue("@unvan2", txtUnvan2.Text);
                cm.Parameters.AddWithValue("@telNo", txtTelNo.Text);
                cm.Parameters.AddWithValue("@mail", txtMail.Text);
                cm.Parameters.AddWithValue("@ID", cID);

                int affectedRow = cm.ExecuteNonQuery();

                if (affectedRow > 0)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı!");
                    CarileriListele();
                }
                else
                    MessageBox.Show("Güncelleme işlemi başarısız!");
            }
        }

        private void Sil()
        {
            DialogResult dlg = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    cnn.Open();
                    SqlTransaction trn = cnn.BeginTransaction();
                    SqlCommand cm = cnn.CreateCommand();
                    cm.Transaction = trn;

                    var cariKodu = dataGridViewCari.CurrentRow.Cells["CAR_KODU"].Value.ToString();
                    cm.CommandText = "delete from CARI_HESAPLAR where CAR_KODU = @cariKodu";
                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@cariKodu", cariKodu);

                    int cariAffected = Convert.ToInt32(cm.ExecuteNonQuery());
                    if (cariAffected <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Cari Silinemedi!");
                        return;
                    }

                    cm.CommandText = "delete from CARI_HESAP_YETKILILERI where YET_CARI_KODU = @cariKodu";

                    int yetkiliAffected = cm.ExecuteNonQuery();
                    if (yetkiliAffected <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Yetkili Silinemedi!");
                        return;
                    }

                    cm.CommandText = "delete from CARI_HESAP_ADRESLERI where ADR_CARI_KODU = @cariKodu";

                    int adresAffected = cm.ExecuteNonQuery();
                    if (adresAffected <= 0)
                    {
                        trn.Rollback();
                        MessageBox.Show("Adres Silinemedi!");
                        return;
                    }

                    trn.Commit();
                    MessageBox.Show("Silme işlemi başarılı!");
                    CarileriListele();
                }

            }
        }

        private void btnCariUpdate_Click(object sender, EventArgs e)
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

            Guncelle();
        }

        private void btnCariDelete_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void dataGridViewAdr_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCari.CurrentRow != null)
            {
                txtCariKodu.Text = dataGridViewCari.CurrentRow.Cells["CAR_KODU"].Value.ToString();
                txtTcNo.Text = dataGridViewCari.CurrentRow.Cells["CAR_VERGI_TC_NO"].Value.ToString();
                txtUnvan1.Text = dataGridViewCari.CurrentRow.Cells["CAR_UNVAN1"].Value.ToString();
                txtUnvan2.Text = dataGridViewCari.CurrentRow.Cells["CAR_UNVAN2"].Value.ToString();
                txtTelNo.Text = dataGridViewCari.CurrentRow.Cells["CAR_TEL_NO"].Value.ToString();
                txtMail.Text = dataGridViewCari.CurrentRow.Cells["CAR_MAIL"].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCariKodu.Clear();
            txtTcNo.Clear();
            txtUnvan1.Clear();
            txtUnvan2.Clear();
            txtTelNo.Clear();
            txtMail.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();

                cm.CommandText = "select * from CARI_HESAPLAR where CAR_VERGI_TC_NO = @tcNo";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@tcNo", txtTcNo.Text);

                DataTable dt = new DataTable();
                dt.Load(cm.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    txtCariKodu.Text = dt.Rows[0]["CAR_KODU"].ToString();
                    txtUnvan1.Text = dt.Rows[0]["CAR_UNVAN1"].ToString();
                    txtUnvan2.Text = dt.Rows[0]["CAR_UNVAN2"].ToString();
                    txtMail.Text = dt.Rows[0]["CAR_MAIL"].ToString();
                    txtTelNo.Text = dt.Rows[0]["CAR_TEL_NO"].ToString();
                }
                else
                {
                    MessageBox.Show("Kayıt yok");
                }
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
