using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OyunKutuphanesi
{
    public partial class FormTumOyunlar : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OyunKutuphanesi.accdb");
        OleDbCommand komut;
        List<Oyun> veriler = new List<Oyun>();

        public FormTumOyunlar()
        {
            InitializeComponent();

        }

        private void FormTumOyunlar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormTumOyunlar_Load(object sender, EventArgs e)
        {
            oyunListesiniGetir();
            if (list_oyunlar.Items.Count != 0)
                list_oyunlar.SelectedIndex = 0;
        }

        void oyunListesiniGetir()
        {
            try
            {
                list_oyunlar.Items.Clear();
                veriler.Clear();
                con.Open();
                komut = new OleDbCommand("SELECT * FROM oyunlar", con);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    veriler.Add(
                        new Oyun()
                        {
                            oyunAdi = dr["oyun_adi"].ToString(),
                            oyunYolu = dr["oyun_yolu"].ToString(),
                            oyunResmi = dr["oyun_resmi"].ToString()
                        }
                        );
                }
                if (con.State != ConnectionState.Closed)
                    con.Close();
                foreach (var item in veriler)
                {
                    list_oyunlar.Items.Add(item.oyunAdi);
                }
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show($"HATA, hata mesajı ==> {ex.Message}");
            }
        }

        private void list_oyunlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (list_oyunlar.SelectedIndex!=-1)
            {
                pb_oyunresmi.ImageLocation = veriler[list_oyunlar.SelectedIndex].oyunResmi;
                pb_oyunresmi.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_kaldir_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_oyunlar.SelectedIndex != -1)
                {
                    con.Open();
                    komut = new OleDbCommand("DELETE * FROM oyunlar WHERE oyun_adi='" + list_oyunlar.SelectedItem.ToString() + "'", con);
                    komut.ExecuteNonQuery();
                    con.Close();
                    oyunListesiniGetir();
                    if (list_oyunlar.Items.Count != 0)
                        list_oyunlar.SelectedIndex = 0;
                    else
                        pb_oyunresmi.Image = null;
                }
                else
                {
                    MessageBox.Show("kaldırılabilir bir oyun yok");
                }
                
                

            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show($"HATA, hata mesajı ==> {ex.Message}");
            }
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_oyunlar.SelectedIndex != -1)
                {
                    string myPath = veriler[Convert.ToInt32(list_oyunlar.SelectedIndex.ToString())].oyunYolu;
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = myPath;
                    prc.Start();
                }
                else
                {
                    MessageBox.Show("seçili oyun yok");
                }
                
            }
            catch(Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show($"HATA, hata mesajı ==> {ex.Message}");
            }
            
        }
    }
}