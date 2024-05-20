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
    public partial class formMaskapai : Form
    {
        public formMaskapai()
        {
            InitializeComponent();
        }

        private void formMaskapai_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = Nama.Text;
            string perusahaan = Perusahaan.Text;
            string jumlah = Jumlah.Text;
            string deskripsi = Deskripsi.Text;

            dataGridView1.Rows.Add(nama , perusahaan , jumlah , deskripsi );

            Nama.Text = "";
            Perusahaan.Text = "";
            Jumlah.Text = "";
            Deskripsi.Text = "";
        }

        private void Jumlah_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column5")
            {
                Nama.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Perusahaan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Jumlah.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Deskripsi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column6")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nama.Text = "";
            Perusahaan.Text = "";
            Jumlah.Text = "";
            Deskripsi.Text = "";
        }
    }
}
