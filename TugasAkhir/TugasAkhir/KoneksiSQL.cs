using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    internal class KoneksiSQL
    {
        private string namatable;
        private DataTable dt;
        private BindingSource bs;
        public SqlConnection conn;
        public SqlCommand cmd;

        public KoneksiSQL(string namatable)
        {
            this.namatable = namatable;
            this.conn = new SqlConnection();
            this.cmd = new SqlCommand();
            this.dt = new DataTable();
            this.bs = new BindingSource();
            this.isiDataTabel();
            this.bs.DataSource = this.dt;


        }
        
        public void isiDataTabel()
        {

            SqlConnectionStringBuilder str = new SqlConnectionStringBuilder();
            str.DataSource = ".\\SQLEXPRESS";
            str.InitialCatalog = "tugas_akhir_perpustakaan";
            str.IntegratedSecurity = true;
            conn = new SqlConnection(str.ToString());
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM "+this.namatable, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;      
            da.Fill(this.dt);
            this.bs.DataSource = dt;
            da.Dispose();
            conn.Close();
        }
        public void eksekusiSQL(string strSql)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "tugas_akhir_perpustakaan";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM " + this.namatable, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(this.dt);
            con.Close();
        }
        public String eksekusiSQL_getID(string strSql)//<--
        {
            string nomorNotaBaru = "";//<--
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "tugas_akhir_perpustakaan";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            cmd = new SqlCommand(strSql, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT @@identity", con); //<--
            SqlDataReader dr = cmd.ExecuteReader(); //<--
            dr.Read();//<--
            nomorNotaBaru = dr.GetValue(0).ToString();//<--
            con.Close();
            this.isiDataTabel();
            return nomorNotaBaru;//<--
        }
        public BindingSource getBs()
        {
            return this.bs;
        }
        public void tampliTanggal(TextBox tb)
        {
            tb.Text = DateTime.Now.ToString("yyyy-MM-dd  h:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }
        public DataTable getDt()
        {
            return this.dt;
        }
    }
}
