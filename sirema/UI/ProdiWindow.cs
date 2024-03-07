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
    public partial class ProdiWindow : Form
    {
        Prodi prodi = new Prodi();
        Jurusan jurusan = new Jurusan();
        public ProdiWindow()
        {
            InitializeComponent();
        }


        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (prodi.isExist(tbKode.Text))
            {
                prodi.KodeProdi = tbKode.Text;

                if (prodi.updateData(tbNama.Text, cbJurusan.SelectedValue.ToString()) > 0)
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
            if (prodi.isExist(tbKode.Text))
            {
                prodi.KodeProdi = tbKode.Text;
                if (MessageBox.Show("Apakah kamu yakin akan menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (prodi.deleteData() > 0)
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
            cbJurusan.SelectedIndex = -1;
        }

        private void ProdiWindow_Load(object sender, EventArgs e)
        {
            showData();
            loadJurusanData();
        }

        private void showData()
        {
            if (tbSearch.Text == "")
            {
                lsProdi.DataSource = prodi.getAll();
                tbKode.Text = prodi.getNextId();
            }
            else
            {
                lsProdi.DataSource = prodi.findDataByName(tbSearch.Text);
            }
        }

        private void lsProdi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string refId = lsProdi.Rows[e.RowIndex].Cells["col_jurusan"].Value.ToString();
            string id = lsProdi.Rows[e.RowIndex].Cells["col_kode"].Value.ToString();
            string name = lsProdi.Rows[e.RowIndex].Cells["col_name"].Value.ToString();

            tbKode.Text = id;
            tbNama.Text = name;
            cbJurusan.SelectedValue = refId;
            tbNama.Focus();
        }

        private void tbNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnSave.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }

        private void setRowTheme()
        {
            foreach (DataGridViewRow row in lsProdi.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Index % 2 == 0)
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

        private void lsProdi_Paint(object sender, PaintEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cbJurusan.SelectedValue.ToString());
            if (!prodi.isExist(tbKode.Text))
            {
                prodi.KodeJurusan = (cbJurusan.SelectedItem as Jurusan).KodeJurusan;
                prodi.NamaProdi = tbNama.Text;
                prodi.KodeProdi = tbKode.Text;

                if (prodi.addProdi() > 0)
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

        private void loadJurusanData()
        {
            DataTable list = jurusan.getAll();
            List<Jurusan> datasource = new List<Jurusan>();

            foreach (DataRow row in list.Rows)
            {
                Jurusan item = new Jurusan();
                item.KodeJurusan = row[0].ToString();
                item.NamaJurusan = row[1].ToString();
                datasource.Add(item);
            }

            cbJurusan.DataSource = datasource;
            cbJurusan.DisplayMember = "NamaJurusan";
            cbJurusan.ValueMember = "KodeJurusan";

        }
    }
}
