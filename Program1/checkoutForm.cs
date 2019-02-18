using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class checkoutForm : Form
    {
        public checkoutForm()
        {
            InitializeComponent();
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

        private void checkoutForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'program1DataSet.price' table. You can move, or remove it, as needed.
            this.priceTableAdapter.Fill(this.program1DataSet.price);
            // TODO: This line of code loads data into the 'program1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.program1DataSet.product);
            //string query = ;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
