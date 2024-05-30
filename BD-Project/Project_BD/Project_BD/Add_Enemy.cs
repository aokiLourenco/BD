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
    public partial class Add_Enemy : Form
    {

        private SqlConnection CN;
        private Dictionary<string, int> characters = new Dictionary<string, int>();
        public Add_Enemy()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Character();

        }

        private void Load_Character()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd = new SqlCommand("SELECT CharacterID, Name FROM Characters", CN);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idItem = (int)reader["CharacterID"];
                    string name = reader["Name"].ToString().ToLower();
                    if (!characters.ContainsKey(name))
                        characters.Add(name, idItem);

                }
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
            comboBox1.Items.AddRange(characters.Keys.ToArray());

        }
        private void Back()
        {
            this.Close();
        }

        private void Add_Enemy_DB(string Name)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddEnemy", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CharacterID", characters[Name.ToLower()]);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Enemy added successfully");
                Back();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();
            }


        }


        private void Confirm_Click(object sender, EventArgs e)
        {
            string Name = comboBox1.Text;

            Add_Enemy_DB(Name);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
