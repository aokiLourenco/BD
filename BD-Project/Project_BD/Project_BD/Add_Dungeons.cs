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
    public partial class Add_Dungeons : Form
    {
        private int id;
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        public Add_Dungeons()
        {
            CN = ConnectionManager.getSGBDConnection();
            InitializeComponent();
            LoadLocations();
        }

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
            DropBox.Items.AddRange(locations.Keys.ToArray());

        }

        private void Add_Dungeons_DB(string name, string Area, string MainBoss,string location)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddDungeon", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LocationID", locations[location.ToLower()]);
                cmd.Parameters.AddWithValue("@MainBoss", MainBoss);
                cmd.Parameters.AddWithValue("@Area", Area);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dungeon added successfully");
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

            string area = textBox_Area.Text;
            string name = textBox_Name.Text;
            string mainBoss = textBox_MainBoss.Text;
            string location = DropBox.Text;

            Add_Dungeons_DB(name, area, mainBoss, location);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
