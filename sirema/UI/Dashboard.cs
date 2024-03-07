using sirema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirema.UI
{
    public partial class Dashboard : Form
    {
        private bool directionRight = true;
        public Dashboard(User user)
        {
            InitializeComponent();
            lblNama.Text = $"Selamat Datang {user.NamaLengkap} - {user.Status}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point loc = lblDashboard.Location;
            if(loc.X <= 750 && directionRight)
            {
                lblDashboard.Location = new Point(loc.X + 5, loc.Y);
            }
            else
            {
                directionRight = false;
            }
            if(loc.X >=145 && !directionRight)
            {
                lblDashboard.Location = new Point(loc.X - 5, loc.Y);
            }
            else
            {
                directionRight = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 jurusan = new Form1();
            jurusan.TopLevel = false;
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(jurusan);
            jurusan.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdiWindow prodi = new ProdiWindow();
            prodi.TopLevel = false;
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(prodi);
            prodi.Show();
        }
    }
}
