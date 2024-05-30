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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_BD
{
    public partial class Add_Character : Form
    {
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        public Add_Character()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            LoadLocations();

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


        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }


        private void Add_Character_DB(string name, string attacks, string Attributes, string description, string class_str, string weakness, string location, string level)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddCharacter", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Attacks", attacks);
                cmd.Parameters.AddWithValue("@Attributes", Attributes);
                cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                cmd.Parameters.AddWithValue("@Class", class_str);
                cmd.Parameters.AddWithValue("@Weakness", weakness);
                cmd.Parameters.AddWithValue("@LEVEL", Int32.Parse(level));

                // Get the ID_Location from the dictionary
                int idLocation = locations[location.ToLower()];
                cmd.Parameters.AddWithValue("@LocationID", idLocation);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Character added successfully");
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

            if (name == "" || attacks == "" || Attributes == "" || description == "" || class_str == "" || weakness == "" || location == "" || level == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            Add_Character_DB(name, attacks, Attributes, description, class_str, weakness, location, level);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Back();
        }
    }
}
