using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;

namespace Program1
{
    public partial class historyForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\program1.mdb;Persist Security Info=False;");
        public historyForm()
        {
            InitializeComponent();
        }
        
        private void historyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'program1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.program1DataSet.product);
            string query = "select * from product";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        if(e.KeyChar == (char)13)
            {

            
            if (string.IsNullOrEmpty(textBoxSearch.Text))
                dataGridView1.DataSource = productBindingSource;
            else
            {
                var query = from o in this.program1DataSet.product
                            where o.namaKonsumen.Contains(textBoxSearch.Text) || o.namaBarang == textBoxSearch.Text ||o.kerusakan.Contains(textBoxSearch.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
            }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
                dataGridView1.DataSource = productBindingSource;
            else
            {
                var query = from o in this.program1DataSet.product
                            where o.namaKonsumen.Contains(textBoxSearch.Text) || o.namaBarang == textBoxSearch.Text || o.kerusakan.Contains(textBoxSearch.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
