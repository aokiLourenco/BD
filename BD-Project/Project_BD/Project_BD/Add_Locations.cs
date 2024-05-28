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
    public partial class Add_Locations : Form
    {
        private SqlConnection CN;
        public Add_Locations()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
        }

        private void Back()
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Back();
        }


        private void Add_Location_DB(string Area, string Name, string Description, string POI)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddLocation", CN);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@DESCRIPTION", Description);
                cmd.Parameters.AddWithValue("@Area", Area);
                cmd.Parameters.AddWithValue("@PointsOfInterest", POI);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Location added successfully");
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
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            string area = textBox_Area.Text;
            string POI = textBox_POI.Text;

            Add_Location_DB(area, name, description, POI);


        }
    }
}
