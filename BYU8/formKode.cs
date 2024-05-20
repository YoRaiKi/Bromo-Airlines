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
    public partial class formKode : Form
    {
        public formKode()
        {
            InitializeComponent();
        }

        private void formKode_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kode.Text = "";
            Berlaku.Text = "";
            Persentase.Text = "";
            Maksimum.Text = "";
            Deskripsi.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kode = Kode.Text;
            string berlaku = Berlaku.Text;
            string persentase = Persentase.Text;
            string maksimum = Maksimum.Text;
            string deskripsi = Deskripsi.Text;

            dataGridView1.Rows.Add(kode, berlaku, persentase, maksimum, deskripsi);

            Kode.Text = "";
            Berlaku.Text = "";
            Persentase.Text = "";
            Maksimum.Text = "";
            Deskripsi.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column6")
            {
                Kode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Berlaku.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Persentase.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Maksimum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Deskripsi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column7")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
