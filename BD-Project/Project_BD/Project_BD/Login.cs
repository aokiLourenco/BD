using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_BD.Menu;
using System.Windows.Forms;

namespace Project_BD
{
    public partial class Login : Form
    {
        private SqlConnection CN;
        private int ID_Elden;


        public Login()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            textBox2.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                CN.Open();

                DataTable detailsTable = new DataTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                using (SqlConnection connection = ConnectionManager.getSGBDConnection())
                {
                    try
                    {
                        connection.Open();

                        using (SHA512 sha512 = SHA512.Create())
                        {
                            byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
                            byte[] hashedPasswordBytes = sha512.ComputeHash(passwordBytes);
                            string hashedPasswordHex = BitConverter.ToString(hashedPasswordBytes).Replace("-", "");

                            //MessageBox.Show("Hashed password: " + hashedPasswordHex);

                            string query = "SELECT Password FROM Users WHERE Username = @Username";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        byte[] storedHashedPasswordBytes = (byte[])reader["Password"];
                                        string storedHashedPasswordHex = BitConverter.ToString(storedHashedPasswordBytes).Replace("-", ""); // Convert to lowercase hex string

                                        if (storedHashedPasswordHex == hashedPasswordHex)
                                        {
                                            // Passwords match, proceed to login
                                            this.Hide();
                                            Menu menu = new Menu();
                                            menu.Show();
                                        }
                                        else
                                        {
                                            // Incorrect password
                                            MessageBox.Show("Invalid username or password");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid username or password");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void bypass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(false);
            menu.Show();
        }
    }
}
