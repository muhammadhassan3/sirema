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

namespace sirema
{
    public partial class Form1 : Form
    {
        Jurusan jurusan = new Jurusan();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jurusan.isExist(tbKode.Text))
            {
                MessageBox.Show("Kode Sudah ada");
            }
            else MessageBox.Show("Kode Belum ada");
        }
    }
}
