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
    public partial class Kasa : Form
    {
        public static string genel_bilgi = "";

        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        public Kasa()
        {
            InitializeComponent();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet2.Kasa' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kasaTableAdapter.Fill(this.petrol_otomasyonDataSet2.Kasa);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}






