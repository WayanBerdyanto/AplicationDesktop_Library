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
    public partial class FormFilterPinjam : Form
    {
        public FormFilterPinjam()
        {
            InitializeComponent();
        }

        private void btnCari1_Click(object sender, EventArgs e)
        {
            String kd1;
            // DateTimePicker kd1;
            //kd1 = txtDate;
            //kd1.Format = DateTimePickerFormat.Custom;
            //kd1.CustomFormat = ("yyyy-MM-dd");
            // kd1= txtTglKembali.Text;
            kd1 = txtDatePinjam.Text;
            FormPinjam1 lp = new FormPinjam1();
            MessageBox.Show(kd1);
            lp.isiDataTable3(kd1);
            lp.ShowDialog();
            lp.Dispose();
        }

        private void FormFilterPinjam_Load(object sender, EventArgs e)
        {
            txtDatePinjam.Format = DateTimePickerFormat.Custom;
            txtDatePinjam.CustomFormat = ("yyyy-MM-dd");
        }
    }
}
