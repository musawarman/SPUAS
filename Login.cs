using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPUAS
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            
            try
            {
               
                con.sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand("Select username, password from tbuser where username = '" + txtusername.Text.Trim() + "' and password = '" + txtpassword.Text + "'", con.sqlconn);
                SqlDataReader dr;
                dr = sqlcomm.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Selamat Datang, " + txtusername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SystemMenu frm = new SystemMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password tidak cocok, kontak Administrator Anda", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
            finally
            {
                con.sqlconn.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
