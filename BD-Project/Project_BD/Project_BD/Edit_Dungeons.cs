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
    public partial class Edit_Dungeons : Form
    {
        private int id;
        private SqlConnection CN;
        private Dictionary<string, int> locations = new Dictionary<string, int>();

        public Edit_Dungeons(Dictionary<string,object> cell_values)
        {

            CN = ConnectionManager.getSGBDConnection();
            InitializeComponent();
            LoadLocations();
            id = Int32.Parse(cell_values["ID"].ToString());
            Edit_Characters_Load(cell_values);

        }

        private void Edit_Characters_Load(Dictionary<string, Object> cell_values)
        {
            textBox_Name.Text = cell_values["Name"].ToString();
            textBox_Area.Text = cell_values["LocationArea"].ToString();
            DropBox.Text = cell_values["Area"].ToString();
            textBox_MainBoss.Text = cell_values["MainBoss"].ToString();
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


        private void Edit_Dungeons_DB(string name, string location, string area, string mainboss)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("EditDungeon", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Dungeon", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Area", area);
                cmd.Parameters.AddWithValue("@MainBoss", mainboss);

                // Get the ID_Location from the dictionary
                int idLocation = locations[location.ToLower()];
                cmd.Parameters.AddWithValue("@LocationID", idLocation);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Dungeon edited successfully");
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
            string location = DropBox.Text;
            string mainboss = textBox_MainBoss.Text;

            Edit_Dungeons_DB(name, location, area, mainboss);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
