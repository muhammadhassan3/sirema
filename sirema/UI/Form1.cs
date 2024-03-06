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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!jurusan.isExist(tbKode.Text))
            {
                jurusan.KodeJurusan = tbKode.Text;
                jurusan.NamaJurusan = tbNama.Text;

                if (jurusan.addData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan");
                    tbKode.Text = string.Empty;
                    tbNama.Text = string.Empty;
                    tbKode.Focus();
                }
                else
                {
                    MessageBox.Show("Data tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Kode Sudah ada");
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (jurusan.isExist(tbKode.Text))
            {
                jurusan.KodeJurusan = tbKode.Text;
                jurusan.NamaJurusan = tbNama.Text;

                if (jurusan.updateData() > 0)
                {
                    MessageBox.Show("Data berhasil diubah");
                    tbKode.Text = string.Empty;
                    tbNama.Text = string.Empty;
                    tbKode.Focus();
                }
                else
                {
                    MessageBox.Show("Data tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Data tidak tersedia");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (jurusan.isExist(tbKode.Text))
            {
                jurusan.KodeJurusan = tbKode.Text;
                jurusan.NamaJurusan = tbNama.Text;

                if (jurusan.deleteData() > 0)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    tbKode.Text = string.Empty;
                    tbNama.Text = string.Empty;
                    tbKode.Focus();
                }
                else
                {
                    MessageBox.Show("Data tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Data tidak tersedia");
        }
    }
}
