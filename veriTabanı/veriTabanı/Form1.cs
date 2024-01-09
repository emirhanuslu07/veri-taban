using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
        vtContext veriler = new vtContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.Ogrenciler.Load();
            dataGridView1.DataSource = veriler.Ogrenciler.Local.ToBindingList();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            Ogrenci yeni_ogr = new Ogrenci();
            yeni_ogr.okulno = Int32.Parse(textBox3.Text);
            yeni_ogr.ad = textBox1.Text;
            yeni_ogr.soyad = textBox2.Text;

            veriler.Ogrenciler.Add(yeni_ogr);
            veriler.SaveChanges();

        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)

                {

                    //seçili satırı siliyoruz.

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }

                veriler.SaveChanges();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}









