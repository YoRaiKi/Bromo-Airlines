using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BYU8
{
    public partial class formJadwal : Form
    {
        public formJadwal()
        {
            InitializeComponent();
        }

        private void formJadwal_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            data1.Rows.Add("ID-7518", "Juanda", "Hallim Perdana Kusuma", "Batik Airlines", "30-05-2023", "19:55", "01 Jam 15 Menit", "829891");
            data1.Rows.Add("IP_0203", "Juanda", "Soekarno", "Pelita Airlines", "30-05-2023", "19:50", "01 Jam 15 Menit", "684000");
            data1.Rows.Add("QG-0719", "Juanda", "Soekarno", "Citilink", "30-05-2023", "19:30", "01 Jam 15 Menit", "1317538");
            data1.Rows.Add("QG-0173", "Juanda", "Hallim Perdana Kusuma", "Citilink", "30-05-2023", "19:00", "01 Jam 15 Menit", "772601");
            data1.Rows.Add("GA-0325", "Juanda", "Soekarno", "Garuda Indonesia", "30-05-2023", "18:40", "01 Jam 15 Menit", "1536880");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string kode = Kode.Text;
            string dari = Dari.Text;
            string ke = Ke.Text;
            string maskapai = Maskapai.Text;
            string tanggal =Tanggal.Text;
            string waktu = Waktu.Text;
            string durasi = Durasi.Text;
            string harga = Harga.Text;

            data1.Rows.Add(kode, dari, ke, maskapai, tanggal, waktu, durasi, harga);

            Kode.Text = "";
            Dari.Text = "";
            Ke.Text = "";
            Maskapai.Text = "";
            Tanggal.Text = "";
            Waktu.Text = "";
            Durasi.Text = "";
            Harga.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kode.Text = "";
            Dari.Text = "";
            Ke.Text = "";
            Maskapai.Text = "";
            Tanggal.Text = "";
            Waktu.Text = "";
            Durasi.Text = "";
            Harga.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data1.Columns[e.ColumnIndex].Name == "Column9")
            {
                Kode.Text = data1.CurrentRow.Cells[0].Value.ToString();
                Dari.Text = data1.CurrentRow.Cells[1].Value.ToString(); ;
                Ke.Text = data1.CurrentRow.Cells[2].Value.ToString(); ;
                Maskapai.Text = data1.CurrentRow.Cells[3].Value.ToString();
                Tanggal.Text = data1.CurrentRow.Cells[4].Value.ToString();
                Waktu.Text = data1.CurrentRow.Cells[5].Value.ToString();
                Durasi.Text = data1.CurrentRow.Cells[6].Value.ToString();
                Harga.Text = data1.CurrentRow.Cells[7].Value.ToString();

                foreach (DataGridViewRow row in data1.Rows)
                {
                    data1.Rows.Remove(row);
                }
            }
            if (data1.Columns[e.ColumnIndex].Name == "Column10")
            {
                foreach (DataGridViewRow row in data1.Rows)
                {
                    data1.Rows.Remove(row);
                }
            }
        }
    }
}
