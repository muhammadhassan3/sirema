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
    public partial class Login : Form
    {
        User user = new User();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Apakah kamu yakin ingin keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string result = user.login(tbUserId.Text, tbPassword.Text);

            if(result == string.Empty)
            {
                MessageBox.Show("Pengguna tidak ditemukan, pastikan user id dan password yang kamu masukkan sudah benar", "Gagal Masuk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUserId.SelectAll();
                tbUserId.Focus();
                return;
            }

            Dashboard dashboard = new Dashboard(user);
            dashboard.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }
    }
}
