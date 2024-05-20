using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BYU8
{
    public partial class Form5 : Form
    {
        public string foy { get; set; }
        public string hur { get; set; }  
        public string Ch { get; set; }
        public string Ha { get; set; }
        public static Form5 Instance;
        public Label lab1;
        public Form5()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form();
            form4.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = foy;
            label3.Text = hur;
            label4.Text = Ch;
            label5.Text = Ha;

            dataGridView1.Rows.Add(" IP - 0209", "Pelita Air", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "15:10 - 16:45");
            dataGridView1.Rows.Add(" IP - 0298", "garuda indonesia", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "19:10 - 21:45");
            dataGridView1.Rows.Add(" IP - 0309", "lion Air", "Juanda", "Soekarno Hatta", "726.000", "24-05-2023", "06:00 - 10:45");
            dataGridView1.Rows.Add(" IP - 0298", "citilink", "Juanda", "Soekarno Hatta", "725.000", "24-05-2023", "17:10 - 19:40");
            dataGridView1.Rows.Add(" IP - 0099", "Pelita Air", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "15:10 - 17:45");
            dataGridView1.Rows.Add(" IP - 0749", "transnusa", "Juanda", "Soekarno Hatta", "72.000", "24-05-2023", "10:10 - 11:45");
            dataGridView1.Rows.Add(" IP - 0276", "air asia", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "08:10 - 09:00");
            dataGridView1.Rows.Add(" IP - 0709", "garuda indonesia", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "20:46 - 121:55");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column8")
            {
                Form6 form6 = new Form6();
                form6.Be = label5.Text;
                form6.ug = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                form6.To = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                form6.Po = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form6.Op = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                form6.Ge = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                form6.dg = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                form6.yu = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                form6.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
