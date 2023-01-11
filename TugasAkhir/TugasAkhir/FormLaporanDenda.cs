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
    public partial class FormLaporanDenda : Form
    {
        public FormLaporanDenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kd1;
            kd1 = dateTimePicker1.Text;
            FormFilterDenda denda = new FormFilterDenda();
            denda.isiDataTable3(kd1);
            denda.ShowDialog();
            denda.Dispose();
        }

        private void FormLaporanDenda_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = ("yyyy-MM-dd");
        }
    }
}
