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
    public partial class Form7 : Form
    {
        public string Au { get; set; }
        public string iao { get; set; }
        public string Pr { get; set; }
        public string dh { get; set; }  
        public string La { get; set; }  
        public string dkju { get; set; }
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Au, iao, Pr, dh, La, dkju);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
