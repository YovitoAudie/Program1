using System;
using System.Windows.Forms;

namespace Program1
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void Loop()
        {
            try
            {
                dateTime.Focus();
                this.program1DataSet.product.AddproductRow(this.program1DataSet.product.NewproductRow());
                productBindingSource.MoveLast();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productBindingSource.ResetBindings(false);
            }
        }

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

        private void editForm_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'program1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.program1DataSet.product);
             productBindingSource.DataSource = this.program1DataSet.product;
            Loop();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrCode.Draw(textBox1.Text+textBoxNameCustomer.Text+ "PRIMAKOM",50);

            Add();
            program1DataSet.product.AcceptChanges();
            Loop();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Add();
            program1DataSet.product.AcceptChanges();   
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                productBindingSource.RemoveCurrent();
            productBindingSource.EndEdit();
            productTableAdapter.Update(this.program1DataSet.product);
            program1DataSet.product.AcceptChanges();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    productBindingSource.RemoveCurrent();
               
            }
        }
    }
}
