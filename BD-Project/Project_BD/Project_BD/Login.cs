using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_BD.Menu;

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
            string id_elden = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(id_elden) && !string.IsNullOrEmpty(password))
            {
                using (SqlConnection connection = ConnectionManager.getSGBDConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM Characters WHERE CharacterID = @CharacterID AND Password_Character = @Password_Character";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CharacterID", id_elden);
                            command.Parameters.AddWithValue("@Password_Character", password);

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                this.Hide();
                                Menu menu = new Menu();
                                menu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Elden ID or password");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
    }
}
