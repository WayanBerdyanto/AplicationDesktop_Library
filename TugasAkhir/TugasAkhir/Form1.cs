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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string userName = "";
        private void Form1_Load(object sender, EventArgs e)
        {
              
        }
        public void lihatPassword()
        {
            txtPassword.UseSystemPasswordChar = true;
            tutupPass.Visible = true;
            lihatPass.Visible = false;
        }
        public void tutupPassword()
        {
            txtPassword.UseSystemPasswordChar = false;
            lihatPass.Visible = true;
            tutupPass.Visible = false;
        }

        private void tutupPass_Click(object sender, EventArgs e)
        {
            tutupPassword();
        }

        private void lihatPass_Click(object sender, EventArgs e)
        {
            lihatPassword();
        }
        public void tampilUserName(Label lbl)
        {

            lbl.Text = "Hi User" + txtUserName.Text;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Anda Bukan User, Silahkan Isi Data Dengan Benar");
            }
            else if (txtUserName.Text.Length >0 || txtPassword.Text.Length >0)
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = tugas_akhir_perpustakaan; integrated security = true";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from login_user where username = '" + txtUserName.Text + "' and passwordUser = '" + txtPassword.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    FormHome fh = new FormHome();
                    MessageBox.Show("Anda Login Sebagai " + dr["username"], "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userName = (dr["username"].ToString());
                    fh.Show();
                    this.Hide();
                }
                else if (dr.HasRows == false)
                {
                    MessageBox.Show("Data Anda Salah");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
