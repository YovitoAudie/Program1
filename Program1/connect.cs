using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Program1
{

    public class connect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        string queryNamaKonsumen = inputForm.inputNamaKonsumen;
        int queryQty = inputForm.inputQty;
        string queryNamaBarang = inputForm.inputNamaBarang;
        string querySerialNomor = inputForm.inputSerialNomor;
        string queryKelengkapan = inputForm.inputKelengkapan;
        string queryKerusakan = inputForm.inputKerusakan;

        private inputForm InForm;

        public void Connect_Load(object sender, EventArgs e)
        {
            //string queryNamaKonsumen = inputForm.inputNamaKonsumen;
            //int queryQty = inputForm.inputQty;
            //string queryNamaBarang  = inputForm.inputNamaBarang;
            //string querySerialNomor = inputForm.inputSerialNomor;
            //string queryKelengkapan = inputForm.inputKelengkapan;
            //string queryKerusakan = inputForm.inputKerusakan;           
        }

        private void Load(object sender, EventArgs e)
        {
            InForm = new inputForm();
        }

        //Constructor
        //public DBConnect()
        //{
        //    Initialize();
        //}

        private void Initialize()
        {
            server = "localhost";
            database = "program1";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact Administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Get from textbox
        //public void GetText()
        //{
        //    TextBox date = Application.OpenForms["inputForm"].Controls["dateTanggal"] as TextBox;
        //    Console.WriteLine(date.ToString());
        //    Console.WriteLine(date);
        //}


        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO `program1`(`namaKonsumen`, `qty`, `namaBarang`, `serialNomor`, `kelengkapan`, kerusakan)"+"VALUES("+ queryNamaBarang +","+ queryQty +","+ queryNamaBarang +","+ querySerialNomor + "," + queryKelengkapan + "," + queryKerusakan + ")";

            //open connection
            if (this.OpenConnection()== true)
            {
                //create sql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        //public void Update()
        //{
        //    string query = "UPDATE `program1` (`tanggal`, `namaKonsumen`, `qty`, `namaBarang`, `serialNomor`, `kelengkapan`, kerusakan)" + "VALUES(" + textNamaKonsumen.text + "," + ")";
        //
        //    //Open Connection
        //    if(this.OpenConnection() == true)
        //    {
        //        //create mysql commad
        //       MySqlCommand cmd = new MySqlCommand();
        //        //Assign the query using commandtext
        //        cmd.CommandText = query;
        //        //assign the connection usign connection
        //        cmd.Connection = connection;
        //
        //        //execute query
        //        cmd.ExecuteNonQuery();
        //
        //        //close connection
        //        this.CloseConnection();
        //    }
        //}
        
        //Delete statement
        //public void Delete()
        //{
        //    string query = "INSERT INTO `program1`(`tanggal`, `namaKonsumen`, `qty`, `namaBarang`, `serialNomor`, `kelengkapan`, kerusakan)" + "VALUES(" + textNamaKonsumen.text + "," + ")";
        //
        //    if (this.OpenConnection() == true)
        //    {
        //       MySqlCommand cmd = new MySqlCommand(query, connection);
        //
        //        //execute query
        //        cmd.ExecuteNonQuery();
        //
        //        //close connection
        //        this.CloseConnection();
        //    }
        //}

        //Select statement
        public List <string> [] Select()
        {
            string query = "SELECT * FROM program1";

            //create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if(this.OpenConnection() == true)
            {
                //create commad
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while(dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close data reader
                dataReader.Close();

                //close connection
                this.CloseConnection();

                //returen list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM program1";

            //open connection
            if(this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // close connection
                this.CloseConnection();

                return Count();
            }
            else
            {
                return Count();
            }
        }

        //Backup
        //public void Backup()
        //{

        //}

        //Restore
        //public void Restore()
        //{
        //    try
        //    {
                
        //    }
        //}
    }
}
