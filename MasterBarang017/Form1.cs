using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MasterBarang017
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5VJ7M3BC;Initial Catalog=Quiz;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id_barang = int.Parse(txtID.Text);
            string nama_barang = txtNamaBarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            string nama_supplier = txtNamaSupplier.Text;

            var data = new tbl_barang
            {
                id_barang = id_barang,
                nama_barang = nama_barang,
                harga = harga,
                stok = stok,
                nama_supplier = nama_supplier
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            LoadData();
            txtNamaSupplier.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.quizDataSet.tbl_barang);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (ID as int)), 0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            LoadData();
        }

        void LoadData()
        {
            var st = from tb in db.tbl_barangs select tb;
            dt.DataSource = st;
        }
    }
}
