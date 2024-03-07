namespace sirema.UI
{
    partial class ProdiWindow
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJurusan = new System.Windows.Forms.ComboBox();
            this.lsProdi = new System.Windows.Forms.DataGridView();
            this.col_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lsProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(727, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(210, 22);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cari";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(193, 353);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(350, 22);
            this.tbNama.TabIndex = 16;
            this.tbNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNama_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama Prodi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kode Prodi";
            // 
            // tbKode
            // 
            this.tbKode.Enabled = false;
            this.tbKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKode.Location = new System.Drawing.Point(193, 315);
            this.tbKode.Margin = new System.Windows.Forms.Padding(5);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(231, 22);
            this.tbKode.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(534, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUbah.AutoSize = true;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(453, 504);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 30);
            this.btnUbah.TabIndex = 24;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(372, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nama Jurusan";
            // 
            // cbJurusan
            // 
            this.cbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJurusan.Location = new System.Drawing.Point(193, 392);
            this.cbJurusan.Name = "cbJurusan";
            this.cbJurusan.Size = new System.Drawing.Size(350, 24);
            this.cbJurusan.TabIndex = 28;
            // 
            // lsProdi
            // 
            this.lsProdi.AllowUserToAddRows = false;
            this.lsProdi.AllowUserToDeleteRows = false;
            this.lsProdi.AllowUserToResizeRows = false;
            this.lsProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lsProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_jurusan,
            this.col_kode,
            this.col_name});
            this.lsProdi.Location = new System.Drawing.Point(17, 40);
            this.lsProdi.Name = "lsProdi";
            this.lsProdi.ReadOnly = true;
            this.lsProdi.RowHeadersWidth = 51;
            this.lsProdi.RowTemplate.Height = 24;
            this.lsProdi.RowTemplate.ReadOnly = true;
            this.lsProdi.Size = new System.Drawing.Size(920, 267);
            this.lsProdi.TabIndex = 29;
            this.lsProdi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lsProdi_CellClick);
            // 
            // col_jurusan
            // 
            this.col_jurusan.DataPropertyName = "kode_jurusan";
            this.col_jurusan.HeaderText = "Kode Jurusan";
            this.col_jurusan.MinimumWidth = 6;
            this.col_jurusan.Name = "col_jurusan";
            this.col_jurusan.ReadOnly = true;
            this.col_jurusan.Width = 125;
            // 
            // col_kode
            // 
            this.col_kode.DataPropertyName = "kode_prodi";
            this.col_kode.HeaderText = "Kode Prodi";
            this.col_kode.MinimumWidth = 6;
            this.col_kode.Name = "col_kode";
            this.col_kode.ReadOnly = true;
            this.col_kode.Width = 125;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_name.DataPropertyName = "nama_prodi";
            this.col_name.HeaderText = "Nama Prodi";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // ProdiWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 546);
            this.Controls.Add(this.lsProdi);
            this.Controls.Add(this.cbJurusan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdiWindow";
            this.Text = "Prodi";
            this.Load += new System.EventHandler(this.ProdiWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.lsProdi_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.lsProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbJurusan;
        private System.Windows.Forms.DataGridView lsProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
    }
}