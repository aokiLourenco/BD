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
    public partial class Add_Crafts : Form
    {
        private SqlConnection CN;
        private Dictionary<string, int> items = new Dictionary<string, int>();
        private Dictionary<int, string> items_reverse = new Dictionary<int, string>();
        private Dictionary<string, int> materials = new Dictionary<string, int>();
        public Add_Crafts()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Items();
        }

        private void Load_Items()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                SqlCommand cmd = new SqlCommand("SELECT ItemID, Name FROM Items", CN);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idItem = (int)reader["ItemID"];
                    string name = reader["Name"].ToString().ToLower();
                    if (!items.ContainsKey(name))
                        items.Add(name, idItem);
                    if (!items_reverse.ContainsKey(idItem))
                        items_reverse.Add(idItem, name);
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

                SqlCommand cmd = new SqlCommand("SELECT CraftingMaterialID, UsedItems FROM CraftingMaterials", CN);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Store both ID_Localition and Name as a KeyValuePair in the dictionary
                    int idItem = (int)reader["CraftingMaterialID"];
                    string name = items_reverse[(int)reader["UsedItems"]].ToString().ToLower();
                    if (!materials.ContainsKey(name))
                        materials.Add(name, idItem);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" AI AI " + ex.Message);
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();
            }

            comboBox1.Items.AddRange(materials.Keys.ToArray());
            comboBox2.Items.AddRange(items.Keys.ToArray());

        }

        private void Add_Crafts_DB(string Source, string UsedItems)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("AddCraft", CN);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@ItemID", items[UsedItems.ToLower()]);
                cmd.Parameters.AddWithValue("@CraftingMaterialID", materials[Source.ToLower()]);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Crafts added successfully");
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
            string Source = comboBox1.Text;
            string UsedItems = comboBox2.Text;

            Add_Crafts_DB(Source, UsedItems);
        }

        private void Back()
        {
            this.Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Back();
        }
    }
}
