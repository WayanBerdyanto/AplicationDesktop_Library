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
    public partial class FormCariMahasiswa : Form
    {
        public FormCariMahasiswa()
        {
            InitializeComponent();
        }
        KoneksiSQL mhs = new KoneksiSQL("mahasiswa");
        private void FormCariMahasiswa_Load(object sender, EventArgs e)
        {
            dgvMhs.DataSource = mhs.getBs();
        }

        private void txtCariMhs_KeyUp(object sender, KeyEventArgs e)
        {
            mhs.getBs().Filter = "nama_mhs LIKE '%" +
                txtCariMhs.Text + "%'";
        }

        private void txtCariMhs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                dgvMhs.Focus();
        }
        private string _nama_mhs;

        public String cariMhs
        {
            get
            {
                return _nama_mhs;
            }
        }

        private void dgvMhs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int brs = dgvMhs.SelectedCells[0].RowIndex;
                _nama_mhs = dgvMhs.Rows[brs].Cells[0].Value.ToString();
                this.Visible = false;
            }
        }

        private void FormCariMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            int brs = dgvMhs.SelectedCells[0].RowIndex;
            _nama_mhs = dgvMhs.Rows[brs].Cells[0].Value.ToString();
        }
    }
}
