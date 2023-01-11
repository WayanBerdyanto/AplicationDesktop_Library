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
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }

        private void txtTglKembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            String kd1;
           // DateTimePicker kd1;
            //kd1 = txtDate;
            //kd1.Format = DateTimePickerFormat.Custom;
            //kd1.CustomFormat = ("yyyy-MM-dd");
           // kd1= txtTglKembali.Text;
            kd1 = txtDate.Text;
            LaporanPengembalian lp = new LaporanPengembalian();
            MessageBox.Show(kd1);
            lp.isiDataTable(kd1);
            lp.ShowDialog();
            lp.Dispose();
            
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = ("yyyy-MM-dd");
         
        }

      
        private void txtDatePinjam_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
