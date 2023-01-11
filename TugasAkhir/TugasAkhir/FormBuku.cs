using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        KoneksiSQL transaksi = new KoneksiSQL("buku");
        KoneksiSQL detail = new KoneksiSQL("view_detailPinjam");
        KoneksiSQL master = new KoneksiSQL("view_masterPinjam");
        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            FormTabelMahasiswa f_mhs = new FormTabelMahasiswa();
            f_mhs.Show();
            this.Hide();

        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            FormPetugas f_pts = new FormPetugas();
            f_pts.Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        void setelTanggal()
        {
            txtTglPinjam.Format = DateTimePickerFormat.Custom;
            txtTglPinjam.CustomFormat = ("yyyy-MM-dd");
            txtTglKembali.Format = DateTimePickerFormat.Custom;
            txtTglKembali.CustomFormat = ("yyyy-MM-dd");
            txtTglReal.Enabled = false;
            label7.Enabled = false;
        }
        void tampilUserName()
        {
            Form1 f1 = new Form1();
            f1.tampilUserName(label1);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            dgvBuku.DataSource = this.transaksi.getBs();
            transaksi.tampliTanggal(txtDate);
            ikat();
            tampil();
            txtNo_Pinjam.Enabled = false;
            modeSave();
            tampilUserName();
            label1.Text = "HALO USER :[" + Form1.userName + "]";
        }
        void tampil()
        {
            detail.getBs().Filter="no_pinjam="+txtNo_Pinjam.Text;
            lamahari();
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
        void lamahari()
        {


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

            txtKdBuku.DataBindings.Add("Text", detail.getBs(), "kd_buku");
            txtJudulBuku.DataBindings.Add("Text", detail.getBs(), "judul_buku");
            txtpenulis.DataBindings.Add("Text", detail.getBs(), "penulis");
            txtPenerbit.DataBindings.Add("Text", detail.getBs(), "penerbit");
            txtThnPenerbit.DataBindings.Add("Text", detail.getBs(), "thn_penerbit");
            txtJmlhPinjam.DataBindings.Add("Text", detail.getBs(), "jmlh_pinjam");
            txtIdPtgs.DataBindings.Add("Text", detail.getBs(), "id_ptgs");
            setelTanggal();
            dgvDetail.DataSource = detail.getBs();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            FormTabelBuku buku = new FormTabelBuku();
            buku.Show();
            this.Hide();
            
        }
          
        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            txtKdBuku.Clear();
            txtJudulBuku.Clear();
            txtpenulis.Clear();
            txtPenerbit.Clear();
            txtThnPenerbit.Clear();
            txtJmlhPinjam.Clear();
            txtIdPtgs.Clear();
            this.baru = true;
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda ingin menambahkan data  ?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string tgl = DateTime.Now.ToString();
                string strSQL = "INSERT INTO pinjam (tgl_pinjam) VALUES('" + tgl + "')";
                string nomorNotaBaru = master.eksekusiSQL_getID(strSQL);
                int posisi = master.getBs().Find("no_pinjam", nomorNotaBaru);
                master.getBs().Position = posisi;
                tampil();
                modeEdit();
            }
            else
            {
                MessageBox.Show("Batal Ditambah");
            }
        }
        public bool baru;
        private string kodeLama;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
            this.baru = false;
            this.kodeLama = txtKdBuku.Text;
            txtNim.ReadOnly = false;
            txtNim.Enabled = true;
            txtKdBuku.Enabled = true;
            txtKdBuku.Focus();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
            if (txtKdBuku.CanUndo == true)
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
        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveFirst();
            tampil();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            tampil();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            tampil();
        }
        public void modeEdit()
        {
            this.baru = false;
            txtNim.Focus();
            txtNim.Enabled = true;
            txtKdBuku.Enabled = true;
            txtNim.ReadOnly = false;
            txtJudulBuku.Enabled = true;
            txtPenerbit.Enabled = true;
            txtpenulis.Enabled = true;
            txtThnPenerbit.Enabled = true;
            txtJmlhPinjam.Enabled = true;
            txtIdPtgs.Enabled = true;
            txtTglPinjam.Enabled = true;
            txtTglKembali.Enabled = true;
            txtLamaPeminjaman.Enabled = true;

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
        }

        private void txtKdBuku_Validated(object sender, EventArgs e)
        {
            KoneksiSQL buku = new KoneksiSQL("buku");
            if (txtKdBuku.Text.Length > 0)
            {

                int barisDitemukan = buku.getBs().Find("kd_buku", txtKdBuku.Text);
                if (barisDitemukan >= 0)
                {
                    buku.getBs().Position = barisDitemukan;
                    txtJudulBuku.Text = ((DataRowView)buku.getBs().Current).Row["judul_buku"].ToString();
                    txtpenulis.Text = ((DataRowView)buku.getBs().Current).Row["penulis"].ToString();
                    txtPenerbit.Text = ((DataRowView)buku.getBs().Current).Row["penerbit"].ToString();
                    txtThnPenerbit.Text = ((DataRowView)buku.getBs().Current).Row["thn_penerbit"].ToString();
                }
                else
                {
                    MessageBox.Show("Kode Buku : " + txtKdBuku.Text + "Tidak Ditemukan");
                    hapus();
                }
            }
        }

        private void txtKdBuku_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == 191)
            //{
                //ISI FORM CARI

            //}
            if (txtKdBuku.Text.Length == 3)
            {
                txtJmlhPinjam.Focus();
            }
        }

        private void txtJmlhPinjam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJmlhPinjam_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtJmlhPinjam.Text.Length>0)
            {
                if(e.KeyData==Keys.Enter && int.Parse(txtJmlhPinjam.Text) > 0)
                {
                    txtIdPtgs.Focus();
                }
            }
        }

        private void txtIdPtgs_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (txtIdPtgs.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && txtIdPtgs.Text.Length > 0)
                {
                    string no_pinjam, kode_buku, jmlh_pinjam, id_ptgs, strSQL;
                    no_pinjam = txtNo_Pinjam.Text;
                    kode_buku = txtKdBuku.Text;
                    id_ptgs = txtIdPtgs.Text;
                    jmlh_pinjam = txtJmlhPinjam.Text;
                    strSQL = "INSERT INTO dtl_pinjam (no_pinjam, kd_buku," +
                        "id_ptgs,jmlh_pinjam) VALUES ('{0}','{1}','{2}','{3}')";
                    strSQL = string.Format(strSQL, no_pinjam, kode_buku, id_ptgs, jmlh_pinjam);
                    MessageBox.Show(strSQL);
                    detail.eksekusiSQL(strSQL);
                    tampil();
                    hapus();
                }
            }
        }

        private void txtJmlhPinjam_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtJmlhPinjam.Text.Length !=0)
            {
                txtIdPtgs.Focus();
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
                txtJmlhPinjam.Text = dgvDetail.Rows[baris].Cells[7].Value.ToString();
                txtIdPtgs.Text = dgvDetail.Rows[baris].Cells[8].Value.ToString();
                txtKdBuku.Focus();

            }
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                string id_dtl_pinjam = dgvDetail.Rows[baris].Cells[0].Value.ToString();
                string strSQL = "DELETE FROM dtl_pinjam WHERE id_dtl_pinjam = " + id_dtl_pinjam;
                detail.eksekusiSQL(strSQL);
                MessageBox.Show(strSQL);
                detail.eksekusiSQL(strSQL);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("Hapus No Pinjam. " + txtNo_Pinjam.Text + "?",
               "Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(jawab== DialogResult.Yes)
            {
                string no_pinjam = txtNo_Pinjam.Text;
                string strSQL = "DELETE FROM dtl_pinjam WHERE no_pinjam = '"+ no_pinjam +"'";
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

        private void txtNim_Validated(object sender, EventArgs e)
        {
            if (txtNim.Text.Length == 0 || txtNim.Text.Length == 8)
            {
                string strSQL, noNotaSekarang = txtNo_Pinjam.Text;
                KoneksiSQL coba = new KoneksiSQL("mahasiswa");
                int barisDitemukan = coba.getBs().Find("nim", txtNim.Text);
                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE pinjam SET nim ='{0}' WHERE no_pinjam='{1}'";
                    strSQL = String.Format(strSQL, txtNim.Text, noNotaSekarang);
                    MessageBox.Show("yesss update");
                    txtKdBuku.Focus();
                    tampil();
                }
                else
                {
                    MessageBox.Show("kode  : " + txtNim.Text + "tidak ditemukan");
                    strSQL = "UPDATE pinjam set nim = NULL WHERE no_pinjam ='{0}'";
                    strSQL = String.Format(strSQL, noNotaSekarang);
                    if (txtNim.Text.Length != 0)
                    {
                        txtNim.Focus();
                    }
                    else
                    {
                        txtKdBuku.Focus();
                        txtNim.Text = "";
                    }
                }

                master.eksekusiSQL(strSQL);
                barisDitemukan = master.getBs().Find("no_pinjam", noNotaSekarang);
                master.getBs().Position = barisDitemukan;
                tampil();
            }
        }

        private void txtNim_KeyUp_1(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 191)
            {
                FormCariMahasiswa pt = new FormCariMahasiswa();
                pt.ShowDialog();
                txtNim.Text = pt.cariMhs;
                pt.Dispose();

            }
            if (txtNim.Text.Length > 5 || e.KeyCode == Keys.Enter)
            {
                txtIdPtgs.Focus();
                
            }
        }

        private void txtKdBuku_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dgvBuku.Rows[ind];
            txtKdBuku.Text = selectedRows.Cells[0].Value.ToString();
            txtJudulBuku.Text = selectedRows.Cells[1].Value.ToString();
            txtpenulis.Text = selectedRows.Cells[2].Value.ToString();
            txtPenerbit.Text = selectedRows.Cells[3].Value.ToString();
            txtThnPenerbit.Text = selectedRows.Cells[4].Value.ToString();
        }
        private void txtTglKembali_Validated(object sender, EventArgs e)
        {
            if (txtTglKembali.Text.Length == 0 || txtTglKembali.Text.Length >6)
            {
                string strSQL, noNotaSekarang = txtNo_Pinjam.Text;
                KoneksiSQL coba = new KoneksiSQL("pinjam");
                int barisDitemukan = coba.getBs().Find("no_pinjam", txtNo_Pinjam.Text);
                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE pinjam SET tgl_kembali ='{0}' WHERE no_pinjam='{1}'";
                    strSQL = String.Format(strSQL, txtTglKembali.Text, noNotaSekarang);
                    MessageBox.Show("yesss update");
                    txtKdBuku.Focus();
                    tampil();
                    master.eksekusiSQL(strSQL);
                    barisDitemukan = master.getBs().Find("no_pinjam", noNotaSekarang);
                    master.getBs().Position = barisDitemukan;
                    tampil();
                    txtIdPtgs.Focus();
                }                
            }
        }
        private void modeCari()
        {
            btnClose.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnLast.Enabled = false;
            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

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
            for (int n = 0; n < master.getBs().Count; n++)
            {
                notaPinjam = ((DataRowView)master.getBs().Current).Row["no_pinjam"].ToString();
                cbNoPinjam.Items.Add(notaPinjam);
                master.getBs().MoveNext();
            }
            int posisi = master.getBs().Find("no_pinjam", notaPinjamSekarang);
            master.getBs().Position = posisi;
            cbNoPinjam.Focus();
        }

        private void cbNoPinjam_SelectedValueChanged(object sender, EventArgs e)
        {
            master.getBs().Position = master.getBs().Find("no_pinjam", cbNoPinjam.Text);
            tampil();
            cbNoPinjam.Visible = false;
            modeSave();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Pengembalian")
            {
                FormHome2 fh = new FormHome2();
                fh.Show();
                this.Hide();
            }
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            transaksi.getBs().Filter = "judul_buku LIKE '%" +
                textBox1.Text + "%'";
        }

        private void txtIdPtgs_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 191)
            {
                FormCariPetugas pt = new FormCariPetugas();
                pt.ShowDialog();
                txtIdPtgs.Text = pt.IDPetugas;
                pt.Dispose();

            }
            if( txtIdPtgs.Text.Length == 3 || e.KeyCode == Keys.Enter)
            {
                txtIdPtgs.Focus();
            }
            //modeEdit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormFilterPinjam lp = new FormFilterPinjam();
            lp.Show();
        }

        private void txtNim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                FormTabelMahasiswa fh = new FormTabelMahasiswa();
                fh.Show();
            }
        }
    }
    
}
