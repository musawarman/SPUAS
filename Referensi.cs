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
    public partial class Referensi : Form
    {
        public Referensi()
        {
            InitializeComponent();
        }

           

        public void loaderdata()
        {
            connection obj = new connection();
            
            try
            {
                             
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku order by tgl desc", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable() ;
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }

        public void loadkode()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where kode like RTRIM('"+txtKeyword.Text.Trim()+"') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }
        public void loadnama()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where namabuku like +'%' + ('"+txtKeyword.Text.Trim()+"') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }
        public void loadpenulis()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where penulis like +'%' + ('" + txtKeyword.Text.Trim() + "') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }

        public void loadpenelaah()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where penelaah like +'%' + ('" + txtKeyword.Text.Trim() + "') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }
         
        public void loadtahun()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where tahunkisi like RTRIM('"+txtKeyword.Text.Trim()+"') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }

         public void loadtarget()
        {
            connection obj = new connection();

            try
            {
                obj.sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_buku where target like RTRIM('"+txtKeyword.Text.Trim()+"') + '%';", obj.sqlconn);
                sqlda.SelectCommand.ExecuteNonQuery();
                DataTable dsBuku = new DataTable();
                sqlda.Fill(dsBuku);
                gridBuku.DataSource = dsBuku;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbKategori.SelectedIndex == 0)
            {
                loaderdata();
            }
            else if (cbKategori.SelectedIndex == 1)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    loaderdata();
                }
                else
                {
                    loadkode();

                }
            }
            else if (cbKategori.SelectedIndex == 2)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    loaderdata();
                }
                else
                {
                    loadnama();

                }
            }
            else if (cbKategori.SelectedIndex == 3)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    loaderdata();
                }
                else
                {
                    loadpenulis();

                }
            }
            else if (cbKategori.SelectedIndex == 4)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    loaderdata();
                }
                else
                {
                    loadpenelaah();

                }
            }
            else if (cbKategori.SelectedIndex == 5)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    loaderdata();
                }
                else
                {
                    loadtahun();

                }
            }
            else
            {
                if (txtKeyword.Text.Length == 0)
                {
                    //MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaderdata();
                }
                else
                {
                    loadtarget();

                }
            }
        }

        private void Referensi_Load(object sender, EventArgs e)
        {
            loaderdata();
            
           
        }

        private void Referensi_Click(object sender, EventArgs e)
        {
            loaderdata();
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategori.SelectedIndex == 0)
            {
                loaderdata();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbKategori.SelectedIndex == 0)
            {
                loaderdata();
            }
            else if (cbKategori.SelectedIndex == 1)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadkode();
                
                }
            }
               else if (cbKategori.SelectedIndex == 2)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadnama();
                
                }
            }
            else if (cbKategori.SelectedIndex == 3)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadpenulis();
                
                }
            }
            else if (cbKategori.SelectedIndex == 4)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadpenelaah();
                
                }
            }
             else if (cbKategori.SelectedIndex == 5)
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadtahun();
                
                }
            }
            else
            {
                if (txtKeyword.Text.Length == 0)
                {
                    MessageBox.Show("Masukkan keyword berdasarkan kategori !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    loadtarget();
                
                }
            }
        }

        private void gridBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblkode.Focus();
            
            lblkode.Text = gridBuku.CurrentRow.Cells["kode"].Value.ToString();
            
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection obj = new connection();
            obj.sqlconn.Open();
            try
            {
                SqlCommand sqlupd = new SqlCommand("update tb_buku set namabuku = @namabuku, penulis = @penulis, penelaah = @penelaah, tahunkisi = @tahunkisi, target = @target where kode = '" + lblkode.Text.Trim() + "'", obj.sqlconn);
                sqlupd.Parameters.Add("@namabuku",SqlDbType.VarChar,200);
                sqlupd.Parameters.Add("@penulis", SqlDbType.VarChar, 200);
                sqlupd.Parameters.Add("@penelaah", SqlDbType.VarChar, 200);
                sqlupd.Parameters.Add("@tahunkisi", SqlDbType.VarChar, 50);
                sqlupd.Parameters.Add("@target", SqlDbType.Int);
                
                
                sqlupd.Parameters["@namabuku"].Value = gridBuku.CurrentRow.Cells["namabuku"].Value.ToString();
                sqlupd.Parameters["@penulis"].Value = gridBuku.CurrentRow.Cells["penulis"].Value.ToString();
                sqlupd.Parameters["@penelaah"].Value = gridBuku.CurrentRow.Cells["penelaah"].Value.ToString();

                sqlupd.Parameters["@tahunkisi"].Value = gridBuku.CurrentRow.Cells["tahunkisi"].Value.ToString();
                sqlupd.Parameters["@target"].Value = gridBuku.CurrentRow.Cells["target"].Value.ToString();

                sqlupd.ExecuteNonQuery();
                MessageBox.Show("Data updated Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaderdata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " +ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                obj.sqlconn.Close();
            }
        }

        private void gridBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblkode.Focus();
            lblkode.Text = gridBuku.CurrentRow.Cells["kode"].Value.ToString();
            
        }

     

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (lblkode.Text == "code")
            {
                MessageBox.Show("Anda belum memilih data, klik pada grid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection con = new connection();
                try
                {

                    con.sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("insert into tb_cache(kode) values('" + lblkode.Text.Trim() + "')", con.sqlconn);
                    sqlcomm.ExecuteNonQuery();
                    DetailBahanAjar detail = new DetailBahanAjar();
                    detail.Show();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    con.sqlconn.Close();
                }
            
            }
          
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loaderdata();
        }

        private void gridBuku_DoubleClick(object sender, EventArgs e)
        {
            if (lblkode.Text == "code")
            {
                MessageBox.Show("Anda belum memilih data, klik pada grid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection con = new connection();
                try
                {

                    con.sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("insert into tb_cache(kode) values('" + lblkode.Text.Trim() + "')", con.sqlconn);
                    sqlcomm.ExecuteNonQuery();
                    DetailBahanAjar detail = new DetailBahanAjar();
                    detail.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    con.sqlconn.Close();
                }

            }
        }

              
    }
}


