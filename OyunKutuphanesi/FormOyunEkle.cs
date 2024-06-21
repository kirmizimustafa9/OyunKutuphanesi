using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OyunKutuphanesi
{
    public partial class FormOyunEkle : Form
    {
        string dosyaYolu, resimYolu;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OyunKutuphanesi.accdb");
        OleDbCommand komut;
        public FormOyunEkle()
        {
            InitializeComponent();
            fileDialog_resimyolu.Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            fileDialog_oyunyolu.Filter = "Executable files (*.exe, *.lnk, *.url)|*.exe;*.lnk;*.url|All files (*.*)|*.*";



        }

        private void lbl_resimsec_Click(object sender, EventArgs e)
        {
            if (fileDialog_resimyolu.ShowDialog() == DialogResult.OK)
            {
                resimYolu = fileDialog_resimyolu.FileName;
                //MessageBox.Show(resimYolu);
                label4.Text = resimYolu;

            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_oyunAdi.Text!=string.Empty && label4.Text != "Secilmedi" && lbl_yol.Text != "Secilmedi")
                {
                    con.Open();
                    komut = new OleDbCommand("INSERT INTO oyunlar(oyun_adi,oyun_yolu,oyun_resmi) VALUES(@ad,yol,resim)", con);
                    komut.Parameters.AddWithValue("@ad", txt_oyunAdi.Text);
                    komut.Parameters.AddWithValue("@yol", dosyaYolu);
                    komut.Parameters.AddWithValue("@resim", resimYolu);
                    komut.ExecuteNonQuery();
                    if (con.State != ConnectionState.Closed)
                        con.Close();
                    MessageBox.Show("Oyun Başarıyla Eklendi.");
                    temizle();
                }
                else
                {
                    MessageBox.Show("eksik alanlar var lütfen kontrol edip tekrar deneyin");
                }
                
            }
            catch(Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show($"HATA, hata mesajı ==> {ex.Message}");
            }
        }

        private void btn_yolsec_Click(object sender, EventArgs e)
        {
            if (fileDialog_oyunyolu.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = fileDialog_oyunyolu.FileName;
                
                //MessageBox.Show(dosyaAdi);
                lbl_yol.Text = dosyaYolu;
                
            }
        }

        void temizle()
        {
            txt_oyunAdi.Text = string.Empty;
            fileDialog_oyunyolu.FileName = string.Empty;
            fileDialog_resimyolu.FileName = string.Empty;
            label4.Text = "Secilmedi";
            lbl_yol.Text = "Secilmedi";
        }
    }
}