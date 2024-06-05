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
    public partial class Edit_Locations : Form
    {


        private int id;
        private SqlConnection CN;

        public Edit_Locations(Dictionary<string, object> cell_value)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Locations_load(cell_value);
        }

        private void Locations_load(Dictionary<string, object> cell_value)
        {
            textBox_Name.Text = cell_value["Name"].ToString();
            textBox_Area.Text = cell_value["Area"].ToString();
            textBox_Description.Text = cell_value["Description"].ToString();
            textBox_POI.Text = cell_value["PointsOfInterest"].ToString();
            id = Int32.Parse(cell_value["ID"].ToString());

        }

        private void Edit_Locations_DB(string Name, string Area, string Description, string POI)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("EditLocation", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Location", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@DESCRIPTION", Description);
                cmd.Parameters.AddWithValue("@Area", Area);
                cmd.Parameters.AddWithValue("@PointsOfInterest", POI);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Location edited successfully");
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


        private void Confirm_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            string area = textBox_Area.Text;
            string POI = textBox_POI.Text;

            Edit_Locations_DB(name, area, description, POI);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
