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


namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text == "Username")
            {

                bunifuCustomTextbox1.Text = "";
                bunifuCustomTextbox1.ForeColor = Color.Black;
            }
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text == "")
            {

                bunifuCustomTextbox1.Text = "Username";
                bunifuCustomTextbox1.ForeColor = Color.LightGray;
            }
        }

        private void bunifuCustomTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox2.Text == "Password")
            {
                bunifuCustomTextbox2.Text = "";
                bunifuCustomTextbox2.ForeColor = Color.Black;
                bunifuCustomTextbox2.PasswordChar = '*';

            }
        }

        private void bunifuCustomTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox2.Text == "")
            {
                bunifuCustomTextbox2.Text = "Password";
                bunifuCustomTextbox2.ForeColor = Color.LightGray;
            }
        }

        private void bunifuLogin_Click(object sender, EventArgs e)
        {

            string username = bunifuCustomTextbox1.Text;
            string password = bunifuCustomTextbox2.Text;
            
            //string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=darabase";
            //string query = "SELECT * FROM doctor_login WHERE username = '" + bunifuCustomTextbox1.Text + "' and password = '" + bunifuCustomTextbox2.Text + "'";

            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;
            //MySqlDataReader reader;        
            //try
            //{
            //    databaseConnection.Open();
            //    reader = commandDatabase.ExecuteReader();
            //    databaseConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    // Show any error message.
            //    MessageBox.Show(ex.Message);
            //}

            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=darabase");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Count(*) From doctor_login Where username = '" + username + "'  and password = '" + password + "' ", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1" )
            {
                
                MessageBox.Show("Login Successful", "WELCOME TO JOHNS HOPKINS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f = new Form2();
                f.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Invalid Username and Password", "FRAUDSTER", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                bunifuCustomTextbox2.Text = "";
            }

            
        }

        private void bunifuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
