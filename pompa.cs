using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class pompa : Form
    {
        public pompa()
        {
            InitializeComponent();
        }

        private void pompa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet6.Pompake' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pompakeTableAdapter1.Fill(this.petrol_otomasyonDataSet6.Pompake);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet5.Pompake' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pompakeTableAdapter.Fill(this.petrol_otomasyonDataSet5.Pompake);
            // TODO: Bu kod satırı 'petrol_otomasyonDataSet4.PompaCihazlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
