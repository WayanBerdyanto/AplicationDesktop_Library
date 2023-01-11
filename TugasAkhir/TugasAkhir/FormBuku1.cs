using Microsoft.Reporting.WinForms;
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
    public partial class FormBuku1 : Form
    {
        public FormBuku1()
        {
            InitializeComponent();
        }

        private void FormBuku1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugas_akhir_perpustakaanDataSet1.buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.tugas_akhir_perpustakaanDataSet1.buku);

            this.reportViewer1.RefreshReport();
        }
        public void isiDataTable2(String kd1)
        {

            tugas_akhir_perpustakaanDataSet1 a = new tugas_akhir_perpustakaanDataSet1();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "tugas_akhir_perpustakaan";
            strCon.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(strCon.ToString());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM transaksi", conn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from buku where judul_buku LIKE '" + kd1 + '%' + "'", conn);
            //conn.Open();
            //cmd = new SqlCommand("SELECT * FROM transaksi"+ conn);         
            //da.SelectCommand = cmd;
            da.Fill(a, a.Tables[1].TableName);
            ReportDataSource rds = new ReportDataSource("DataSet1", a.Tables[1]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
