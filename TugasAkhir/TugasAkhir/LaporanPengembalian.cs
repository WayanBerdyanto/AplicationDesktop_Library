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
    public partial class LaporanPengembalian : Form
    {
        public LaporanPengembalian()
        {
            InitializeComponent();
        }

        private void LaporanPengembalian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugas_akhir_perpustakaanDataSet1.view_master' table. You can move, or remove it, as needed.
            this.view_masterTableAdapter.Fill(this.tugas_akhir_perpustakaanDataSet1.view_master);
            // TODO: This line of code loads data into the 'tugas_akhir_perpustakaanDataSet1.viev_detailKembali' table. You can move, or remove it, as needed.
           // this.viev_detailKembaliTableAdapter.Fill(this.tugas_akhir_perpustakaanDataSet1.viev_detailKembali);

            this.reportViewer1.RefreshReport();

        }
        public void isiDataTable(String kd1)
        {
          //  kd1.Format = DateTimePickerFormat.Custom;
            //kd1.CustomFormat = ("yyyy-MM-dd");
            tugas_akhir_perpustakaanDataSet1 a = new tugas_akhir_perpustakaanDataSet1();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "tugas_akhir_perpustakaan";
            strCon.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection(strCon.ToString());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM transaksi", conn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from view_master where tgl_kembali = '" + kd1+ "'", conn);
            conn.Open();
            //cmd = new SqlCommand("SELECT * FROM transaksi"+ conn);         
            //da.SelectCommand = cmd;
            da.Fill(a, a.Tables[3].TableName);
            ReportDataSource rds = new ReportDataSource("DataSet2", a.Tables[3]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
