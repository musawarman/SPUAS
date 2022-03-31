using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Sql;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace SPUAS
{
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }
        public void getserver()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            
            foreach (System.Data.DataRow row in table.Rows)
            {
                if (row["ServerName"] != DBNull.Value && Environment.MachineName.Equals(row["ServerName"].ToString()))
                {
                    string item = string.Empty;
                    item = row["ServerName"].ToString();
                    if (row["InstanceName"] != DBNull.Value || !string.IsNullOrEmpty(Convert.ToString(row["InstanceName"]).Trim()))
                    {
                        item += @"\" + Convert.ToString(row["InstanceName"]).Trim();
                    }
                    cmbServers.Items.Add(item);
                }
            }
        }



              
        public static String serv = "localhost", database = "db_spuas";
        public SqlConnection sqlconn = new SqlConnection("Data Source = " + serv + "; Initial Catalog = " + database + "; UID = sa; password = userjuga");
        

        private void connection_Load(object sender, EventArgs e)
        {
            getserver();
              
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cmbServers.SelectedText.Length == 0) && (cmbDatabase.SelectedText.Length == 0))
            {
                MessageBox.Show("Database tidak tersedia dalam sistem Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                serv = cmbServers.SelectedText;
                database = cmbDatabase.SelectedText;
                Login frm = new Login();
                frm.Show();

            }
            
        }

        private void cmbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatabase.Items.Clear();
            if (cmbServers.SelectedIndex != -1)
            {
                string serverName = cmbServers.SelectedText;
                Server server = new Server(serverName);
                try
                {
                    foreach (Database database in server.Databases)
                    {
                        cmbDatabase.Items.Add(database.Name);
                    }
                }
                catch (Exception ex)
                {
                    string exception = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("No database server selected");
            }
            
        }
    }
}
