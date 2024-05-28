/*
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
    public partial class Add_General : Form
    {
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        private string choice;


        //Initializer
        public Add_General(string choice)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            this.choice = choice;
            LoadLocations();

            Unload_Everything();

            switch (this.choice)
            {
                case "Characters":
                    Load_Character();
                    break;

                case "Locations":
                    Load_Locations();
                    break;

            }

        }

        //Load to a dictionary -> locations : locationID
        private void LoadLocations()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Locations", CN);
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
        }

        //Closes the popup
        private void Back()
        {
            this.Close();
        }

        // Button to Cancel
        private void Cancel_Click(object sender, EventArgs e)
        {
            Back();
        }

        // Button to Confirm
        private void Confirm_Click(object sender, EventArgs e)
        {
            switch (this.choice)
            {
                case "Character":
                    Get_Character_values();
                    break;
                case "Location":
                    Get_Location_values();
                    break;

            }

        }

        private void Unload_Everything()
        {
            Unload_Character();
        }


        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //                              ADD CHARACHTER                        //
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        //Load the necessary items to the form
        private void Unload_Character()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            textBox_Name.Visible = false;
            textBox_Attacks.Visible = false;
            textBox_Attributes.Visible = false;
            textBox_Description.Visible = false;
            textBox_Class.Visible = false;
            textBox_Weakness.Visible = false;
            textBox_Location.Visible = false;
            textBox_Level.Visible = false;
            textBox_Class.Visible = false;
        }


        private void Load_Character()
        {

            label1.Text = "Name";
            label2.Text = "Attacks";
            label3.Text = "Attributes";
            label4.Text = "Description";
            label5.Text = "Class";
            label6.Text = "Weakness";
            label7.Text = "Location";
            label8.Text = "Level";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            textBox_Name.Visible = true;
            textBox_Attacks.Visible = true;
            textBox_Attributes.Visible = true;
            textBox_Description.Visible = true;
            textBox_Class.Visible = true;
            textBox_Weakness.Visible = true;
            textBox_Location.Visible = true;
            textBox_Level.Visible = true;
            textBox_Class.Visible = true;

        }


        //If the choice is character, get the values from the Characters textboxes
        private void Get_Character_values()
        {

            string name = textBox_Name.Text;
            string attacks = textBox_Attacks.Text;
            string Attributes = textBox_Attributes.Text;
            string description = textBox_Description.Text;
            string class_str = textBox_Class.Text;
            string weakness = textBox_Weakness.Text;
            string location = textBox_Location.Text;
            string level = textBox_Level.Text;

            if (name == "" || attacks == "" || Attributes == "" || description == "" || class_str == "" || weakness == "" || location == "" || level == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            Add_Character_DB(name, attacks, Attributes, description, class_str, weakness, location, level);
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


        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        //                              ADD CHARACHTER                        //
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        private void Get_Locations_Value()
        {

        }

    }
}
*/