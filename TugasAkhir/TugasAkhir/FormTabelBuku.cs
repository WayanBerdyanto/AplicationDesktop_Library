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
    public partial class FormTabelBuku : Form
    {
        public FormTabelBuku()
        {
            InitializeComponent();
        }
        KoneksiSQL buku = new KoneksiSQL("buku");
        private void FormTabelBuku_Load(object sender, EventArgs e)
        {
            ikat();
            buku.tampliTanggal(txtTime);
            label1.Text = "HALO USER :[" + Form1.userName + "]";
        }
        void ikat()
        {
            txtBuku.DataBindings.Add("Text", buku.getBs(), "kd_buku");
            txtJudulBuku.DataBindings.Add("Text", buku.getBs(), "judul_buku");
            txtPenulis.DataBindings.Add("Text", buku.getBs(), "penulis");
            txtPenerbit.DataBindings.Add("Text", buku.getBs(), "penerbit");
            txtTahun.DataBindings.Add("Text", buku.getBs(), "thn_penerbit");
            txtStok.DataBindings.Add("Text", buku.getBs(), "stok");
            dgvBuku.DataSource = buku.getBs();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            buku.getBs().MoveFirst();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            buku.getBs().MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            buku.getBs().MovePrevious();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            buku.getBs().MoveLast();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.Show();
            FormTabelBuku fb = new FormTabelBuku();
            fb.Close();
        }

        private void FormTabelBuku_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTabelBuku fb = new FormTabelBuku();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas f_pts = new FormPetugas();
            f_pts.Show();
            this.Hide();
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            FormTabelMahasiswa f_mhs = new FormTabelMahasiswa();
            f_mhs.Show();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormFilterBuku bk = new FormFilterBuku();   
            bk.Show();
        }

        private void btnBackUpKembali_Click(object sender, EventArgs e)
        {
            BackUp buku = new BackUp(dgvBuku);
        }
    }
}
