using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_BD.Login;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Project_BD
{
    public partial class Menu : Form
    {

        //AOKI
        //public static string SQLConnectionString = "data source = (localdb)\\localeldenvault;initial catalog=master;integrated security=true;encrypt=false";

        //TÓ
        public static string SQLConnectionString = "Data Source = localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False";

        public string data_type = "";
        private string last_type = "";


        private SqlConnection CN;

        public Menu()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
        }

        public static class ConnectionManager
        {
            public static SqlConnection getSGBDConnection()
            {
                return new SqlConnection(SQLConnectionString);
            }
        }

        private void LocationsButton_Click(object sender, EventArgs e)
        {
            ////GO TO LOCATIONS PAGE
            //this.Hide();
            //Locations location = new Locations();
            //location.Show();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Locations ORDER BY Locations.LocationID", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "Locations";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }
        }

        private void CraftsButton_Click(object sender, EventArgs e)
        {
            ////GO TO CRAFT PAGE
            //this.Hide();
            //Crafts craft = new Crafts();
            //craft.Show();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Crafts ORDER BY Crafts.ItemID", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;

                data_type = "Crafts";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CharactersButton_Click(object sender, EventArgs e)
        {
            //    //GO TO CHARACTER PAGE
            //    this.Hide();
            //    Characters character = new Characters();
            //    character.Show();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT Characters.CharacterID, Characters.Name, Characters.Attacks, Characters.Attributes, Characters.DESCRIPTION,  Characters.Class, Characters.Weakness, Locations.Name, Characters.LEVEL FROM Characters JOIN Locations ON Characters.LocationID = Locations.LocationID ORDER BY Characters.Name", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}
                detailsTable.Columns["CharacterID"].ColumnName = "ID";
                detailsTable.Columns["Name1"].ColumnName = "Area";

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "Characters";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }

        }

        private void BossesButton_Click(object sender, EventArgs e)
        {
            ////GO to bosses page
            //this.Hide();
            //Bosses boss = new Bosses();
            //boss.Show();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bosses JOIN Characters ON Bosses.CharacterID = Characters.CharacterID ORDER BY Bosses.CharacterID", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "Bosses";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }
        }

        private void DungeonsButton_Click(object sender, EventArgs e)
        {
            ////GO TO DUNGEONS PAGE
            //this.Hide();
            //Dungeons dungeon = new Dungeons();
            //dungeon.Show();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dungeons JOIN Locations ON Dungeons.LocationID = Locations.LocationID ORDER BY Dungeons.Name", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}
                detailsTable.Columns["DungeonID"].ColumnName = "ID";
                detailsTable.Columns["Name1"].ColumnName = "Location";


                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "Dungeons";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }

        }

        private void EnemiesButton_Click(object sender, EventArgs e)
        {
            ////GO TO ENEMY PAGE
            //this.Hide();
            //Enemies enemy = new Enemies();
            //enemy.Show();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Enemies ORDER BY Enemies.CharacterID", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "Enemies";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }

        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            ////GO TO ITEMS PAGE
            //this.Hide();
            //Items item = new Items();
            //item.Show();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT *\r\nFROM Items \r\nJOIN Dungeons ON Items.Award = Dungeons.DungeonID \r\nJOIN Characters ON Items.Owner = Characters.CharacterID\r\nORDER BY Items.ItemID\r\n", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;

                data_type = "Items";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }

        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            ////GO TO CRAFTING MATERIALS PAGE
            //this.Hide();
            //CraftingMaterials craftingMaterials = new CraftingMaterials();
            //craftingMaterials.Show();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CraftingMaterials ORDER BY CraftingMaterials.CraftingMaterialID", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                //string[] columnsToKeep = { "Name", "Class", "Area" };

                //// Drop unwanted columns
                //for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                //{
                //    DataColumn column = detailsTable.Columns[i];
                //    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                //    {
                //        detailsTable.Columns.Remove(column);
                //    }
                //}

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;
                data_type = "CraftingMaterials";
                CN.Close();
            }
            catch (Exception)
            {
                data_type = last_type;
                MessageBox.Show("Please, try again");
            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TEXT BOX SEARCH?
        }

        private void ShowTableInfo_CellContentClick(object sender, EventArgs e)
        {

        }


        // ADD NEW INFORMATION
        private void AddButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            switch (data_type)
            {
                case "Locations":
                    formPopup = new Add_Locations();
                    break;
                case "Crafts":
                    formPopup = new Add_Crafts();
                    break;
                case "Characters":
                    formPopup = new Add_Character();
                    break;
                //case "Bosses":
                //    formPopup = new Add_Boss();
                //    break;
                case "Dungeons":
                    formPopup = new Add_Dungeons();
                    break;
                //case "Enemies":
                //    formPopup = new Add_Enemy();
                //    break;
                case "Items":
                    formPopup = new Add_Items();
                    break;
                //case "CraftingMaterials":
                //    formPopup = new Add_CraftingMaterial();
                //    break;
                default:
                    MessageBox.Show("Please, select a table to add data");
                    break;
            }
            formPopup.Show();
            switch (data_type)
            {
                case "Characters":
                    formPopup.FormClosed += new FormClosedEventHandler(CharactersButton_Click);
                    break;
                case "Locations":
                    formPopup.FormClosed += new FormClosedEventHandler(LocationsButton_Click);
                    break;
                case "Dungeons":
                    formPopup.FormClosed += new FormClosedEventHandler(DungeonsButton_Click);
                    break;
                case "Items":
                    formPopup.FormClosed += new FormClosedEventHandler(ItemsButton_Click);
                    break;
            }
        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            // Clear the ShowTableInfo contents
            ShowTableInfo.DataSource = false;

        }



        // EDIT INFORMATION ON A DB

        private Dictionary<string, Object> cell_value = new Dictionary<string, object>();
        private void EditButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            switch (data_type)
            {
                case "Locations":
                    formPopup = new Edit_Locations(cell_value);
                    break;
                //case "Crafts":
                //    formPopup = new Edit_Craft();
                //    break;
                case "Characters":
                    formPopup = new Edit_Characters(cell_value);
                    break;
                //case "Bosses":
                //    formPopup = new Edit_Boss();
                //    break;
                case "Dungeons":
                    formPopup = new Edit_Dungeons(cell_value);
                    break;
                //case "Enemies":
                //    formPopup = new Edit_Enemy();
                //    break;
                //case "Items":
                //    formPopup = new Edit_Item();
                //    break;
                //case "CraftingMaterials":
                //    formPopup = new Edit_CraftingMaterial();
                //    break;
                default:
                    MessageBox.Show("Please, select a table to edit data");
                    break;
            }
            formPopup.Show();

            switch (data_type)
            {
                case "Characters":
                    formPopup.FormClosed += new FormClosedEventHandler(CharactersButton_Click);
                    break;
                case "Locations":
                    formPopup.FormClosed += new FormClosedEventHandler(LocationsButton_Click);
                    break;
                case "Dungeons":
                    formPopup.FormClosed += new FormClosedEventHandler(DungeonsButton_Click);
                    break;

            }
        }


        private void ShowTableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var formPopup = new Form();
            if (ShowTableInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                cell_value.Clear();
                ShowTableInfo.CurrentRow.Selected = true;


                foreach (DataGridViewColumn column in ShowTableInfo.Columns)
                {
                    string columnName = column.Name;
                    string cellValue = ShowTableInfo.Rows[e.RowIndex].Cells[columnName].FormattedValue.ToString();
                    cell_value.Add(columnName, cellValue);
                }

            }
        }
    }
}
