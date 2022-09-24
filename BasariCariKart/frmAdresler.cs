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
    public partial class frmAdrList : Form
    {
        public string CariKodu { get; set; }

        private string conStr = "";

        private IniHelper iniHelper = new IniHelper(Application.StartupPath + "\\" + "settings.ini");

        public frmAdrList()
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
                cm.CommandText = "select * from CARI_HESAP_ADRESLERI where ADR_CARI_KODU =@kodu";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@kodu", CariKodu);

                DataTable dt = new DataTable();
                dt.Load(cm.ExecuteReader());
                dataGridViewAdr.DataSource = dt;
            }
        }

        private void Ekle()
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                cnn.Open();
                SqlCommand cm = cnn.CreateCommand();
                cm.CommandText = "insert into CARI_HESAP_ADRESLERI (ADR_CARI_KODU, ADR_ADI, ADR_IL, ADR_ILCE, ADR_SATIR) values (@cariKodu, @adi, @il, @ilce, @satir)";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@cariKodu", CariKodu);
                cm.Parameters.AddWithValue("@adi", txtAdrAdi.Text);
                cm.Parameters.AddWithValue("@il", txtAdrIl.Text);
                cm.Parameters.AddWithValue("@ilce", txtAdrIlce.Text);
                cm.Parameters.AddWithValue("@satir", txtAdr.Text);

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
                var aID = Convert.ToInt32(dataGridViewAdr.CurrentRow.Cells["ADR_ID"].Value);
                cm.CommandText = "delete from CARI_HESAP_ADRESLERI where ADR_ID = @ID";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@ID", aID);

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
                var aID = Convert.ToInt32(dataGridViewAdr.CurrentRow.Cells["ADR_ID"].Value);
                cm.CommandText = "update CARI_HESAP_ADRESLERI set ADR_ADI = @adi, ADR_IL = @il, ADR_ILCE = @ilce, ADR_SATIR = @satir where ADR_ID = @ID";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@adi", txtAdrAdi.Text);
                cm.Parameters.AddWithValue("@il", txtAdrIl.Text);
                cm.Parameters.AddWithValue("@ilce", txtAdrIlce.Text);
                cm.Parameters.AddWithValue("@satir", txtAdr.Text);
                cm.Parameters.AddWithValue("@ID", aID);

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

        private void btnAdrAdd_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void frmAdrList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAdrUpdate_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAdrDelete_Click(object sender, EventArgs e)
        {
            Sil();
        }
        private void dataGridViewAdr_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewAdr.CurrentRow != null)
            {
                txtAdrAdi.Text = dataGridViewAdr.CurrentRow.Cells["ADR_ADI"].Value.ToString();
                txtAdrIl.Text = dataGridViewAdr.CurrentRow.Cells["ADR_IL"].Value.ToString();
                txtAdrIlce.Text = dataGridViewAdr.CurrentRow.Cells["ADR_ILCE"].Value.ToString();
                txtAdr.Text = dataGridViewAdr.CurrentRow.Cells["ADR_SATIR"].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdr.Clear();
            txtAdrAdi.Clear();
            txtAdrIl.Clear();
            txtAdrIlce.Clear();
        }
    }
}
