using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasariCariKart
{
    public partial class frmLogScr : Form
    {
        IniHelper iniHelper = new IniHelper(Application.StartupPath + "\\" + "settings.ini");

        public frmLogScr()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUId.Text == "Admin" && txtPass.Text == "2509")
            {
                frmCariKart frm = new frmCariKart();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "UYARI!");
            }
        }


        private void GetLoadServer()
        {
            string serverName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    cmbServer.Items.Add(serverName);
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cmbServer.Items.Add(serverName + "\\" + instanceName);
                    }
                }
            }
        }

        private void frmLogScr_Load(object sender, EventArgs e)
        {
            GetLoadServer();

            cmbServer.Text = iniHelper.Read("Sql", "SunucuAdi");
            int authSelect = 0;
            int.TryParse(iniHelper.Read("Sql", "DogrulamaYontemi"), out authSelect);
            cmbAuth.SelectedIndex = authSelect;
            if (cmbAuth.SelectedIndex == 1)
            {
                txtSUId.Text = iniHelper.Read("Sql", "KullaniciAdi");
                txtSPass.Text = iniHelper.Read("Sql", "Sifre");
            }

        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuth.SelectedIndex == 0)
            {
                txtSUId.ReadOnly = true;
                txtSPass.ReadOnly = true;
                txtSUId.Clear();
                txtSPass.Clear();
            }
            else
            {
                txtSUId.ReadOnly = false;
                txtSPass.ReadOnly = false;
                txtSUId.Text = iniHelper.Read("Sql", "KullaniciAdi");
                txtSPass.Text = iniHelper.Read("Sql", "Sifre");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.ServerName = cmbServer.Text;

            if (cmbAuth.SelectedIndex == 0)
            {
                settings.Authentication = AuthenticationType.Windows;
            }

            else
            {
                settings.Authentication = AuthenticationType.Sql;
                settings.UserName = txtSUId.Text;
                settings.Password = txtSPass.Text;
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(settings.ConnectionStringMaster))
                {
                    cnn.Open();
                    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.ServerName = cmbServer.Text;
            settings.DbName = "BASARI_DB";

            iniHelper.Write("Sql", "SunucuAdi", settings.ServerName);
            iniHelper.Write("Sql", "VeriTabaniAdi", settings.DbName);

            if (cmbAuth.SelectedIndex == 0)
            {
                settings.Authentication = AuthenticationType.Windows;
            }

            else
            {
                settings.Authentication = AuthenticationType.Sql;
                settings.UserName = txtSUId.Text;
                settings.Password = txtSPass.Text;
                iniHelper.Write("Sql", "KullaniciAdi", settings.UserName);
                iniHelper.Write("Sql", "Sifre", settings.Password);
            }
            iniHelper.Write("Sql", "DogrulamaYontemi", ((byte)settings.Authentication).ToString());
            iniHelper.Write("Sql", "ConnectionStringMaster", settings.ConnectionStringMaster);
            iniHelper.Write("Sql", "ConnectionString", settings.ConnectionString);
        }
    }
}
