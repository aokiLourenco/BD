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
        public static string SQLConnectionString = "Data Source = (localdb)\\LocalEldenVault;Initial Catalog=master;Integrated Security=True;Encrypt=False";

        //TÓ
        //public static string SQLConnectionString = "Data Source = localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False";


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

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }
        }

        private void CraftsButton_Click(object sender, EventArgs e)
        {
            ////GO TO CRAFT PAGE
            //this.Hide();
            //Crafts craft = new Crafts();
            //craft.Show();
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

                CN.Close();
            }
            catch (Exception)
            {
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

            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Characters JOIN Locations ON Characters.LocationID = Locations.LocationID ORDER BY Characters.Name", CN);
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
                detailsTable.Columns["Area"].ColumnName = "Location";

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }

        }

        private void BossesButton_Click(object sender, EventArgs e)
        {
            ////GO to bosses page
            //this.Hide();
            //Bosses boss = new Bosses();
            //boss.Show();

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

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }
        }

        private void DungeonsButton_Click(object sender, EventArgs e)
        {
            ////GO TO DUNGEONS PAGE
            //this.Hide();
            //Dungeons dungeon = new Dungeons();
            //dungeon.Show();

            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dungeons ORDER BY Dungeons.DungeonID", CN);
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

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }

        }

        private void EnemiesButton_Click(object sender, EventArgs e)
        {
            ////GO TO ENEMY PAGE
            //this.Hide();
            //Enemies enemy = new Enemies();
            //enemy.Show();

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

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }

        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            ////GO TO ITEMS PAGE
            //this.Hide();
            //Items item = new Items();
            //item.Show();

            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Items ORDER BY Items.ItemID", CN);
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

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }

        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            ////GO TO CRAFTING MATERIALS PAGE
            //this.Hide();
            //CraftingMaterials craftingMaterials = new CraftingMaterials();
            //craftingMaterials.Show();

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

                CN.Close();
            }
            catch (Exception)
            {
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

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            // Clear the ShowTableInfo contents
            ShowTableInfo.DataSource = false;

        }
    }
}
