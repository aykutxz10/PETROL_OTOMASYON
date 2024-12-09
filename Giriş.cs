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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class Giriş : Form
    {
        public static string genel_bilgi = "";

        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        public Giriş()
        {
            InitializeComponent();
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Aykutz";
            string şifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    personel personelform = new personel();
                    personelform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void kASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Aykutz";
            string şifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    Kasa Kasaform = new Kasa();
                    Kasaform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }
        

        private void pOMPALARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Aykutz";
            string şifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    pompa pompaform = new pompa();
                    pompaform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }
        private void üRÜNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Aykutz";
            string şifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    Ürün Ürünform = new Ürün();
                    Ürünform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }
        

        private void şUBELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Aykutz";
            string şifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    Sube Subeform = new Sube();
                    Subeform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }


        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ana sayfada çıkış butonuna tıklandığında:
            Form1 form1 = new Form1();
            form1.Show();  // Giriş formunu göster
            this.Hide();        // Ana sayfayı gizle

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
