using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            inputForm showForm = new inputForm();
            showForm.TopLevel = false;
            mainPanel.Controls.Add(showForm);
            showForm.Show();
        }
     
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            historyForm showForm = new historyForm();
            showForm.TopLevel = false;
            mainPanel.Controls.Add(showForm);
            showForm.Show();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            checkoutForm showForm = new checkoutForm();
            showForm.TopLevel = false;
            mainPanel.Controls.Add(showForm);
            showForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            editForm showForm = new editForm();
            showForm.TopLevel = false;
            mainPanel.Controls.Add(showForm);
            showForm.Show();
        }

        
    }


        }
       
