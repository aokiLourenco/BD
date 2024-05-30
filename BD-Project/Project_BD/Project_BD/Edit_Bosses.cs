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
    public partial class Edit_Bosses : Form
    {
        private int id;
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        public Edit_Bosses(Dictionary<string, Object> cell_values)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Edit_Bosses_Load(cell_values);
            LoadLocations();
            id = Int32.Parse(cell_values["ID"].ToString());
        }

        private void Edit_Bosses_Load(Dictionary<string, Object> cell_values)
        {
            textBox_Name.Text = cell_values["Name"].ToString();
            textBox_Attacks.Text = cell_values["Attacks"].ToString();
            textBox_Attributes.Text = cell_values["Attributes"].ToString();
            textBox_Class.Text = cell_values["Class"].ToString();
            textBox_Description.Text = cell_values["Description"].ToString();
            textBox_Level.Text = cell_values["Level"].ToString();
            DropBox.Text = cell_values["Area"].ToString().ToLower();
            textBox_Weakness.Text = cell_values["Weakness"].ToString();
            textBox_cutscene.Text = cell_values["Cutscene"].ToString();

        }

        private void LoadLocations()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                
                SqlCommand cmd = new SqlCommand("SELECT LocationID, Name FROM Locations", CN);
                SqlDataReader reader = cmd.ExecuteReader();


                locations.Clear();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idLocation = (int)reader["LocationID"];
                    string local = reader["Name"].ToString().ToLower();

                    locations.Add(local, idLocation);
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

            DropBox.Items.AddRange(locations.Keys.ToArray());
        }

        private void Back()
        {
            this.Close();
        }

        private void Edit_Bosses_DB(string name, string attacks, string Attributes, string description, string class_str, string weakness, string location, string level, string cutscene)
        {
            try
            {
                CN.Open();

                SqlCommand cmd = new SqlCommand("EditBoss", CN);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Boss", id);
                cmd.Parameters.AddWithValue("@Cutscene", cutscene);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Attacks", attacks);
                cmd.Parameters.AddWithValue("@Attributes", Attributes);
                cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                cmd.Parameters.AddWithValue("@Class", class_str);
                cmd.Parameters.AddWithValue("@Weakness", weakness);
                cmd.Parameters.AddWithValue("@LEVEL", Int32.Parse(level));


                cmd.ExecuteNonQuery();
                MessageBox.Show("Boss Edited successfully");



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
            string attacks = textBox_Attacks.Text;
            string Attributes = textBox_Attributes.Text;
            string description = textBox_Description.Text;
            string class_str = textBox_Class.Text;
            string weakness = textBox_Weakness.Text;
            string location = DropBox.Text;
            string level = textBox_Level.Text;
            string cutscene = textBox_cutscene.Text;

            if (name == "" || attacks == "" || Attributes == "" || description == "" || class_str == "" || weakness == "" || location == "" || level == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            if (!int.TryParse(level, out int levelInt) || levelInt < 1 || levelInt < 100)
            {
                MessageBox.Show("Level must be a number higher than 99");
                return;
            }


            Edit_Bosses_DB(name, attacks, Attributes, description, class_str, weakness, location, level, cutscene);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
