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
    public partial class Add_Items : Form
    {
        private SqlConnection CN;

        private Dictionary<string, int> characters = new Dictionary<string, int>();
        private Dictionary<string, int> awards = new Dictionary<string, int>();

        public Add_Items()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Values();
        }

        private void Load_Values()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Characters", CN);
                SqlDataReader reader = cmd.ExecuteReader();


                characters.Clear();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idCharacter = (int)reader["CharacterID"];
                    string name = reader["Name"].ToString().ToLower();

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

                SqlCommand cmd = new SqlCommand("SELECT * FROM Dungeons", CN);
                SqlDataReader reader = cmd.ExecuteReader();


                characters.Clear();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idDungeon = (int)reader["DungeonID"];
                    string name = reader["Name"].ToString().ToLower();

                    characters.Add(name, idDungeon);
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


        private void Add_Items_DB(string name, string Owner, string Award, string description, string UR)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddItem", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Owner", Owner);
                cmd.Parameters.AddWithValue("@Award", Award);
                cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                cmd.Parameters.AddWithValue("@UseRequisites", UR);


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


        private void Back()
        {
            this.Close();
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            string Owner = textBox_Owner.Text;
            string Award = textBox_Award.Text;
            string UR = textBox_UR.Text;

            Add_Items_DB(name, Owner, Award, description, UR);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
