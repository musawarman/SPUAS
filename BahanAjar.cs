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
    public partial class BahanAjar : Form
    {
        public BahanAjar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection obj = new connection();
                //Eksekusi tb_buku
                String sqlBuku = "insert into tb_buku values(@kode,@namabuku,@penulis,@penelaah,@tahun,@target, getdate())";
                SqlCommand sqlcomm = new SqlCommand(sqlBuku, obj.sqlconn);

                SqlCommand sqlFak = new SqlCommand("insert into tb_lokasiFakultas(kode, jml, tanggalterima, status) values ('" + txtKode.Text.Trim() + "', '" + txtJumlahFak.Text.Trim() + "','" + Convert.ToDateTime(dateTimePicker1.Value.Date.ToLongDateString()) + "','" + cbStatusKelengkapan.Text.Trim() + "') ", obj.sqlconn);

                //Eksekusi Penelaah

                SqlCommand sqlPen = new SqlCommand("insert into tb_lokasipenelaah(kode, jml, tanggalkirim, status) values ('" + txtKode.Text.Trim() + "', '" + txtjmlKirim.Text.Trim() + "', '" + Convert.ToDateTime(dateTimePicker2.Value.Date.ToLongDateString()) + "', '" + cbStatusPenelaah.Text.Trim() + "'  )", obj.sqlconn);

                //Eksekusi Penulis

                SqlCommand sqlPenulis = new SqlCommand("insert into tb_lokasipenulis(kode, jml, mdl, keterangan) values ('" + txtKode.Text.Trim() + "', '" + txtJumlahPenulis.Text.Trim() + "', '" + txtStatusModulPenulis.Text.Trim() + "', '" + cbStatusKeterangan.Text.Trim() + "') ", obj.sqlconn);

                //Eksekusi Pusjian

                SqlCommand sqlPusjian = new SqlCommand("insert into tb_lokasipusjian(kode, jml, tanggalkirim) values ('" + txtKode.Text.Trim() + "', '" + txtSet.Text.Trim() + "', '" + Convert.ToDateTime(dateTimePicker3.Value.Date.ToLongDateString()) + "') ", obj.sqlconn);
                try
                {
                    obj.sqlconn.Open();
                    if (txtKode.Text.Length == 0)
                    {
                        MessageBox.Show("Kode Bahan Ajar tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNamaBahan.Text.Length == 0)
                    {
                        MessageBox.Show("Nama Bahan tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (txtPenulis.Text.Length == 0)
                    //{
                    //    MessageBox.Show("Nama Penulis tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else if (cbStatusPenelaah.SelectedIndex == -1)
                    //{
                    //    MessageBox.Show("Status/Kelengkapan Penelaah tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    else if (cbStatusKeterangan.SelectedIndex == -1)
                    {
                        MessageBox.Show("Status Keterangan Penulis tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cbStatusKelengkapan.SelectedIndex == -1)
                    {
                        MessageBox.Show("Status Kelengkapan Fakultas tidak boleh dikosongkan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Parameter tb_Buku
                        connection con = new connection();
                        con.sqlconn.Open();
                        SqlCommand sqlcek = new SqlCommand("select kode from tb_buku where kode = '" + txtKode.Text.Trim() + "'", con.sqlconn);
                        SqlDataReader dr;
                        dr = sqlcek.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Kode ajar sudah ada pada database, silahkan input kode yang berbeda !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            sqlcomm.Parameters.Add("@kode", SqlDbType.VarChar, 50);
                            sqlcomm.Parameters.Add("@namabuku", SqlDbType.VarChar, 200);
                            sqlcomm.Parameters.Add("@penulis", SqlDbType.VarChar, 200);
                            sqlcomm.Parameters.Add("@penelaah", SqlDbType.VarChar, 200);
                            sqlcomm.Parameters.Add("@tahun", SqlDbType.VarChar, 50);
                            sqlcomm.Parameters.Add("@target", SqlDbType.Int);
                            sqlcomm.Parameters["@kode"].Value = txtKode.Text.Trim();
                            sqlcomm.Parameters["@namabuku"].Value = txtNamaBahan.Text.Trim();
                            sqlcomm.Parameters["@penulis"].Value = txtPenulis.Text.Trim();
                            sqlcomm.Parameters["@penelaah"].Value = txtPenelaah.Text.Trim();
                            sqlcomm.Parameters["@tahun"].Value = txtKisi.Text.Trim();
                            sqlcomm.Parameters["@target"].Value = txtTarget.Text.Trim();
                            sqlcomm.ExecuteNonQuery();


                            sqlPenulis.ExecuteNonQuery();
                            sqlPen.ExecuteNonQuery();
                            sqlFak.ExecuteNonQuery();
                            sqlPusjian.ExecuteNonQuery();

                            //SqlCommand updPenulis = new SqlCommand("update tb_lokasipenulis set jml = '" + txtJumlahPenulis.Text.Trim() + "', mdl = '" + txtStatusModulPenulis.Text.Trim() + "', keterangan = '" + cbStatusKeterangan.SelectedValue.ToString() + "' where kode = '" + txtKode.Text.Trim() + "'", con.sqlconn);
                            //updPenulis.ExecuteNonQuery();

                            DialogResult msg = MessageBox.Show("Data successfully saved into your database, input again?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (msg == DialogResult.Yes)
                            {
                                txtKode.Clear(); txtNamaBahan.Clear(); txtPenulis.Clear(); txtPenelaah.Clear(); txtKisi.Clear();
                                txtTarget.Clear();



                            }
                            else
                            {
                                Referensi fr = new Referensi();
                                fr.Show();
                            }
                        }
                        con.sqlconn.Close();

                    }

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
            catch (Exception er)
            {
                MessageBox.Show("Error : " + er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtKisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtJumlahPenulis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtStatusModulPenulis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtJumlahFak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtjmlKirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BahanAjar_Load(object sender, EventArgs e)
        {

        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            connection con = new connection();
            con.sqlconn.Open();
            SqlCommand sqlcek = new SqlCommand("select kode from tb_buku where kode = '" + txtKode.Text.Trim() + "'", con.sqlconn);
            SqlDataReader dr;
            dr = sqlcek.ExecuteReader();
            if (dr.Read())
            {
                lblStatus.Text = "Kode ajar sudah ada pada database, silahkan input kode yang berbeda !";
                lblStatus.ForeColor = Color.Red;

            }
            else
            {
                lblStatus.Text = "Anda bisa menggunakan Kode Ajar ini.";
                lblStatus.ForeColor = Color.Green;

            }
            con.sqlconn.Close();

        }


      
    }
}
