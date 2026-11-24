using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM2_DESKTOP_XII_0081980338_MUHAMAD_RAFAEL
{
    public partial class Form1 : Form
    {
        string koneksi = "server=localhost;username=root;password=;database=db_apotek_gudang";
        public Form1()
        {
            InitializeComponent();
        }

        private void kode_barang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tampildata();
            
        }
        private void loaddata()
        {

            MySqlConnection con = new MySqlConnection(koneksi);
            con.Open();
            string query = "SELECT * FROM tb_suplemen";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow Row = dataGridView2.Rows[e.RowIndex];
                kode_barang.Text = Row.Cells[1].Value?.ToString();
                nama_barang.Text = Row.Cells[2].Value?.ToString();
                stok.Text = Row.Cells[3].Value?.ToString();
                satuan.Text = Row.Cells[4].Value?.ToString();
                harga_satuan.Text = Row.Cells[5].Value?.ToString();
                batas_minimun.Text = Row.Cells[6].Value?.ToString();
                
            }
        }
        private void tampildata()
        {
            MySqlConnection con = new MySqlConnection(koneksi);
            con.Open();
            string query = "SELECT * FROM tb_suplemen";
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void btntambah_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection(koneksi);
            
            try
            {
                con.Open();
                string query = "INSERT INTO tb_suplemen SET ode_barang, nama_barang, kategori, stok, satuan, harga_satuan, batas_minimum WHERE kode_barang = @kode_barang ";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                dataGridView2 = new DataGridView();
                cmd.Parameters.AddWithValue("@kode_barang", kode_barang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", nama_barang.Text);
                cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                cmd.Parameters.AddWithValue("@stok", stok.Text);
                cmd.Parameters.AddWithValue("@satuan", satuan.Text);
                cmd.Parameters.AddWithValue("@harga_satuan", harga_satuan.Text);
                cmd.Parameters.AddWithValue("@batas_minimum", batas_minimun.Text);
                cmd.ExecuteNonQuery();
                kode_barang.Clear();
                nama_barang.Clear();
                stok.Clear();
                satuan.Clear();
                harga_satuan.Clear();
                batas_minimun.Clear();

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("data gagal ditambahkan");
            }

        }

        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(koneksi);
            MySqlCommand komando = new MySqlCommand(koneksi, con);
            string query = "select @kategori from tb_suplemen";
            MySqlDataReader data = komando.ExecuteReader();
            MySqlDataAdapter adapter = new MySqlDataAdapter(komando);
            komando.CommandText = query;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(koneksi);
            con.Open();
            try
            {
                string query = "DEELTE @kode_barang FORM tb_suplemen";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                
                cmd.Parameters.RemoveAt("@kode_barang");
                cmd.Parameters.RemoveAt("@nama_barang");
                cmd.Parameters.RemoveAt("@kategori");
                cmd.Parameters.RemoveAt("@stok");
                cmd.Parameters.RemoveAt("@satuan");
                cmd.Parameters.RemoveAt("@harga_satuan");
                cmd.Parameters.RemoveAt("@batas_minimum");
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di hapus");
                tampildata();
                kode_barang.Clear();
                nama_barang.Clear();
                stok.Clear();
                satuan.Clear();
                harga_satuan.Clear();
                batas_minimun.Clear();

            }
            catch (Exception) 
            {
                MessageBox.Show("data gagaldihapus");
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(koneksi);

            try
            {
                con.Open();
                string query = "UPDATE tb_suplemen SET kode_barang, nama_barang, kategori, stok, satuan, harga_satuan, batas_minimum WHERE kode_barang = @kode_barang ";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                dataGridView2 = new DataGridView();
                cmd.Parameters.AddWithValue("@kode_barang", kode_barang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", nama_barang.Text);
                cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                cmd.Parameters.AddWithValue("@stok", stok.Text);
                cmd.Parameters.AddWithValue("@satuan", satuan.Text);
                cmd.Parameters.AddWithValue("@harga_satuan", harga_satuan.Text);
                cmd.Parameters.AddWithValue("@batas_minimum", batas_minimun.Text);
                cmd.ExecuteNonQuery();
                kode_barang.Clear();
                nama_barang.Clear();
                stok.Clear();
                satuan.Clear();
                harga_satuan.Clear();
                batas_minimun.Clear();

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("data gagal ditambahkan");
            }
        }
    }
}
