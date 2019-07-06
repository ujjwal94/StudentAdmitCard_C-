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

namespace StudentAdmitCard
{
    public partial class Form1 : Form
    {
        String _MyConnectionString = "Server=localhost;Database=new_schema;Uid=root;Pwd=@123Syscom;";
        String _firstName = null;
        String _rollNumber = null;
        AutoCompleteStringCollection _collection = new AutoCompleteStringCollection();
        

        private void SearchCollection()
        {

            MySqlConnection connection = new MySqlConnection(_MyConnectionString);
            connection.Open();
            try
            {
                this.searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
                string querySelect = "SELECT * FROM studentdb";
                MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                MySqlDataReader reader = commandSelect.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader[0].ToString() + " " + reader[1].ToString(); 
                    _collection.Add(type);
                    type = reader[2].ToString();
                    _collection.Add(type);
                }
                reader.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        void UpdateAdmitCard()
        {
            
            MySqlConnection connection = new MySqlConnection(_MyConnectionString);
            connection.Open();
            try
            {
                this.searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                string querySelect = "SELECT * FROM studentdb WHERE RollNumber="+_rollNumber;
                MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                MySqlDataReader reader = commandSelect.ExecuteReader();
                while (reader.Read())
                {
                    nameLabel.Text = reader[0].ToString() + " " + reader[1].ToString();
                    classLabel.Text = reader[4].ToString();
                    rollnumberLabel.Text = reader[2].ToString();
                    addressLabel.Text = reader[3].ToString();
                    schoolName.Text = "PPS PUBLIC SCHOOL";

                }
                reader.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            
        }

        public Form1()
        {
            InitializeComponent();

            SearchCollection();

            searchTextBox.AutoCompleteCustomSource = _collection;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String inputTexted = searchTextBox.SelectedText.ToString();

            if (inputTexted.All(char.IsDigit))
            {
                _rollNumber = inputTexted;
            }
            else
            {
                _firstName = inputTexted.Split(' ')[0];

                MySqlConnection connection = new MySqlConnection(_MyConnectionString);
                connection.Open();
                try
                {
                    this.searchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.searchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    string querySelect = "SELECT RollNumber FROM studentdb WHERE FirstName= \"" + _firstName+"\"";
                    MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                    MySqlDataReader reader = commandSelect.ExecuteReader();
                    while (reader.Read())
                    {
                        _rollNumber = reader[0].ToString();

                    }
                    reader.Close();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

            }

            UpdateAdmitCard();

            bunifuGradientPanel1.Visible = true;
        }
    }
}
