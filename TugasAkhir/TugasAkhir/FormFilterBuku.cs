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
    public partial class FormFilterBuku : Form
    {
        public FormFilterBuku()
        {
            InitializeComponent();
        }

        private void btnCari3_Click(object sender, EventArgs e)
        {
            String kd1;
            // DateTimePicker kd1;
            //kd1 = txtDate;
            //kd1.Format = DateTimePickerFormat.Custom;
            //kd1.CustomFormat = ("yyyy-MM-dd");
            // kd1= txtTglKembali.Text;
            kd1 = textBox3.Text;
            FormBuku1 lp = new FormBuku1();
            MessageBox.Show(kd1);
            lp.isiDataTable2(kd1);
            lp.ShowDialog();
            lp.Dispose();
        }
    }
}
