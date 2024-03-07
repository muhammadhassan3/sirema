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
                    clear();
                    tbNama.Focus();
                    showData();
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
                    clear();
                    tbNama.Focus();
                    showData();
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
                if(MessageBox.Show("Apakah kamu yakin akan menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (jurusan.deleteData() > 0)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    tbNama.Focus();
                    clear();
                    showData();
                }
                else
                {
                    MessageBox.Show("Data tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Data tidak tersedia");
        }

        private void clear()
        {
            tbKode.Text = string.Empty;
            tbNama.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            if(tbSearch.Text == "")
            {
                lsJurusan.DataSource = jurusan.getAll();
                tbKode.Text = jurusan.getNextId();
            }
            else
            {
                lsJurusan.DataSource = jurusan.findDataByName(tbSearch.Text);
            }
        }

        private void lsJurusan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            string id = lsJurusan.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = lsJurusan.Rows[e.RowIndex].Cells[1].Value.ToString();

            tbKode.Text = id;
            tbNama.Text = name;

            tbNama.Focus();
        }

        private void tbNama_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }else if(e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }

        private void setRowTheme()
        {
            foreach(DataGridViewRow row in lsJurusan.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(row.Index %2 == 0)
                    {
                        cell.Style.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.CadetBlue;
                    }
                }
            }
        }

        private void lsJurusan_Paint(object sender, PaintEventArgs e)
        {
            setRowTheme();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
