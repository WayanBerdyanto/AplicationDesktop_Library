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
    public partial class FormCariPetugas : Form
    {
        KoneksiSQL cr_ptgs = new KoneksiSQL("petugas");
        public FormCariPetugas()
        {
            InitializeComponent();
        }

        private void txtidpetugas_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCariPetugas_Load(object sender, EventArgs e)
        {
            dgvCariPetugas.DataSource = cr_ptgs.getBs();
        }

        private void txtidpetugas_KeyUp(object sender, KeyEventArgs e)
        {
            cr_ptgs.getBs().Filter = "id_ptgs LIKE '%" +
                txtidpetugas.Text + "%'";
        }

        private void txtidpetugas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                dgvCariPetugas.Focus();
        }

        private String _idPetugas;
        public String IDPetugas
        {
            get { return _idPetugas;}
        }

        private void dgvCariPetugas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int brs = dgvCariPetugas.SelectedCells[0].RowIndex;
                _idPetugas = dgvCariPetugas.Rows[brs].Cells[0].Value.ToString();
                this.Visible= false;
            }
        }

        private void FormCariPetugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            int brs = dgvCariPetugas.SelectedCells[0].RowIndex;
            _idPetugas = dgvCariPetugas.Rows[brs].Cells[0].Value.ToString();
        }


    }
}
