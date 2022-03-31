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
    public partial class DetailBahanAjar : Form
    {
        public DetailBahanAjar()
        {
            InitializeComponent();
        }

        private void DetailBahanAjar_Load(object sender, EventArgs e)
        {
            connection con = new connection();
            try
            {

                con.sqlconn.Open();
                SqlDataAdapter sqlcomm = new SqlDataAdapter("select top 1 kode from tb_cache order by tgl desc", con.sqlconn);
                sqlcomm.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlcomm.Fill(dt);
                txtKode.DataBindings.Add("Text", dt, "kode");
                
                
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

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            connection con = new connection();
            try
            {

                con.sqlconn.Open();
                SqlDataAdapter sqlcomm = new SqlDataAdapter("select * from tb_buku where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlcomm.SelectCommand.ExecuteNonQuery();
                DataTable dtBuku = new DataTable();
                sqlcomm.Fill(dtBuku);
                
                SqlDataAdapter sqlP = new SqlDataAdapter("select * from tb_lokasipenulis where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlP.SelectCommand.ExecuteNonQuery();
                DataTable dtPenulis = new DataTable();
                sqlP.Fill(dtPenulis);

                SqlDataAdapter sqlF = new SqlDataAdapter("select * from tb_lokasifakultas where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlF.SelectCommand.ExecuteNonQuery();
                DataTable dtF = new DataTable();
                sqlF.Fill(dtF);

                SqlDataAdapter sqlPen = new SqlDataAdapter("select * from tb_lokasipenelaah where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPen.SelectCommand.ExecuteNonQuery();
                DataTable dtPen = new DataTable();
                sqlPen.Fill(dtPen);

                SqlDataAdapter sqlPus = new SqlDataAdapter("select * from tb_lokasipusjian where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPus.SelectCommand.ExecuteNonQuery();
                DataTable dtPus = new DataTable();
                sqlPus.Fill(dtPus);

                //penulis
                txtKode.DataBindings.Add("Text", dtBuku, "kode");
                txtPenulis.DataBindings.Add("Text", dtBuku, "penulis");
                txtNamaBahan.DataBindings.Add("Text", dtBuku, "namabuku");
                txtPenelaah.DataBindings.Add("Text", dtBuku, "penelaah");
                txtKisi.DataBindings.Add("Text", dtBuku, "tahunkisi");
                txtTarget.DataBindings.Add("Text", dtBuku, "target");
                //penulis
                txtJumlahPenulis.DataBindings.Add("Text", dtPenulis, "jml");
                txtStatusModulPenulis.DataBindings.Add("Text", dtPenulis, "mdl");
                cbStatusKeterangan.DataBindings.Add("Text", dtPenulis, "keterangan");
                //fakultas
                txtJumlahFak.DataBindings.Add("Text", dtF, "jml");
                dateTimePicker1.DataBindings.Add("Text", dtF, "tanggalterima");
                cbStatusKelengkapan.DataBindings.Add("Text", dtF, "status");

                //penelaah
                txtjmlKirim .DataBindings.Add("Text", dtPen, "jml");
                dateTimePicker2.DataBindings.Add("Text", dtPen, "tanggalkirim");
                cbStatusPenelaah.DataBindings.Add("Text", dtPen, "status");

                //Pusjian
                txtSet.DataBindings.Add("Text", dtPus, "jml");
                dateTimePicker3.DataBindings.Add("Text", dtPus, "tanggalkirim");


                

                


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

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            try
            {
                con.sqlconn.Open();
                SqlCommand sqlPenulis = new SqlCommand("update tb_buku set namabuku = '"+txtNamaBahan.Text.Trim()+"', penulis = '"+txtPenulis.Text.Trim()+"', penelaah = '"+txtPenelaah.Text.Trim()+"', tahunkisi = '"+txtKisi.Text.Trim()+"', target = '"+txtTarget.Text.Trim()+"' where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPenulis.ExecuteNonQuery();

                SqlCommand sqllPenulis = new SqlCommand("update tb_lokasipenulis set jml = '" + txtJumlahPenulis.Text.Trim() + "', mdl = '" + txtStatusModulPenulis.Text.Trim() + "', keterangan = '" + cbStatusKeterangan.Text + "' where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqllPenulis.ExecuteNonQuery();

                SqlCommand sqlFak = new SqlCommand("update tb_lokasifakultas set jml = '" + txtJumlahFak.Text.Trim() + "', tanggalterima = '" + Convert.ToDateTime(dateTimePicker1.Value.Date.ToLongDateString()) + "', status = '" + cbStatusKelengkapan.Text + "' where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlFak.ExecuteNonQuery();

                SqlCommand sqlPenelaah = new SqlCommand("update tb_lokasipenelaah set jml = '" + txtjmlKirim.Text.Trim() + "', tanggalkirim = '" + Convert.ToDateTime(dateTimePicker2.Value.Date.ToLongDateString()) + "', status = '" + cbStatusPenelaah.Text + "' where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPenelaah.ExecuteNonQuery();

                SqlCommand sqlPusjian = new SqlCommand("update tb_lokasipusjian set jml = '" + txtSet.Text.Trim() + "', tanggalkirim = '" + Convert.ToDateTime(dateTimePicker3.Value.Date.ToLongDateString()) + "' where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPusjian.ExecuteNonQuery();

                MessageBox.Show("Data updated Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);




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

        private void DetailBahanAjar_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection con = new connection();
            con.sqlconn.Open();
            SqlCommand del = new SqlCommand("delete from tb_cache", con.sqlconn);

            del.ExecuteNonQuery();
            con.sqlconn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            try
            {
                con.sqlconn.Open();
                SqlCommand sqlPenulis = new SqlCommand("delete from tb_lokasipenulis where kode = '" + txtKode.Text + "'", con.sqlconn);
                SqlCommand sqlPenelaah = new SqlCommand("delete from tb_lokasipenelaah where kode = '" + txtKode.Text + "'", con.sqlconn);
                SqlCommand sqlfakultas = new SqlCommand("delete from tb_lokasifakultas where kode = '" + txtKode.Text + "'", con.sqlconn);
                SqlCommand sqlPusjian = new SqlCommand("delete from tb_lokasipusjian where kode = '" + txtKode.Text + "'", con.sqlconn);
                SqlCommand sqlbuku = new SqlCommand("delete from tb_buku where kode = '" + txtKode.Text + "'", con.sqlconn);
                sqlPenelaah.ExecuteNonQuery();
                sqlPenulis.ExecuteNonQuery();
                sqlfakultas.ExecuteNonQuery();
                sqlPusjian.ExecuteNonQuery();
                sqlbuku.ExecuteNonQuery();
                MessageBox.Show("Data deleted Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Referensi refr = new Referensi();
                refr.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.sqlconn.Close();
            }
        }
    }
}
