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
    public partial class FormPetugas : Form
    {
        private bool baru;
        private string kodeLama;
        public FormPetugas()
        {
            InitializeComponent();
        }
        KoneksiSQL petugas = new KoneksiSQL("petugas");
        private void FormPetugas_Load(object sender, EventArgs e)
        {
            ikat();
            petugas.tampliTanggal(txtDate);
            label1.Text = "HALO USER :[" + Form1.userName + "]";

        }

        void ikat()
        {
            txtId_petugas.DataBindings.Add("Text", petugas.getBs(), "id_ptgs");
            txtNamaPetugas.DataBindings.Add("Text", petugas.getBs(), "nama_ptgs");
            txtGender.DataBindings.Add("Text", petugas.getBs(), "gender");
            txtAlamat.DataBindings.Add("Text", petugas.getBs(), "alamat");
            txtNo_Hp.DataBindings.Add("Text", petugas.getBs(), "no_hp");
            dgvPetugas.DataSource = petugas.getBs();
        }

        void lepas() //<-- jika berpedan sebagai input maka akan dilepas
        {
            txtId_petugas.DataBindings.Clear();
            txtNamaPetugas.DataBindings.Clear();
            txtGender.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtNo_Hp.DataBindings.Clear();
        }

        void modeEdit()
        {

            txtId_petugas.Enabled = true;
            txtNamaPetugas.Enabled = true;
            txtGender.Enabled = true;
            txtAlamat.Enabled = true;
            txtNo_Hp.Enabled = true;
            txtId_petugas.Focus();

            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnPrint.Enabled = false;
            btnUndo.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            btnUndo.Visible = true;
            btnClose.Enabled = false;

        }
        void modeSave()
        {
            txtId_petugas.Enabled = false;
            txtNamaPetugas.Enabled = false;
            txtGender.Enabled = false;
            txtAlamat.Enabled = false;
            txtNo_Hp.Enabled = false;
            txtId_petugas.Focus();

            btnTop.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnLast.Enabled = true;
            btnPrint.Enabled = true;
            btnSearch.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnUndo.Visible = false;
            btnClose.Enabled = true;

        }
        private void btnTop_Click(object sender, EventArgs e)
        {
            petugas.getBs().MoveFirst();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            petugas.getBs().MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            petugas.getBs().MovePrevious();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            petugas.getBs().MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String stringSql, id_ptgs, nama_ptgs, gender, alamat, no_hp;
            id_ptgs = txtId_petugas.Text;
            nama_ptgs = txtNamaPetugas.Text;
            gender = txtGender.Text;
            alamat = txtAlamat.Text;
            no_hp = txtNo_Hp.Text;


            if (baru)
            {
                stringSql = "INSERT INTO petugas VALUES ('{0}','{1}','{2}','{3}','{4}')";
                stringSql = String.Format(stringSql, id_ptgs, nama_ptgs, gender, alamat, no_hp);
            }
            else
            {
                stringSql = "UPDATE petugas set id_ptgs='{0}', nama_ptgs='{1}', ";
                stringSql += "gender='{2}', alamat='{3}', ";
                stringSql += "no_hp='{4}' WHERE id_ptgs='{5}'";
                stringSql = String.Format(stringSql, id_ptgs, nama_ptgs, gender, alamat, no_hp, kodeLama);
            }
            MessageBox.Show("Periksa dulu guys : " + stringSql);
            petugas.eksekusiSQL(stringSql);
            modeSave();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            txtId_petugas.Text = "";
            txtNamaPetugas.Text = "";
            txtGender.Text = "";
            txtAlamat.Text = "";
            txtNo_Hp.Text = "";
            baru = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            kodeLama = txtId_petugas.Text;
            modeEdit();
            baru = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM petugas WHERE id_ptgs='{0}'";
                stringSQL = string.Format(stringSQL, txtId_petugas.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                this.petugas.eksekusiSQL(stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //FormReportPetugas fp = new FormReportPetugas();
            //fp.Show();
        }

        private void txtcaripetugas_KeyUp(object sender, KeyEventArgs e)
        {
            petugas.getBs().Filter = "nama_ptgs LIKE '%" +
                txtcaripetugas.Text + "%'";
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void FormPetugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPetugas fb = new FormPetugas();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormHome bk = new FormHome();
            bk.Show();
            this.Hide();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            FormTabelBuku tk = new FormTabelBuku();
            tk.Show();
            this.Hide();
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            FormTabelMahasiswa tm = new FormTabelMahasiswa();
            tm.Show();
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
            txtcaripetugas.Focus();
        }

        private void btnBackUpKembali_Click(object sender, EventArgs e)
        {
            BackUp ptg = new BackUp(dgvPetugas);
        }
    }
}
