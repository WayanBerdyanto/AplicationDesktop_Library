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
    public partial class FormHome2 : Form
    {
        public FormHome2()
        {
            InitializeComponent();
        }
        KoneksiSQL detail = new KoneksiSQL("viev_detailKembali");
        //KoneksiSQL detail = new KoneksiSQL("view_cobaKembali");
        KoneksiSQL master = new KoneksiSQL("view_master");
        KoneksiSQL master_bayar = new KoneksiSQL("view_bayar");
        KoneksiSQL detail_bayar = new KoneksiSQL("view_pembayaran");
        KoneksiSQL detail1 = new KoneksiSQL("view_detailPinjam");
        private void FormHome2_Load(object sender, EventArgs e)
        {
            detail.tampliTanggal(txtDate);
            ikat();
            tampil();
            txtNo_Pinjam.Enabled = false;
            label1.Text = "HALO USER :[" + Form1.userName + "]";
            // dgvBayar.Rows.Clear();
        }
        void setelTanggal()
        {
            txtTglPinjam.Format = DateTimePickerFormat.Custom;
            txtTglPinjam.CustomFormat = ("yyyy-MM-dd");
            txtTglKembali.Format = DateTimePickerFormat.Custom;
            txtTglKembali.CustomFormat = ("yyyy-MM-dd");
            txtTglReal.Format = DateTimePickerFormat.Custom;
            txtTglReal.CustomFormat = ("yyyy-MM-dd");
            txtTglPinjam.Enabled =false;
            txtTglKembali.Enabled = false;
        }
        void tampil()
        {
            detail.getBs().Filter = "no_pinjam=" + txtNo_Pinjam.Text;
            detail1.getBs().Filter = "no_pinjam=" + txtNo_Pinjam.Text;
            //detail.getBs().Filter = "no_pinjam=" + txtNo_Pinjam.Text;
            detail_bayar.getBs().Filter = "no_pinjam= " + txtNo_Pinjam.Text;
            //dgvBayar.DataSource = bayar.getBs();
        }
        void hapus()
        {
            txtKdBuku.Clear();
            txtJudulBuku.Text = "";
            txtpenulis.Text = "";
            txtPenerbit.Text = "";
            txtThnPenerbit.Text = "";
            txtJmlhPinjam.Text = "0";
            txtIdPtgs.Text = "";
            // txtKdBuku.Focus();

        }
        void ikat()
        {
            txtNo_Pinjam.DataBindings.Add("Text", master.getBs(), "no_pinjam");
            txtTglPinjam.DataBindings.Add("Text", master.getBs(), "tgl_pinjam");
            txtTglKembali.DataBindings.Add("Text", master.getBs(), "tgl_kembali");
            txtNim.DataBindings.Add("Text", master.getBs(), "nim");
            txtNama.DataBindings.Add("Text", master.getBs(), "nama_mhs");
            txtProdi.DataBindings.Add("Text", master.getBs(), "prodi");
            cbGender.DataBindings.Add("Text", master.getBs(), "gender");
            txtNoHp.DataBindings.Add("Text", master.getBs(), "no_telp");
            txtAlamat.DataBindings.Add("Text", master.getBs(), "alamat");
            txtLamaPeminjaman.DataBindings.Add("Text", master.getBs(), "TotalHari");
            txtDenda.DataBindings.Add("Text", master.getBs(), "Jumlah_denda");
            txtTglReal.DataBindings.Add("Text", master.getBs(), "tgl_realPengembalian");

            txtKdBuku.DataBindings.Add("Text", detail1.getBs(), "kd_buku");
            txtJudulBuku.DataBindings.Add("Text", detail1.getBs(), "judul_buku");
            txtpenulis.DataBindings.Add("Text", detail1.getBs(), "penulis");
            txtPenerbit.DataBindings.Add("Text", detail1.getBs(), "penerbit");
            txtThnPenerbit.DataBindings.Add("Text", detail1.getBs(), "thn_penerbit");
            txtJmlhPinjam.DataBindings.Add("Text", detail1.getBs(), "jmlh_pinjam");
            txtJmlhKembali.DataBindings.Add("Text", detail.getBs(), "jmlh_kembali");
            txtIdPtgs.DataBindings.Add("Text", detail1.getBs(), "id_ptgs");

            txtNim2.DataBindings.Add("Text", master_bayar.getBs(), "nim");
            cbMethodeBayar.DataBindings.Add("Text", master_bayar.getBs(), "methode");
            txtTunai.DataBindings.Add("Text", detail_bayar.getBs(), "tunai");
            txtJumlahDenda.DataBindings.Add("Text", master_bayar.getBs(), "Jumlah_denda");
            txtKembalian.DataBindings.Add("Text", master_bayar.getBs(), "kembalian");
            cbStatusBayar.DataBindings.Add("Text", detail_bayar.getBs(), "status");
            txtIdPembayaran.DataBindings.Add("Text", detail_bayar.getBs(), "id_pembayaran");

            setelTanggal();
            dgvDetail.DataSource = detail.getBs();
            dgvBayar.DataSource = detail_bayar.getBs();
            //dgvBayar.DataSource = bayar.getBs();
        }
        void lepas()  
        {
            detail.getBs().DataSource = detail.getDt();
            txtKdBuku.DataBindings.Clear();
            txtJudulBuku.DataBindings.Clear();
            txtpenulis.DataBindings.Clear();
            txtPenerbit.DataBindings.Clear();
            txtThnPenerbit.DataBindings.Clear();
            txtJmlhPinjam.DataBindings.Clear();
            txtIdPtgs.DataBindings.Clear();
            dgvDetail.DataSource = detail.getBs();
        }
        public bool baru;
        public void modeEdit()
        {
            this.baru = false;
            txtNim.Enabled = false;
            txtKdBuku.Enabled = false;
            txtNim.ReadOnly = false;
            txtJudulBuku.Enabled = false;
            txtPenerbit.Enabled = false;
            txtpenulis.Enabled = false;
            txtThnPenerbit.Enabled = false;
            txtJmlhPinjam.Enabled = false;
            txtIdPtgs.Enabled = false;
            txtTglPinjam.Enabled = false;
            txtTglKembali.Enabled = false;
            txtLamaPeminjaman.Enabled = false;
            txtJmlhKembali.Enabled = true;
            txtDenda.Enabled = false;
            txtTglReal.Enabled = true;

            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            //btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnUndo.Visible = true;
            btnSave.Visible = true;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            txtJmlhKembali.Focus();
            lepas();
        }
        void modeSave()
        {
            txtNim.Enabled = false;
            txtNim.ReadOnly = true;
            txtKdBuku.Enabled = false;
            txtJudulBuku.Enabled = false;
            txtPenerbit.Enabled = false;
            txtpenulis.Enabled = false;
            txtThnPenerbit.Enabled = false;
            txtJmlhPinjam.Enabled = false;
            txtIdPtgs.Enabled = false;
            txtTglPinjam.Enabled = false;
            txtTglKembali.Enabled = false;
            txtLamaPeminjaman.Enabled = false;
            txtJmlhKembali.Enabled = false;
            txtTglReal.Enabled = false;

            btnTop.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            //btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnUndo.Visible = false;
            btnSave.Visible = false;
            btnPrint.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnClose.Enabled = true;
            //ikat();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveFirst();
            master_bayar.getBs().MoveFirst();
            tampil();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            master_bayar.getBs().MovePrevious();
            tampil();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            master_bayar.getBs().MovePrevious();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            master_bayar.getBs().MoveNext();
            tampil();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormFilter lp = new FormFilter();
            lp.Show();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            modeCari();
            String notaPinjamSekarang = txtNo_Pinjam.Text;
            String notaPinjam;
            cbNoPinjam.Visible = true;
            master.getBs().MoveFirst();
            cbNoPinjam.Items.Clear();
            cbNoPinjam.Text = notaPinjamSekarang;
            for (int n = 0; n<master.getBs().Count; n++)
            {
                notaPinjam = ((DataRowView)master.getBs().Current).Row["no_pinjam"].ToString();
                cbNoPinjam.Items.Add(notaPinjam);
                master.getBs().MoveNext();
            }
            int posisi = master.getBs().Find("no_pinjam", notaPinjamSekarang);
            master.getBs().Position = posisi;
            cbNoPinjam.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("Hapus No Pinjam. " + txtNo_Pinjam.Text + "?",
               "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                string no_pinjam = txtNo_Pinjam.Text;
                string strSQL = "DELETE FROM dtl_kmbli WHERE no_pinjam = '" + no_pinjam + "'";
                detail.eksekusiSQL(strSQL);

                string str = "DELETE FROM pinjam WHERE no_pinjam = '" + no_pinjam + "'";
                master.eksekusiSQL(str);

                MessageBox.Show("Penghapusan Selesai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                master.getBs().MoveNext();
                tampil();
            }
            else  
            {
                MessageBox.Show("Penghapusan Dibatalakan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
            if (txtJmlhKembali.CanUndo == true)
            {
                txtKdBuku.Undo();
                txtJudulBuku.Undo();
                txtpenulis.Undo();
                txtPenerbit.Undo();
                txtThnPenerbit.Undo();
                txtJmlhPinjam.Undo();
                txtIdPtgs.Undo();

                txtKdBuku.ClearUndo();
                txtJudulBuku.ClearUndo();
                txtpenulis.ClearUndo();
                txtPenerbit.ClearUndo();
                txtJmlhPinjam.ClearUndo();
                txtIdPtgs.ClearUndo();
                lepas();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

      //  private void btnNew_Click(object sender, EventArgs e)
      //  {

      //  }
        private void modeCari()
        {
            btnClose.Enabled = false;
          //  btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnLast.Enabled = false;
            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

        }

        private void cbNoPinjam_SelectedValueChanged(object sender, EventArgs e)
        {
            master.getBs().Position = master.getBs().Find("no_pinjam", cbNoPinjam.Text);
            tampil();
            cbNoPinjam.Visible = false;
            modeSave();
        }

        private void txtJmlhKembali_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtJmlhKembali.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && txtJmlhKembali.Text.Length > 0)
                {
                    string no_pinjam, kode_buku, jmlh_kembali, id_ptgs, strSQL;
                    no_pinjam = txtNo_Pinjam.Text;
                    kode_buku = txtKdBuku.Text;
                    id_ptgs = txtIdPtgs.Text;
                    jmlh_kembali = txtJmlhKembali.Text;
                    strSQL = "INSERT INTO dtl_kmbli (no_pinjam, kd_buku," +
                        "id_ptgs,jmlh_kembali) VALUES ('{0}','{1}','{2}','{3}')";
                    strSQL = string.Format(strSQL, no_pinjam, kode_buku, id_ptgs, jmlh_kembali);
                    MessageBox.Show(strSQL);
                    detail.eksekusiSQL(strSQL);
                    tampil();
                }
            }
        }

        private void cbTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTransaksi.SelectedItem.ToString() == "Peminjaman")
            {
                FormHome fh = new FormHome();
                fh.Show();
                this.Hide();
            }
        }

        private void txtTglReal_Validated(object sender, EventArgs e)
        {
            if (txtTglReal.Text.Length == 0 || txtTglReal.Text.Length > 6)
            {
                string strSQL, noNotaSekarang = txtNo_Pinjam.Text;
                KoneksiSQL coba = new KoneksiSQL("pinjam");
                int barisDitemukan = coba.getBs().Find("no_pinjam", txtNo_Pinjam.Text);
                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE pinjam SET tgl_realPengembalian ='{0}' WHERE no_pinjam='{1}'";
                    strSQL = String.Format(strSQL, txtTglReal.Text, noNotaSekarang);
                    MessageBox.Show("yesss update");
                    txtJmlhKembali.Focus();
                    tampil();
                    master.eksekusiSQL(strSQL);
                    barisDitemukan = master.getBs().Find("no_pinjam", noNotaSekarang);
                    master.getBs().Position = barisDitemukan;
                    tampil();
                    txtJmlhKembali.Focus();
                }
            }
        }

        private void cbStatusBayar_Validated(object sender, EventArgs e)
        {

        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            FormTabelBuku buku = new FormTabelBuku();
            buku.Show();
            this.Hide();
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

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvDetail.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                txtKdBuku.Text = dgvDetail.Rows[baris].Cells[2].Value.ToString();
                txtJudulBuku.Text = dgvDetail.Rows[baris].Cells[3].Value.ToString();
                txtpenulis.Text = dgvDetail.Rows[baris].Cells[4].Value.ToString();
                txtPenerbit.Text = dgvDetail.Rows[baris].Cells[5].Value.ToString();
                txtThnPenerbit.Text = dgvDetail.Rows[baris].Cells[6].Value.ToString();
                txtIdPtgs.Text = dgvDetail.Rows[baris].Cells[7].Value.ToString();
                txtJmlhKembali.Text = dgvDetail.Rows[baris].Cells[7].Value.ToString();
                txtKdBuku.Focus();

            }
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                string id_dtl_pinjam = dgvDetail.Rows[baris].Cells[0].Value.ToString();
                string strSQL = "DELETE FROM dtl_kmbli WHERE id_dtl_kembali = " + id_dtl_pinjam;
                detail.eksekusiSQL(strSQL);
                MessageBox.Show(strSQL);
                detail.eksekusiSQL(strSQL);
            }
        }
        private bool kodeLama;
        private void cbStatusBayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbStatusBayar.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && txtIdPtgs.Text.Length > 0)
                {

                    string id_pembayaran,no_pinjam, methode, tunai,status, strSQL;
                    id_pembayaran = txtIdPembayaran.Text;
                    no_pinjam = txtNo_Pinjam.Text;
                    methode = cbMethodeBayar.Text;
                    tunai = txtTunai.Text;
                    status = cbStatusBayar.Text;
                    strSQL = "INSERT INTO pembayaran ( no_pinjam," +
                        "methode,tunai,status) VALUES ('{0}','{1}','{2}','{3}')";
                    strSQL = string.Format(strSQL, no_pinjam, methode, tunai,status);
                    MessageBox.Show(strSQL);
                    detail_bayar.eksekusiSQL(strSQL);
                    //tampil();
                    //hapus();
                }
            }
        }

        private void txtTunai_Validated(object sender, EventArgs e)
        {
            txtKembalian.Text = (int.Parse(txtTunai.Text) - int.Parse(txtDenda.Text)).ToString();
            cbStatusBayar.Focus();
        }

        private void dgvBayar_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvBayar.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                txtNim.Text = dgvBayar.Rows[baris].Cells[3].Value.ToString();
                txtTglPinjam.Text = dgvBayar.Rows[baris].Cells[4].Value.ToString();
                txtTglReal.Text = dgvBayar.Rows[baris].Cells[5].Value.ToString();
                cbMethodeBayar.Text = dgvBayar.Rows[baris].Cells[6].Value.ToString();
                txtTunai.Text = dgvBayar.Rows[baris].Cells[7].Value.ToString();
                txtJumlahDenda.Text = dgvBayar.Rows[baris].Cells[8].Value.ToString();
                txtKembalian.Text = dgvBayar.Rows[baris].Cells[9].Value.ToString();
                cbStatusBayar.Text = dgvBayar.Rows[baris].Cells[10].Value.ToString();
                cbStatusBayar.Focus();

            }
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                string id_dtl_pinjam = dgvBayar.Rows[baris].Cells[0].Value.ToString();
                string strSQL = "DELETE FROM pembayaran WHERE id_pembayaran = " + id_dtl_pinjam;
                //detail.eksekusiSQL(strSQL);
                MessageBox.Show(strSQL);
                detail_bayar.eksekusiSQL(strSQL);
            }
        }

        private void btnPrintDenda_Click(object sender, EventArgs e)
        {
            //FormLaporanDenda denda = new FormLaporanDenda();
            FormFilterDenda denda = new FormFilterDenda();
            denda.Show();
        }
    }
}
