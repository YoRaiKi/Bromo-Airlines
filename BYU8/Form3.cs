using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BYU8
{
    public partial class Form3 : Form
    {
        formBandara bandara;
        formMaskapai maskapai;
        formJadwal jadwal;
        formKode kode;
        formStatus status;
        public Form3()
        {
            InitializeComponent();
            mdiProp();
        }
        bool sidebarExpand = true;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnBandara.Width = sidebar.Width;
                    pnMaskapai.Width = sidebar.Width;
                    pnJadwal.Width = sidebar.Width;
                    pnKode.Width = sidebar.Width;
                    pnStatus.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 218)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnBandara.Width = sidebar.Width;
                    pnMaskapai.Width = sidebar.Width;
                    pnJadwal.Width = sidebar.Width;
                    pnKode.Width = sidebar.Width;
                    pnStatus.Width = sidebar.Width; 
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bandara == null)
            {
                bandara = new formBandara();
                bandara.FormClosed += Bandara_FormClosed;
                bandara.MdiParent = this;
                bandara.Show();
            }
            else
            {
                bandara.Activate();
            }
        }
        private void Bandara_FormClosed(object sender, FormClosedEventArgs e)
        {
            bandara = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (maskapai == null)
            {
                maskapai = new formMaskapai();
                maskapai.FormClosed += Maskapai_FormClosed;
                maskapai.MdiParent = this;
                maskapai.Show();
            }
            else
            {
                maskapai.Activate();
            }
        }
        private void Maskapai_FormClosed(object sender, FormClosedEventArgs e)
        {
            maskapai = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (kode == null)
            {
                kode = new formKode();
                kode.FormClosed += Kode_FormClosed;
                kode.MdiParent = this;
                kode.Show();
            }
            else
            {
                kode.Activate();
            }
        }
        private void Kode_FormClosed(object sender, FormClosedEventArgs e)
        {
            kode = null;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (jadwal == null)
            {
                jadwal = new formJadwal();
                jadwal.FormClosed += Jadwal_FormClosed;
                jadwal.MdiParent = this;
                jadwal.Show();
            }
            else
            {
                jadwal.Activate();
            }
        }
        private void Jadwal_FormClosed(object sender, FormClosedEventArgs e)
        {
            jadwal = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (status == null)
            {
                status = new formStatus();
                status.FormClosed += Status_FormClosed;
                status.MdiParent = this;
                status.Show();
            }
            else
            {
                status.Activate();
            }
        }
        private void Status_FormClosed(Object sender, FormClosedEventArgs e)
        {
            status = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
