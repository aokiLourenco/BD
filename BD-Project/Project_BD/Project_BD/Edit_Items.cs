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
    public partial class Edit_Items : Form
    {
        private SqlConnection CN;
        private int id;
        private Dictionary<string, int> characters = new Dictionary<string, int>();
        private Dictionary<string, int> awards = new Dictionary<string, int>();

        public Edit_Items(Dictionary<string,object> cell_values)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Values();
            id = Int32.Parse(cell_values["ID"].ToString());
            Edit_Items_Load(cell_values);

        }

        private void Edit_Items_Load(Dictionary<string, Object> cell_values)
        {
            textBox_Name.Text = cell_values["Name"].ToString();
            DropBox.Text = cell_values["FoundIn"].ToString();
            textBox_Description.Text = cell_values["Description"].ToString();
            comboBox1.Text = cell_values["Owner"].ToString();
            textBox_UR.Text = cell_values["UseRequisites"].ToString();

        }


        private void Load_Values()
        {
            MessageBox.Show("Load Values");
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd = new SqlCommand("SELECT CharacterID,Name FROM Characters", CN);
                SqlDataReader reader = cmd.ExecuteReader();


                characters.Clear();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idCharacter = (int)reader["CharacterID"];
                    string name = reader["Name"].ToString().ToLower();
                    if (!characters.ContainsKey(name))
                        characters.Add(name, idCharacter);
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


            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd2 = new SqlCommand("SELECT DungeonID, Name FROM Dungeons", CN);
                SqlDataReader reader = cmd2.ExecuteReader();


                awards.Clear();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idDungeon = (int)reader["DungeonID"];
                    string name = reader["Name"].ToString().ToLower();
                    if (!awards.ContainsKey(name)) 
                        awards.Add(name, idDungeon);
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
            DropBox.Items.AddRange(characters.Keys.ToArray());
        }


        private void Edit_Items_DB(string name, string Owner, string Award, string description, string UR)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("EditItem", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Item", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Owner", characters[Owner.ToLower()]);
                cmd.Parameters.AddWithValue("@Award", awards[Award.ToLower()]);
                cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                cmd.Parameters.AddWithValue("@UseRequisites", UR);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item edited successfully");
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



        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string Owner = comboBox1.Text;
            string Award = DropBox.Text;
            string description = textBox_Description.Text;
            string UR = textBox_UR.Text;

            Edit_Items_DB(name, Owner, Award, description, UR);
        }

        private void Back()
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
