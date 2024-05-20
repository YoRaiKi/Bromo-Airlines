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
    public partial class formBandara : Form
    {
        public formBandara()
        {
            InitializeComponent();
        }

        private void formBandara_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            dataGridView1.Rows.Add("Abdul Rochman", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSk", "Manokwari", "Indonesia", "2", "Manokwari");
            dataGridView1.Rows.Add("Achmad yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta");
            dataGridView1.Rows.Add("Adi Sumarmo", "SOC", "Solo", "Indonesia", "2", "Solo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = Nama.Text;
            string kode = Kode.Text;
            string kota = Kota.Text;
            string negara = Negara.Text;
            string jumlah = Jumlah.Text;
            string alamat = Alamat.Text;

            dataGridView1.Rows.Add(nama, kode, kota, negara, jumlah, alamat);

            Nama.Text = "";
            Kode.Text = "";
            Kota.Text = "";
            Negara.Text = "";
            Jumlah.Text = "";
            Alamat.Text = "";
        }

        private void Alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Column7")
            {
                Nama.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Kode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Kota.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Negara.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Jumlah.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Alamat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column8")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nama = Nama.Text;
            string kode = Kode.Text;
            string kota = Kota.Text;
            string negara = Negara.Text;
            string jumlah = Jumlah.Text;
            string alamat = Alamat.Text;

            dataGridView1.Rows.Add(nama, kode, kota, negara, jumlah, alamat);

            Nama.Text = "";
            Kode.Text = "";
            Kota.Text = "";
            Negara.Text = "";
            Jumlah.Text = "";
            Alamat.Text = "";
        }
    }
}
