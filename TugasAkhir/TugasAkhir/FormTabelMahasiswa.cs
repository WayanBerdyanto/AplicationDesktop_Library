using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    public partial class FormTabelMahasiswa : Form
    {
        public FormTabelMahasiswa()
        {
            InitializeComponent();
        }
        KoneksiSQL mhs = new KoneksiSQL("mahasiswa");
        private bool baru;
        private string kodeLama;
        private void FormTabelMahasiswa_Load(object sender, EventArgs e)
        {
            ikat();
            mhs.tampliTanggal(txtTime);
            label1.Text = "HALO USER :[" + Form1.userName + "]";
        }
        void ikat()
        {
            txtNim.DataBindings.Add("Text", mhs.getBs(), "nim");
            txtNamaMhs.DataBindings.Add("Text", mhs.getBs(), "nama_mhs");
            txtProdi.DataBindings.Add("Text", mhs.getBs(), "prodi");
            cbGender.DataBindings.Add("Text", mhs.getBs(), "gender");
            txtNoTelp.DataBindings.Add("Text", mhs.getBs(), "no_telp");
            txtAlamat.DataBindings.Add("Text", mhs.getBs(), "alamat");

            dgvMahasiswa.DataSource = mhs.getBs();
        }

        private void txtNim_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNim.Text.Length == 8 || e.KeyCode == Keys.Enter)
            {
                txtNamaMhs.Focus();
            }

        }
        private void modeSave()
        {
            txtNim.Enabled = false;
            txtNamaMhs.Enabled = false;
            txtProdi.Enabled = false;
            txtAlamat.Enabled = false;
            cbGender.Enabled = false;
            txtNoTelp.Enabled = false;
            btnTop.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnUndo.Visible = false;
            btnSave.Visible = false;
            btnPrint.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnClose.Enabled = true;
            ikat();
        }
        private void modeEdit()
        {
            txtNim.Enabled = true;
            txtNamaMhs.Enabled = true;
            txtProdi.Enabled = true;
            txtAlamat.Enabled = true;
            cbGender.Enabled = true;
            txtNoTelp.Enabled = true;
            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnUndo.Visible = true;
            btnSave.Visible = true;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            lepas();
        }
        void lepas()
        {
            txtNim.DataBindings.Clear();
            txtNamaMhs.DataBindings.Clear();
            txtProdi.DataBindings.Clear();
            txtNoTelp.DataBindings.Clear();
            cbGender.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
        }

        private void txtNim_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter || e.KeyData == Keys.Tab)
            {
                dgvMahasiswa.Focus();
            }
        }
        private String _nim;
        public String nim
        {
            get { return this._nim; }
        }

        private void dgvMahasiswa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                int brs = dgvMahasiswa.SelectedCells[0].RowIndex;
                this._nim = dgvMahasiswa.Rows[brs].Cells[0].Value.ToString();
                this.Visible = false;
            }
        }

        private void FormTabelMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            int brs = dgvMahasiswa.SelectedCells[0].RowIndex;
            this._nim = dgvMahasiswa.Rows[brs].Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, nim, nama, prodi, alamat, gender, no_telp;
            nim = txtNim.Text;
            nama = txtNamaMhs.Text;
            prodi = txtProdi.Text;
            alamat = txtAlamat.Text;
            gender = cbGender.Text;
            no_telp = txtNoTelp.Text;
            if (baru)
            {
                stringSQL = "INSERT INTO mahasiswa VALUES ('{0}','{1}','{2}','{3}',";
                stringSQL += "'{4}','{5}');";
                stringSQL = string.Format(stringSQL, nim, nama, prodi, alamat, gender,
                    no_telp);
            }
            else
            {
                stringSQL = "UPDATE mahasiswa SET nim='{0}',nama_mhs='{1}',";
                stringSQL += "prodi='{2}', alamat='{3}',gender='{4}',";
                stringSQL += "no_telp='{5}' WHERE nim ='{6}';";
                stringSQL = String.Format(stringSQL, nim, nama, prodi, alamat, gender,
                    no_telp, this.kodeLama);
            }
            mhs.eksekusiSQL(stringSQL);
            modeSave();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
            this.baru = false;
            this.kodeLama = txtNim.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            txtNim.Clear();
            txtNamaMhs.Clear();
            txtAlamat.Clear();
            txtProdi.Clear();
            txtNoTelp.Clear();
            this.baru = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah kamu yakin menghapus data ini ?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "Delete from mahasiswa where nim='{0}';";
                stringSQL = string.Format(stringSQL, txtNim.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan...");
                mhs.eksekusiSQL(stringSQL);
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan...");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            mhs.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mhs.getBs().MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mhs.getBs().MoveLast();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            mhs.getBs().MoveFirst();
        }

        private void txtNim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcarinimku_KeyUp(object sender, KeyEventArgs e)
        {
            mhs.getBs().Filter = "nim LIKE '%" +
            txtcarinimku.Text + "%'";
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormHome hm = new FormHome();
            hm.Show();
            this.Hide();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            FormTabelBuku tb = new FormTabelBuku();
            tb.Show();
            this.Hide();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas fp = new FormPetugas();
            fp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("Anda Yakin Ingin Keluar",
               "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
                ;
            }
            else
            {
                MessageBox.Show("Dibatalkan");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtcarinimku.Focus();
        }

        private void btnBackUpKembali_Click(object sender, EventArgs e)
        {
            BackUp mhs = new BackUp(dgvMahasiswa);
        }
    }
}


