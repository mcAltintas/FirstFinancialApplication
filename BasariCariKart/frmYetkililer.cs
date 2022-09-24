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
    public partial class frmYetList : Form
    {
        public string CariKodu { get; set; }

        private string conStr = "";

        private IniHelper iniHelper = new IniHelper(Application.StartupPath + "\\" + "settings.ini");

        public frmYetList()
        {
            InitializeComponent();

            conStr = iniHelper.Read("Sql", "ConnectionString");

        }

        private void Listele()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                cm.CommandText = "select * from CARI_HESAP_YETKILILERI where YET_CARI_KODU =@kodu";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@kodu", CariKodu);

                DataTable dt = new DataTable();
                dt.Load(cm.ExecuteReader());
                dataGridViewYet.DataSource = dt;
            }
        }

        private List<ComboboxItem> GetAdresList()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                cm.CommandText = "select ADR_ID,ADR_ADI from CARI_HESAP_ADRESLERI where ADR_CARI_KODU = @kodu";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@kodu", CariKodu);

                DataTable dt = new DataTable();
                dt.Load(cm.ExecuteReader());
                List<ComboboxItem> cmbItems = new List<ComboboxItem>();
                foreach (DataRow dr in dt.Rows)
                {
                    cmbItems.Add(new ComboboxItem
                    {

                        Text = dr["ADR_ADI"].ToString(),
                        Value = Convert.ToInt32(dr["ADR_ID"])
                    });
                }
                return cmbItems;
            }
        }

        private void frmYetList_Load(object sender, EventArgs e)
        {
            cmbYetAdres.Items.AddRange(GetAdresList().ToArray());
            Listele();
        }

        private void Ekle()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                cm.CommandText = "insert into CARI_HESAP_YETKILILERI (YET_CARI_KODU, YET_ADI, YET_SOYADI, YET_TEL_NO, YET_MAIL, YET_ADR_ID) values (@cariKodu, @adi, @soyAdi, @tel, @mail, @adres)";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@cariKodu", CariKodu);
                cm.Parameters.AddWithValue("@adi", txtYetAdi.Text);
                cm.Parameters.AddWithValue("@soyAdi", txtYetSoyadi.Text);
                cm.Parameters.AddWithValue("@tel", txtYetTelNo.Text);
                cm.Parameters.AddWithValue("@mail", txtYetMail.Text);

                int adresId = ((ComboboxItem)cmbYetAdres.SelectedItem).Value;
                cm.Parameters.AddWithValue("@adres", adresId);

                int affectedRow = cm.ExecuteNonQuery();
                if (affectedRow > 0)
                {
                    MessageBox.Show("Ekleme işlemi başarılı!");
                    Listele();
                }
                else
                    MessageBox.Show("Ekleme işlemi başarısız!");
            }
        }

        private void Sil()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                var yID = Convert.ToInt32(dataGridViewYet.CurrentRow.Cells["YET_ID"].Value);
                cm.CommandText = "delete from CARI_HESAP_YETKILILERI where YET_ID = @ID";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID", yID);

                int affectedRow = cm.ExecuteNonQuery();

                if (affectedRow > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı!");
                    Listele();
                }
                else
                    MessageBox.Show("Silme işlemi başarısız!");
            }
        }

        private void Guncelle()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                var yID = Convert.ToInt32(dataGridViewYet.CurrentRow.Cells["YET_ID"].Value);
                cm.CommandText = "update CARI_HESAP_YETKILILERI set YET_ADI = @adi, YET_SOYADI = @soyAdi, YET_TEL_NO = @tel, YET_MAIL = @mail, YET_ADR_ID = @adres where YET_ID = @ID";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@adi", txtYetAdi.Text);
                cm.Parameters.AddWithValue("@soyAdi", txtYetSoyadi.Text);
                cm.Parameters.AddWithValue("@tel", txtYetTelNo.Text);
                cm.Parameters.AddWithValue("@mail", txtYetMail.Text);
                cm.Parameters.AddWithValue("@ID", yID);

                int adresId = ((ComboboxItem)cmbYetAdres.SelectedItem).Value;
                cm.Parameters.AddWithValue("@adres", adresId);

                int affectedRow = cm.ExecuteNonQuery();

                if (affectedRow > 0)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı!");
                    Listele();
                }
                else
                    MessageBox.Show("Güncelleme işlemi başarısız!");
            }
        }
        private void btnYetUpdate_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnYetAdd_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnYetDelete_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void dataGridViewYet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewYet.CurrentRow != null)
            {
                txtYetAdi.Text = dataGridViewYet.CurrentRow.Cells["YET_ADI"].Value.ToString();
                txtYetSoyadi.Text = dataGridViewYet.CurrentRow.Cells["YET_SOYADI"].Value.ToString();
                txtYetTelNo.Text = dataGridViewYet.CurrentRow.Cells["YET_TEL_NO"].Value.ToString();
                txtYetMail.Text = dataGridViewYet.CurrentRow.Cells["YET_MAIL"].Value.ToString();

                int adrId = Convert.ToInt32(dataGridViewYet.CurrentRow.Cells["YET_ADR_ID"].Value);

                foreach (ComboboxItem item in cmbYetAdres.Items)
                {
                    if (item.Value == adrId)
                    {
                        cmbYetAdres.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtYetAdi.Clear();
            txtYetMail.Clear();
            txtYetSoyadi.Clear();
            txtYetTelNo.Clear();
            cmbYetAdres.ResetText();
        }
    }
}
