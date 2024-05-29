﻿using Microsoft.Data.SqlClient;
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
    public partial class Add_Bosses : Form
    {
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        public Add_Bosses()
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
        }


        private void Back()
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }


        private void Add_Boss_DB(string name, string attacks, string Attributes, string description, string class_str, string weakness, string location, string level, string cutscene)
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

                cmd = new SqlCommand("AddBoss", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CharacterID", new SqlCommand("SELECT MAX(CharacterID) FROM Characters",CN).ExecuteScalar());
                cmd.Parameters.AddWithValue("@Cutscene", cutscene);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Boss added successfully");

                Back();
            }
            catch (Exception e)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteCharacter", CN);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Character", new SqlCommand("SELECT MAX(CharacterID) FROM Characters", CN).ExecuteScalar());
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    
                }

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
            string location = textBox_Location.Text;
            string level = textBox_Level.Text;
            string cutscene = textBox_cutscene.Text;

            if (name == "" || attacks == "" || Attributes == "" || description == "" || class_str == "" || weakness == "" || location == "" || level == "" || cutscene == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            Add_Boss_DB(name, attacks, Attributes, description, class_str, weakness, location, level,cutscene);


        }
    }
}
