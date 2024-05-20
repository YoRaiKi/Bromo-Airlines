namespace BYU8
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBandara = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.pnMaskapai = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pnJadwal = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pnKode = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnBandara.SuspendLayout();
            this.pnMaskapai.SuspendLayout();
            this.pnJadwal.SuspendLayout();
            this.pnKode.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnHam
            // 
            this.btnHam.Image = global::BYU8.Properties.Resources.menu_alt_72;
            this.btnHam.Location = new System.Drawing.Point(16, 16);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(35, 32);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 5;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dashboard";
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.pnBandara);
            this.sidebar.Controls.Add(this.pnMaskapai);
            this.sidebar.Controls.Add(this.pnJadwal);
            this.sidebar.Controls.Add(this.pnKode);
            this.sidebar.Controls.Add(this.pnStatus);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(218, 436);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnBandara
            // 
            this.pnBandara.Controls.Add(this.button7);
            this.pnBandara.Location = new System.Drawing.Point(3, 3);
            this.pnBandara.Name = "pnBandara";
            this.pnBandara.Size = new System.Drawing.Size(218, 56);
            this.pnBandara.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::BYU8.Properties.Resources.map_selected_72;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-2, -3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(234, 62);
            this.button7.TabIndex = 15;
            this.button7.Text = "          Master Bandara";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnMaskapai
            // 
            this.pnMaskapai.Controls.Add(this.button8);
            this.pnMaskapai.Location = new System.Drawing.Point(3, 65);
            this.pnMaskapai.Name = "pnMaskapai";
            this.pnMaskapai.Size = new System.Drawing.Size(218, 56);
            this.pnMaskapai.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Image = global::BYU8.Properties.Resources.plane_take_off_solid_72;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-2, -3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(234, 62);
            this.button8.TabIndex = 15;
            this.button8.Text = "          Master Maskapai\r\n";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pnJadwal
            // 
            this.pnJadwal.Controls.Add(this.button9);
            this.pnJadwal.Location = new System.Drawing.Point(3, 127);
            this.pnJadwal.Name = "pnJadwal";
            this.pnJadwal.Size = new System.Drawing.Size(218, 56);
            this.pnJadwal.TabIndex = 17;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Image = global::BYU8.Properties.Resources.calendar_selected_721;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-2, -3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(234, 62);
            this.button9.TabIndex = 15;
            this.button9.Text = "          Master Jadwal Penerbangan";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pnKode
            // 
            this.pnKode.Controls.Add(this.button10);
            this.pnKode.Location = new System.Drawing.Point(3, 189);
            this.pnKode.Name = "pnKode";
            this.pnKode.Size = new System.Drawing.Size(218, 56);
            this.pnKode.TabIndex = 18;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Image = global::BYU8.Properties.Resources.purchase_tag_alt_selected_72;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-2, -3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(234, 62);
            this.button10.TabIndex = 15;
            this.button10.Text = "          Master Kode Promo";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.button11);
            this.pnStatus.Location = new System.Drawing.Point(3, 251);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(218, 56);
            this.pnStatus.TabIndex = 17;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Image = global::BYU8.Properties.Resources.notepad_selected_72;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(-2, -3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(234, 62);
            this.button11.TabIndex = 15;
            this.button11.Text = "          Ubah Status Penerbangan";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.button12);
            this.pnLogout.Location = new System.Drawing.Point(3, 313);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(218, 56);
            this.pnLogout.TabIndex = 17;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Image = global::BYU8.Properties.Resources.log_out_unselected_72;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(-2, -3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(234, 62);
            this.button12.TabIndex = 15;
            this.button12.Text = "      Logout";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(929, 497);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnBandara.ResumeLayout(false);
            this.pnMaskapai.ResumeLayout(false);
            this.pnJadwal.ResumeLayout(false);
            this.pnKode.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnMaskapai;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel pnBandara;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnJadwal;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel pnKode;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}