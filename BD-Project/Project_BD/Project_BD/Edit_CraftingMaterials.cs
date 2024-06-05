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
    public partial class Edit_CraftingMaterials : Form
    {
        private int id;
        private SqlConnection CN;
        private Dictionary<string, int> items = new Dictionary<string, int>();

        public Edit_CraftingMaterials(Dictionary<string, object> cell_values)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Items();
            Edit_Crafting_Load(cell_values);
            id = Int32.Parse(cell_values["ID"].ToString());
        }

        private void Edit_Crafting_Load(Dictionary<string, Object> cell_values)
        {
            textBox_CraftingUse.Text = cell_values["CraftingUse"].ToString();
            textBox_Quantity.Text = cell_values["Quantity"].ToString();
            textBox_Source.Text = cell_values["Source"].ToString();
            DropBox.Text = cell_values["Name"].ToString();

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

            DropBox.Items.AddRange(items.Keys.ToArray());
        }

        private void Edit_Crafting_DB(string Quantity, string Source, string CraftingUse, string UsedItems)
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("EditCraftingMaterial", CN);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_CraftingMaterial", id);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@Source", Source);
                cmd.Parameters.AddWithValue("@CraftingUse", CraftingUse);
                cmd.Parameters.AddWithValue("@UsedItems", items[UsedItems]);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Crafting Material edited successfully");
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
            string Quantity = textBox_Quantity.Text;
            string Source = textBox_Source.Text;
            string CraftingUse = textBox_CraftingUse.Text;
            string UsedItems = DropBox.Text;

            Edit_Crafting_DB(Quantity, Source, CraftingUse, UsedItems);
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
