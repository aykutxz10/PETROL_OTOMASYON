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

namespace PETROL_OTOMASYON_8_ARALIIK
{

    public partial class Form1 : Form
    {
        public static string genel_bilgi = "";

        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("kullanıcı Adı Gİr");
                return;


            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("şifre gir");
                return;
            }
            string kul = textBox1.Text;
            string şifre = textBox2.Text;
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
                    Giriş Girişform = new Giriş();
                    Girişform.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("kullanıcı Adı Gİr");
                return;

            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("şifre gir");
                return;
            }
            string kul = textBox1.Text;
            string şifre = textBox2.Text;
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
                    Giriş Girişform = new Giriş();
                    Girişform.Show();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
