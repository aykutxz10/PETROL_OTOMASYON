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
    public partial class Sube : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        public Sube()
        {
            InitializeComponent();
        }

        private void Sube_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet1.Subeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.subelerTableAdapter.Fill(this.petrol_otomasyonDataSet1.Subeler);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text; // TextBox9'dan alınan arama metni
            AramaYap(searchText);
        }
        private void AramaYap(string searchText)
        {
            string isim = textBox1.Text;

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string sorgu = "SELECT * FROM Subeler WHERE SubeIsmi LIKE @isim";
                SqlCommand command = new SqlCommand(sorgu,bağlantı);
                command.Parameters.AddWithValue("@isim", "%" + searchText + "%"); // LIKE operatörü ile esnek arama

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); // Veritabanından alınan veriyi tutacak DataTable
                dataAdapter.Fill(dt); // DataTable'a veriyi yüklüyoruz

                // DataGridView'e sonuçları bağlıyoruz
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajı gösteriyoruz
            }
        }
    }
}
