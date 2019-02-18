using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Program1
{
    public partial class historyForm : Form
    {
        public historyForm()
        {
            InitializeComponent();
        }

        public class ConnectionClass
        {
            
        }

        private void historyForm_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\program1.mdb");
            conn.Open();
            OleDbDataAdapter dta = new OleDbDataAdapter(@"SELECT product.productId, product.tanggal, product.namaKonsumen, product.namaBarang, product.serialNomor, product.kelengkapan, product.kerusakan, product.status, price.biayaService, price.hargaSparePart, price.sparePart, price.total FROM price, product", conn);

            DataTable dt = new DataTable();
            dta.Fill(dt);
            dataGridView1.DataSource = dt;
        }

            


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //    if (string.IsNullOrEmpty(textBoxSearch.Text))
            //        dataGridView1.DataSource = productBindingSource;
            //    
            //    else
            //{

            //var query = from o in program1DataSet.product
            //where o.namaKonsumen.Contains(textBoxSearch.Text) || o.namaBarang == textBoxSearch.Text || o.serialNomor.Contains(textBoxSearch.Text)
            //select o;
            //dataGridView1.DataSource = query.ToList();

            //}
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //if (string.IsNullOrEmpty(textBoxSearch.Text))
            //dataGridView1.DataSource = productBindingSource;
            //    else
            //{
            //var query = from o in program1DataSet.product
            //where o.namaKonsumen.Contains(textBoxSearch.Text) || o.namaBarang == textBoxSearch.Text || o.serialNomor.Contains(textBoxSearch.Text)
            //select o;
            //dataGridView1.DataSource = query.ToList();
            //}
            //}

    }

    }
}
