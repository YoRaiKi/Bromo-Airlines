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
    public partial class Form6 : Form
    {
        public string Be { get; set; }
        public string To { get; set; }
        public string Po { get; set; }
        public string Op { get; set; }
        public string Ge { get; set; }
        public string dg { get; set; }
        public string yu { get; set; }
        public string ug { get; set; }
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.iao = To;
            form7.Pr = Po;
            form7.dh = Op;
            form7.La = dg;
            form7.dkju = yu;
            form7.Au = ug;
            form7.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        { 
            label7.Text = To;
            label2.Text = Po;
            label5.Text = Op;
            label14.Text = Ge;
            label8.Text = dg;
            label9.Text = yu;
            label10.Text = Be;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
