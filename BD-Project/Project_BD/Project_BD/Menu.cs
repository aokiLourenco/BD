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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Project_BD
{
    public partial class Menu : Form
    {

        //AOKI
        public static string SQLConnectionString = "data source = (localdb)\\localeldenvault;initial catalog=master;integrated security=true;encrypt=false";

        //TÓ
        //public static string SQLConnectionString = "Data Source = localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False";

        public string data_type = "";
        private string last_type = "";


        private SqlConnection CN;

        public Menu()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Locations ORDER BY Locations.LocationID", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM LocationView_Table", CN);

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
            catch (Exception exp)
            {
                data_type = last_type;
                MessageBox.Show(exp.Message);
                MessageBox.Show("Please, try again");
            }
        }

        private void CraftsButton_Click(object sender, EventArgs e)
        {
            ////GO TO CRAFT PAGE
            //this.Hide();
            //Crafts craft = new Crafts();
            //craft.Show();
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CraftsView_table", CN);
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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            cell_value.Clear();
            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT Characters.CharacterID, Characters.Name, Characters.Attacks, Characters.Attributes, Characters.DESCRIPTION,  Characters.Class, Characters.Weakness, Locations.Name, Characters.LEVEL FROM Characters JOIN Locations ON Characters.LocationID = Locations.LocationID ORDER BY Characters.Name", CN);
                SqlCommand cmd = new SqlCommand("SELECT * From CharactersView_Table", CN);


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
                //detailsTable.Columns["CharacterID"].ColumnName = "ID";
                //detailsTable.Columns["Name1"].ColumnName = "Area";

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            cell_value.Clear();
            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Bosses JOIN Characters ON Bosses.CharacterID = Characters.CharacterID JOIN Locations ON Characters.LocationID = Locations.LocationID ORDER BY Bosses.CharacterID", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM BossView_Table", CN);
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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Dungeons JOIN Locations ON Dungeons.LocationID = Locations.LocationID ORDER BY Dungeons.Name", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM DungeonView_Table", CN);

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
            cell_value.Clear();
            textBox_Attacks.Visible = true;
            button_attack_Search.Visible = true;

            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Enemies ORDER BY Enemies.CharacterID", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM EnemyView_Table", CN);

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT *\r\nFROM Items \r\nJOIN Dungeons ON Items.Award = Dungeons.DungeonID \r\nJOIN Characters ON Items.Owner = Characters.CharacterID\r\nORDER BY Items.ItemID\r\n", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Items_Table", CN);
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
                //detailsTable.Columns["ItemID"].ColumnName = "ID";
                //detailsTable.Columns["Name1"].ColumnName = "Location";
                //detailsTable.Columns["Owner"].ColumnName = "Owner_ID";
                //detailsTable.Columns["Name2"].ColumnName = "Owner";


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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM CraftingMaterials ORDER BY CraftingMaterials.CraftingMaterialID", CN);
                SqlCommand cmd = new SqlCommand("SELECT * FROM CraftingMaterials_Table", CN);
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
                case "Bosses":
                    formPopup = new Add_Bosses();
                    break;
                case "Dungeons":
                    formPopup = new Add_Dungeons();
                    break;
                case "Enemies":
                    formPopup = new Add_Enemy();
                    break;
                case "Items":
                    formPopup = new Add_Items();
                    break;
                case "CraftingMaterials":
                    formPopup = new Add_CraftingMaterials();
                    break;
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
                case "Bosses":
                    formPopup.FormClosed += new FormClosedEventHandler(BossesButton_Click);
                    break;
                case "Enemies":
                    formPopup.FormClosed += new FormClosedEventHandler(EnemiesButton_Click);
                    break;
                case "CraftingMaterials":
                    formPopup.FormClosed += new FormClosedEventHandler(CraftingButton_Click);
                    break;
                case "Crafts":
                    formPopup.FormClosed += new FormClosedEventHandler(CraftsButton_Click);
                    break;

            }
        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            // Clear the ShowTableInfo contents
            ShowTableInfo.DataSource = false;

        }


        //DELETE INFORMATION FROM A DB
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (cell_value == null || cell_value.Count == 0)
            {
                MessageBox.Show("Please, select a row to delete");
                return;
            }
            try
            {
                CN.Open();
                SqlCommand cmd;
                switch (data_type)
                {
                    case "Locations":
                        cmd = new SqlCommand("DeleteLocation", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Location", cell_value["ID"]);
                        break;
                    case "Crafts":
                        cmd = new SqlCommand("DeleteCraft", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ItemID", cell_value["ID"]);
                        cmd.Parameters.AddWithValue("@CraftingMaterialID", cell_value["CraftingMaterialID"]);
                        break;
                    case "Characters":
                        cmd = new SqlCommand("DeleteCharacter", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Character", cell_value["ID"]);
                        break;
                    case "Bosses":
                        cmd = new SqlCommand("DeleteBoss", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Boss", cell_value["ID"]);
                        break;
                    case "Dungeons":
                        cmd = new SqlCommand("DeleteDungeon", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Dungeon", cell_value["ID"]);
                        break;
                    case "Enemies":
                        cmd = new SqlCommand("DeleteEnemy", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Enemy", cell_value["ID"]);

                        break;
                    case "Items":
                        cmd = new SqlCommand("DeleteItem", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Item", cell_value["ID"]);
                        break;
                    case "CraftingMaterials":
                        cmd = new SqlCommand("DeleteCraftingMaterial", CN);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_CraftingMaterial", cell_value["ID"]);
                        break;
                    default:
                        MessageBox.Show("Please, select a table to edit data");
                        return;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successefully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                    CN.Close();

                switch (data_type)
                {
                    case "Characters":
                        CharactersButton_Click(sender, e);
                        break;
                    case "Locations":
                        LocationsButton_Click(sender, e);
                        break;
                    case "Dungeons":
                        DungeonsButton_Click(sender, e);
                        break;
                    case "Items":
                        ItemsButton_Click(sender, e);
                        break;
                    case "Bosses":
                        BossesButton_Click(sender, e);
                        break;
                    case "Enemies":
                        EnemiesButton_Click(sender, e);
                        break;
                    case "CraftingMaterials":
                        CraftingButton_Click(sender, e);
                        break;
                    case "Crafts":
                        CraftsButton_Click(sender, e);
                        break;
                }
            }
        }

        // EDIT INFORMATION ON A DB

        private Dictionary<string, Object> cell_value = new Dictionary<string, object>();
        private void EditButton_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            if (cell_value == null || cell_value.Count == 0)
            {
                MessageBox.Show("Please, select a row to edit");
                return;
            }
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
                case "Bosses":
                    formPopup = new Edit_Bosses(cell_value);
                    break;
                case "Dungeons":
                    formPopup = new Edit_Dungeons(cell_value);
                    break;
                //case "Enemies":
                //    formPopup = new Edit_Enemy();
                //    break;
                case "Items":
                    formPopup = new Edit_Items(cell_value);
                    break;
                case "CraftingMaterials":
                    formPopup = new Edit_CraftingMaterials(cell_value);
                    break;
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
                case "Items":
                    formPopup.FormClosed += new FormClosedEventHandler(ItemsButton_Click);
                    break;
                case "Bosses":
                    formPopup.FormClosed += new FormClosedEventHandler(BossesButton_Click);
                    break;
                case "Enemies":
                    formPopup.FormClosed += new FormClosedEventHandler(EnemiesButton_Click);
                    break;
                case "CraftingMaterials":
                    formPopup.FormClosed += new FormClosedEventHandler(CraftingButton_Click);
                    break;

            }
        }

        private void button_attack_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();
                SqlCommand cmd = new SqlCommand("GetEnemiesWithAttack", CN);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Attack", textBox_Attacks.Text);

                SqlParameter attackTotalParam = new SqlParameter("@AttackTotal", SqlDbType.Int);
                attackTotalParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(attackTotalParam);
                cmd.ExecuteNonQuery();
                MessageBox.Show( attackTotalParam.Value + " Attacks named : " + textBox_Attacks.Text);
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

        private void ShowTableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ShowTableInfo.Rows.Count ||
                e.ColumnIndex < 0 || e.ColumnIndex >= ShowTableInfo.Columns.Count)
            {
                return;
            }
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

        private void SearchDataBox_TextChanged(object sender, EventArgs e)
        {
            string criteria = DropBox.Text;
            string filter = SearchDataBox.Text;
            string data = "";
            SqlCommand cmd;

            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                switch (data_type)
                {
                    case "Locations":
                        switch (criteria)
                        {
                            case "ID":
                                data = "LocationID";
                                break;
                            case "Area":
                                data = "Area";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Points of Interest":
                                data = "PointsOfInterest";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Locations WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Crafts":
                        switch (criteria)
                        {
                            case "ID":
                                data = "Items.ItemID";
                                break;
                            case "Name":
                                data = "Items.Name";
                                break;
                            case "Description":
                                data = "Items.DESCRIPTION";
                                break;
                            case "Source":
                                data = "CraftingMaterials.Source";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Crafts WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Characters":
                        switch (criteria)
                        {
                            case "ID":
                                data = "CharacterID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Desctiption":
                                data = "DESCRIPTION";
                                break;
                            case "Class":
                                data = "Class";
                                break;
                            case "Attacks":
                                data = "Attacks";
                                break;
                            case "Attributes":
                                data = "Attributes";
                                break;
                            case "Weakness":
                                data = "Weakness";
                                break;
                            case "Level":
                                data = "LEVEL";
                                break;
                            case "Location Area":
                                data = "Locations.Area";
                                break;
                            case "Location Name":
                                data = "Locations.Name";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Characters WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Bosses":
                        switch (criteria)
                        {
                            case "ID":
                                data = "BossID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Cutscene":
                                data = "Cutscene";
                                break;
                            case "Desctiption":
                                data = "DESCRIPTION";
                                break;
                            case "Class":
                                data = "Class";
                                break;
                            case "Attacks":
                                data = "Attacks";
                                break;
                            case "Attributes":
                                data = "Attributes";
                                break;
                            case "Weakness":
                                data = "Weakness";
                                break;
                            case "Level":
                                data = "LEVEL";
                                break;
                            case "Location Area":
                                data = "Locations.Area";
                                break;
                            case "Location Name":
                                data = "Locations.Name";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Bosses WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Dungeons":
                        switch (criteria)
                        {
                            case "ID":
                                data = "DungeonID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Main Boss":
                                data = "MainBoss";
                                break;
                            case "Area":
                                data = "Area";
                                break;
                            case "Location Area":
                                data = "Locations.Area";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Dungeons WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Enemies":
                        switch (criteria)
                        {
                            case "ID":
                                data = "EmenyID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Desctiption":
                                data = "DESCRIPTION";
                                break;
                            case "Class":
                                data = "Class";
                                break;
                            case "Attacks":
                                data = "Attacks";
                                break;
                            case "Attributes":
                                data = "Attributes";
                                break;
                            case "Weakness":
                                data = "Weakness";
                                break;
                            case "Level":
                                data = "LEVEL";
                                break;
                            case "Location Area":
                                data = "Locations.Area";
                                break;
                            case "Location Name":
                                data = "Locations.Name";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Enemies WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Items":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ItemID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "DESCRIPTION";
                                break;
                            case "Use Requisites":
                                data = "UserRequisites";
                                break;
                            case "Owner":
                                data = "Characters.Name";
                                break;
                            case "Dungeons":
                                data = "Dungeons.Name";
                                break;
                            case "Area":
                                data = "Dungeons.Area";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM Items WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "CraftingMaterials":
                        switch (criteria)
                        {
                            case "ID":
                                data = "CraftingMaterialID";
                                break;
                            case "Name":
                                data = "Items.Name";
                                break;
                            case "Crafting Use":
                                data = "CraftingUse";
                                break;
                            case "Source":
                                data = "Source";
                                break;
                            case "Quantity":
                                data = "Quantity";
                                break;
                            case "Description":
                                data = "DESCRIPTION";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM CraftingMaterials WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    default:
                        MessageBox.Show("Please, select a table to edit data");
                        return;
                }

                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@filter", filter);

                    DataTable detailsTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                    sqlDataAdapter.Fill(detailsTable);
                    ShowTableInfo.DataSource = detailsTable;
                    ShowTableInfo.Visible = true;
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

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
