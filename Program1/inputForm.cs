using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;


namespace Program1
{

    public partial class inputForm : Form
    {

        public static string inputNamaKonsumen, inputNamaBarang, inputSerialNomor, inputKelengkapan, inputKerusakan;
        public static int inputQty;
        Form1 frm1 = new Form1();


        public inputForm()
        {
            InitializeComponent();
            //string MD5Hash;
        }

        //public static string MD5Hash(string input)
        //{
        //    StringBuilder hash = new StringBuilder();
        //    MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        //    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

        //    for (int i= )
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Insert();
        }

        //public void Insert()
        //{
            
        //    string query = "INSERT INTO `program1`(`namaKonsumen`, `qty`, `namaBarang`, `serialNomor`, `kelengkapan`, kerusakan)" + "VALUES(" + textNamaKonsumen.Text + "," + textQuantity.Text + "," + textNamaBarang.Text + "," + textNamaKonsumen.Text + "," + textSerialNomor.Text + "," + textKelengkapan.Text + "," + textKerusakan.Text + ")";

            //open connection
        //    if (this.frm1.OpenConnection() == true)
        //    {


                //create sql command
        //        MySqlCommand cmd = new MySqlCommand(query, frm1.connection);

                //execute query
        //        cmd.ExecuteNonQuery();

                //close connection
        //      this.frm1.CloseConnection();
        //    }        
        //}
    }
}
