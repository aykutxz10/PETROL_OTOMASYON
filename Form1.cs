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
                ShowMessage("Kullanıcı adı giriniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                ShowMessage("Şifre giriniz.");
                return;
            }

            string kul = textBox1.Text;
            string şifre = textBox2.Text;

            try
            {
                using (SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;"))
                {
                    bağlantı.Open();
                    string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                    using (SqlCommand command = new SqlCommand(sorgu, bağlantı))
                    {
                        command.Parameters.AddWithValue("@kul", kul);
                        command.Parameters.AddWithValue("@şifre", şifre);

                        using (SqlDataReader oku = command.ExecuteReader())
                        {
                            if (oku.Read())
                            {
                                genel_bilgi = "Hoşgeldin " + oku["kullaniciAdi"].ToString();
                                string Rol = oku["Rol"].ToString();
                                NavigateToRole(Rol);
                            }
                            else
                            {
                                ShowMessage("Kullanıcı adı veya şifre hatalı.");
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                ShowMessage("Veritabanı hatası: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                ShowMessage("Beklenmedik bir hata oluştu: " + ex.Message);
            }
        }

        private void NavigateToRole(string role)
        {
            switch (role)
            {
                case "Kasacı":
                    ShowMessage(genel_bilgi);
                    new Kasa().Show();
                    this.Hide();
                    break;
                case "Pompacı":
                    ShowMessage(genel_bilgi);
                    new pompa().Show();
                    this.Hide();
                    break;
                case "Yönetici":
                    ShowMessage(genel_bilgi);
                    new Giriş().Show();
                    this.Hide();
                    break;
                default:
                    ShowMessage("Geçersiz rol.");
                    break;
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}



