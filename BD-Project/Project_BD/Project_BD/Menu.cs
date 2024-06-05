using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        //public static string SQLConnectionString = "data source = (localdb)\\localEldenVault;initial catalog=master;integrated security=true;encrypt=false";

        //TÓ
        //public static string SQLConnectionString = "Data Source = localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False";

        //medieetta 
        public static string SQLConnectionString = "data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p1g2; uid = p1g2; password = #Escr@v0sD01t; TrustServerCertificate=true";

        public string data_type = "";
        private string last_type = "";
        private bool is_admin;

        private SqlConnection CN;

        public Menu(bool x = true)
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            is_admin = x;
            Hide_Change_Buttons();
            Show_Change_Buttons();
            P_Hide();
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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            Show_Change_Buttons();
            P_Hide();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LocationView_Table", CN);

                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            Show_Change_Buttons();
            P_Hide();

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            P_Hide();
            Show_Change_Buttons();

            cell_value.Clear();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * From CharactersView_Table", CN);


                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);


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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            P_Hide();
            Show_Change_Buttons();

            cell_value.Clear();
            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BossView_Table", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            P_Hide();
            Show_Change_Buttons();

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DungeonView_Table", CN);

                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

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
            cell_value.Clear();
            textBox_Attacks.Visible = true;
            button_attack_Search.Visible = true;
            P_Hide();
            Show_Change_Buttons();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM EnemyView_Table", CN);

                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

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
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            P_Show();
            Show_Change_Buttons();

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Items_Table", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);
                totalRecords = detailsTable.Rows.Count;
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
        {   //CraftingMaterials();
            //craftingMaterials.Show();
            textBox_Attacks.Visible = false;
            button_attack_Search.Visible = false;
            P_Hide();
            Show_Change_Buttons();

            cell_value.Clear();

            last_type = data_type;
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CraftingMaterials_Table", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

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
            Show_Change_Buttons();
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
                case "Crafts":
                    MessageBox.Show("Crafts can't be edited");
                    return;
                case "Characters":
                    formPopup = new Edit_Characters(cell_value);
                    break;
                case "Bosses":
                    formPopup = new Edit_Bosses(cell_value);
                    break;
                case "Dungeons":
                    formPopup = new Edit_Dungeons(cell_value);
                    break;
                case "Enemies":
                    MessageBox.Show("Enemies can't be edited try editing the Character");
                    return;
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
                MessageBox.Show(attackTotalParam.Value + " Enemy with an Attack named : " + textBox_Attacks.Text);
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
            string data2 = "";
            SqlCommand cmd;

            try
            {
                if (CN.State == ConnectionState.Closed)
                    CN.Open();

                switch (data_type)
                {
                    case "Bosses":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
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
                                data = "Level";
                                break;
                            case "Location Area":
                                data = "Area";
                                break;
                            case "Location Name":
                                data = "LocationsName";
                                break;
                            case "Cutscene":
                                data = "Cutscene";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM BossView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Characters":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
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
                                data = "Level";
                                break;
                            case "Location Area":
                                data = "Area";
                                break;
                            case "Location Name":
                                data = "LocationsName";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM CharactersView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "CraftingMaterials":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
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
                            case "UsedID":
                                data = "UsedID";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM CraftingMaterials_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Locations":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
                                break;
                            case "Area":
                                data = "Area";
                                break;
                            case "Points of Interest":
                                data = "PointsOfInterest";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM LocationView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Enemies":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
                                break;
                            case "Area":
                                data = "Area";
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
                            case "Location Name":
                                data = "LocationName";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM EnemyView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Items":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
                                break;
                            case "Area":
                                data = "Area";
                                break;
                            case "Use Requisites":
                                data = "UserRequisites";
                                break;
                            case "Owner":
                                data = "Owner";
                                break;
                            case "Found In":
                                data = "FoundIn";
                                break;
                            case "Armour":
                                data2 = "Armours";
                                break;
                            case "Weapon":
                                data2 = "Weapons";
                                break;
                            case "Talismans":
                                data2 = "Talismans";
                                break;
                            case "Magics":
                                data2 = "Magics";
                                break;

                        }
                        if (data != "" && data2 == "")
                        {
                            cmd = new SqlCommand("SELECT * FROM Items_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        }
                        else
                        {
                            cmd = new SqlCommand("SELECT * FROM " + data2, CN);
                        }
                        break;

                    case "Crafts":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
                                break;
                            case "Name":
                                data = "Name";
                                break;
                            case "Description":
                                data = "Description";
                                break;
                            case "Crafting Material ID":
                                data = "CraftingMaterialID";
                                break;
                            case "Used Item":
                                data = "UsedItem";
                                break;
                            case "Used In":
                                data = "UsedItem";
                                break;
                            case "Quantity":
                                data = "UsedItem";
                                break;
                            case "Source":
                                data = "Source";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM CraftsView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
                        break;

                    case "Dungeons":
                        switch (criteria)
                        {
                            case "ID":
                                data = "ID";
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
                                data = "LocationArea";
                                break;
                        }
                        cmd = new SqlCommand("SELECT * FROM DungeonView_Table WHERE " + data + " LIKE '%' + @filter + '%'", CN);
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

        private void ClearFilter_Click_1(object sender, EventArgs e)
        {
            SearchDataBox.Clear();
            DropBox.ResetText();
            DropBox.Text = "Filter";

            switch (data_type)
            {
                case "Characters":
                    CharactersButton_Click(sender, e);
                    break;
                case "Locations":
                    LocationsButton_Click(sender, e);
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
                case "Dungeons":
                    DungeonsButton_Click(sender, e);
                    break;
            }
        }
        private bool isView = true;
        private void ChangeToTable_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            if (!isView)
            {
                switch (data_type)
                {
                    case "Characters":
                        CharactersButton_Click(sender, e);
                        break;
                    case "Locations":
                        LocationsButton_Click(sender, e);
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
                    case "Dungeons":
                        DungeonsButton_Click(sender, e);
                        break;
                    default:
                        return;
                }
                Show_Change_Buttons();
            }
            else
            {
                CN.Open();
                switch (data_type)
                {
                    case "Characters":
                        cmd = new SqlCommand("SELECT * FROM Characters", CN);
                        break;
                    case "Locations":
                        cmd = new SqlCommand("SELECT * FROM Locations", CN);
                        break;
                    case "Items":
                        cmd = new SqlCommand("SELECT * FROM Items", CN);
                        break;
                    case "Bosses":
                        cmd = new SqlCommand("SELECT * FROM Bosses", CN);
                        break;
                    case "Enemies":
                        cmd = new SqlCommand("SELECT * FROM Enemies", CN);
                        break;
                    case "CraftingMaterials":
                        cmd = new SqlCommand("SELECT * FROM CraftingMaterials", CN);
                        break;
                    case "Crafts":
                        cmd = new SqlCommand("SELECT * FROM Crafts", CN);
                        break;
                    case "Dungeons":
                        cmd = new SqlCommand("SELECT * FROM Dungeons", CN);
                        break;
                    default:
                        return;
                }

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                ShowTableInfo.DataSource = detailsTable;
                ShowTableInfo.AutoResizeRows();
                ShowTableInfo.AutoResizeColumns();
                ShowTableInfo.Visible = true;

                Hide_Change_Buttons();
                CN.Close();
            }

        }
        private void Show_Change_Buttons()
        {
            if (is_admin)
            {
                AddButton.Visible = true;
                EditButton.Visible = true;
                DeleteButton.Visible = true;

            }

            DropBox.Visible = true;
            SearchDataBox.Visible = true;
            ClearFilter.Visible = true;

            isView = true;
        }
        private void Hide_Change_Buttons()
        {
            AddButton.Visible = false;
            EditButton.Visible = false;
            DeleteButton.Visible = false;

            DropBox.Visible = false;
            SearchDataBox.Visible = false;
            ClearFilter.Visible = false;

            isView = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void P_Show()
        {
            button1_prev.Visible = true;
            button2_next.Visible = true;
        }

        private void P_Hide()
        {
            button1_prev.Visible = false;
            button2_next.Visible = false;
        }


        private int pageSize = 10;
        private int currentPage = 1;
        private int totalRecords;

        private void LoadData()
        {
            CN.Open();
            int offset = (currentPage - 1) * pageSize;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Items_Table ORDER BY ID OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY", CN);
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            DataTable detailsTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            detailsTable.Clear();
            sqlDataAdapter.Fill(detailsTable);

            ShowTableInfo.DataSource = detailsTable;
            ShowTableInfo.AutoResizeRows();
            ShowTableInfo.AutoResizeColumns();
            ShowTableInfo.Visible = true;

            CN.Close();

        }

        private void button1_prev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Debug.WriteLine(currentPage);
                LoadData();
            }
        }

        private void button2_next_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("Records");

            Debug.WriteLine(totalRecords);

            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                Debug.WriteLine(currentPage);
                LoadData();
            }
        }

        private void textBox_Attacks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
