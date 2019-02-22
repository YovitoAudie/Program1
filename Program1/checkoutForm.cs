using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace Program1
{
    public partial class checkoutForm : Form
    {
        public checkoutForm()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\program1.mdb;Persist Security Info=False;");

        private void Add()
        {
            try
            {
                productBindingSource.EndEdit();
                productTableAdapter.Update(this.program1DataSet.product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productBindingSource.ResetBindings(false);
            }
        }

        private void Loop()
        {
            try
            {
                textBoxBiayaServis.Focus();        
                this.program1DataSet.product.AddproductRow(this.program1DataSet.product.NewproductRow());
                productBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productBindingSource.ResetBindings(false);
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxHargaSparepart.Text);
            int b = Convert.ToInt32(textBoxBiayaServis.Text);
            textBoxTotal.Text = Convert.ToString(a + b);
            
            Add();
            
        }

        private void checkoutForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'program1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.program1DataSet.product);
            productBindingSource.DataSource = this.program1DataSet.product;
            Loop();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Add();
            program1DataSet.AcceptChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                productBindingSource.RemoveCurrent();
            productBindingSource.EndEdit();
            productTableAdapter.Update(this.program1DataSet.product);
            program1DataSet.product.AcceptChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmPrint frm = new frmPrint();
            //frm.ShowDialog();
            //string s = "select * from product";
            //OleDbCommand cmd = new OleDbCommand(s, conn);
            //OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adap.Fill(ds);
            //Printform prf = new Printform();
            //prf.SetDataSource(ds);
            //frm.crystalReportViewer1.ReportSource = prf;
            //frm.crystalReportViewer1.Refresh();
            Getter obj = new Getter();
            if(obj != null) { 
                using (IDbConnection db = new OleDbConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select * from product";
                    List<Setter> list = db.Query<Setter>(query, commandType: CommandType.Text).ToList();
                    using (frmPrint frm = new frmPrint(obj, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
