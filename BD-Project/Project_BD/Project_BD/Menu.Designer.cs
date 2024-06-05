namespace Project_BD
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            EditButton = new Button();
            AddButton = new Button();
            textBox_Attacks = new TextBox();
            button_attack_Search = new Button();
            LogOut = new Button();
            ChangeToTable = new Button();
            ClearSelectionButton = new Button();
            DeleteButton = new Button();
            ClearFilter = new Button();
            SearchDataBox = new TextBox();
            DropBox = new ComboBox();
            ShowTableInfo = new DataGridView();
            EnemiesButton = new Button();
            ItemsButton = new Button();
            CraftsButton = new Button();
            DugeonsButton = new Button();
            LocationsButton = new Button();
            CraftingButton = new Button();
            CharactersButton = new Button();
            BossesButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1_prev = new Button();
            button2_next = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowTableInfo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditButton.Cursor = Cursors.Hand;
            EditButton.Font = new Font("Segoe UI", 14F);
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(205, 559);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(137, 41);
            EditButton.TabIndex = 15;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Font = new Font("Segoe UI", 14F);
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(62, 559);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 41);
            AddButton.TabIndex = 13;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // textBox_Attacks
            // 
            textBox_Attacks.Anchor = AnchorStyles.None;
            textBox_Attacks.Cursor = Cursors.IBeam;
            textBox_Attacks.Font = new Font("Segoe UI", 10F);
            textBox_Attacks.ForeColor = SystemColors.WindowFrame;
            textBox_Attacks.Location = new Point(777, 567);
            textBox_Attacks.Name = "textBox_Attacks";
            textBox_Attacks.PlaceholderText = "Search no. Attack";
            textBox_Attacks.Size = new Size(137, 25);
            textBox_Attacks.TabIndex = 17;
            textBox_Attacks.TextChanged += textBox_Attacks_TextChanged;
            // 
            // button_attack_Search
            // 
            button_attack_Search.Anchor = AnchorStyles.Left;
            button_attack_Search.Cursor = Cursors.Hand;
            button_attack_Search.Font = new Font("Segoe UI", 10F);
            button_attack_Search.Location = new Point(920, 568);
            button_attack_Search.Name = "button_attack_Search";
            button_attack_Search.Size = new Size(118, 23);
            button_attack_Search.TabIndex = 18;
            button_attack_Search.Text = "Search";
            button_attack_Search.UseVisualStyleBackColor = true;
            button_attack_Search.Click += button_attack_Search_Click;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.None;
            LogOut.BackColor = Color.FromArgb(255, 192, 128);
            LogOut.BackgroundImage = (Image)resources.GetObject("LogOut.BackgroundImage");
            LogOut.BackgroundImageLayout = ImageLayout.Stretch;
            LogOut.Cursor = Cursors.Hand;
            LogOut.FlatAppearance.BorderColor = Color.White;
            LogOut.Location = new Point(12, 18);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(34, 39);
            LogOut.TabIndex = 20;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // ChangeToTable
            // 
            ChangeToTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ChangeToTable.Cursor = Cursors.Hand;
            ChangeToTable.Font = new Font("Segoe UI", 10F);
            ChangeToTable.Location = new Point(62, 121);
            ChangeToTable.Name = "ChangeToTable";
            ChangeToTable.Size = new Size(78, 33);
            ChangeToTable.TabIndex = 19;
            ChangeToTable.Text = "Table only";
            ChangeToTable.UseVisualStyleBackColor = true;
            ChangeToTable.Click += ChangeToTable_Click;
            // 
            // ClearSelectionButton
            // 
            ClearSelectionButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearSelectionButton.Cursor = Cursors.Hand;
            ClearSelectionButton.Font = new Font("Segoe UI", 13F);
            ClearSelectionButton.Location = new Point(1063, 546);
            ClearSelectionButton.Name = "ClearSelectionButton";
            ClearSelectionButton.Size = new Size(137, 67);
            ClearSelectionButton.TabIndex = 16;
            ClearSelectionButton.Text = "Clear Selection";
            ClearSelectionButton.UseVisualStyleBackColor = true;
            ClearSelectionButton.Click += ClearSelectionButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Font = new Font("Segoe UI", 14F);
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(348, 559);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(137, 41);
            DeleteButton.TabIndex = 14;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearFilter
            // 
            ClearFilter.Anchor = AnchorStyles.None;
            ClearFilter.Cursor = Cursors.Hand;
            ClearFilter.Font = new Font("Segoe UI", 10F);
            ClearFilter.Location = new Point(1072, 122);
            ClearFilter.Name = "ClearFilter";
            ClearFilter.Size = new Size(118, 23);
            ClearFilter.TabIndex = 12;
            ClearFilter.Text = "Clear";
            ClearFilter.UseVisualStyleBackColor = true;
            ClearFilter.Click += ClearFilter_Click_1;
            // 
            // SearchDataBox
            // 
            SearchDataBox.Anchor = AnchorStyles.None;
            SearchDataBox.Cursor = Cursors.IBeam;
            SearchDataBox.Font = new Font("Segoe UI", 10F);
            SearchDataBox.ForeColor = SystemColors.WindowFrame;
            SearchDataBox.Location = new Point(926, 121);
            SearchDataBox.Name = "SearchDataBox";
            SearchDataBox.PlaceholderText = "Search data";
            SearchDataBox.Size = new Size(124, 25);
            SearchDataBox.TabIndex = 11;
            SearchDataBox.TextChanged += SearchDataBox_TextChanged;
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.None;
            DropBox.BackColor = SystemColors.Window;
            tableLayoutPanel1.SetColumnSpan(DropBox, 2);
            DropBox.Cursor = Cursors.Hand;
            DropBox.Font = new Font("Segoe UI", 10F);
            DropBox.FormattingEnabled = true;
            DropBox.Items.AddRange(new object[] { "---------------Common--------------", "ID", "Name", "Description", "----------------Bosses----------------", "Class", "Attacks", "Attributes", "Weakness", "Level", "Location Area", "Location Name", "Cutscene", "--------Characters & Enemies--------", "Class", "Attacks", "Attributes", "Weakness", "Level", "Location Area", "Location Name", "----------Crafting Materials----------", "Crafting Use", "Source", "Quantity", "UsedID", "--------------Locations--------------", "Area", "Points of Interest", "----------------Items----------------", "Area", "Use Requisites", "Owner", "Found In", "Armour", "Weapon", "Talismans", "Magics", "----------------Crafts---------------", "Crafting Materials ID", "Used Item", "Used In", "Quantity", "Source", "-------------Dungeons-------------", "Main Boss", "Area", "Location Area" });
            DropBox.Location = new Point(639, 120);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(270, 25);
            DropBox.TabIndex = 9;
            DropBox.Text = "Filter";
            DropBox.SelectedIndexChanged += DropBox_SelectedIndexChanged;
            // 
            // ShowTableInfo
            // 
            ShowTableInfo.AllowUserToOrderColumns = true;
            ShowTableInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(ShowTableInfo, 8);
            ShowTableInfo.Dock = DockStyle.Fill;
            ShowTableInfo.Location = new Point(62, 160);
            ShowTableInfo.Name = "ShowTableInfo";
            ShowTableInfo.ReadOnly = true;
            ShowTableInfo.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(ShowTableInfo, 3);
            ShowTableInfo.Size = new Size(1138, 380);
            ShowTableInfo.TabIndex = 8;
            ShowTableInfo.CellClick += ShowTableInfo_CellClick;
            ShowTableInfo.CellContentClick += ShowTableInfo_CellContentClick;
            // 
            // EnemiesButton
            // 
            EnemiesButton.Anchor = AnchorStyles.None;
            EnemiesButton.Cursor = Cursors.Hand;
            EnemiesButton.Font = new Font("Segoe UI", 14F);
            EnemiesButton.Location = new Point(636, 23);
            EnemiesButton.Name = "EnemiesButton";
            EnemiesButton.Size = new Size(132, 30);
            EnemiesButton.TabIndex = 4;
            EnemiesButton.Text = "Enemies";
            EnemiesButton.UseVisualStyleBackColor = true;
            EnemiesButton.Click += EnemiesButton_Click;
            // 
            // ItemsButton
            // 
            ItemsButton.Anchor = AnchorStyles.None;
            ItemsButton.Cursor = Cursors.Hand;
            ItemsButton.Font = new Font("Segoe UI", 14F);
            ItemsButton.Location = new Point(779, 23);
            ItemsButton.Name = "ItemsButton";
            ItemsButton.Size = new Size(132, 30);
            ItemsButton.TabIndex = 5;
            ItemsButton.Text = "Items";
            ItemsButton.UseVisualStyleBackColor = true;
            ItemsButton.Click += ItemsButton_Click;
            // 
            // CraftsButton
            // 
            CraftsButton.Anchor = AnchorStyles.None;
            CraftsButton.Cursor = Cursors.Hand;
            CraftsButton.Font = new Font("Segoe UI", 14F);
            CraftsButton.Location = new Point(922, 23);
            CraftsButton.Name = "CraftsButton";
            CraftsButton.Size = new Size(132, 30);
            CraftsButton.TabIndex = 7;
            CraftsButton.Text = "Crafts";
            CraftsButton.UseVisualStyleBackColor = true;
            CraftsButton.Click += CraftsButton_Click;
            // 
            // DugeonsButton
            // 
            DugeonsButton.Anchor = AnchorStyles.None;
            DugeonsButton.Cursor = Cursors.Hand;
            DugeonsButton.Font = new Font("Segoe UI", 14F);
            DugeonsButton.Location = new Point(1065, 23);
            DugeonsButton.Name = "DugeonsButton";
            DugeonsButton.Size = new Size(132, 30);
            DugeonsButton.TabIndex = 1;
            DugeonsButton.Text = "Dungeons";
            DugeonsButton.UseVisualStyleBackColor = true;
            DugeonsButton.Click += DungeonsButton_Click;
            // 
            // LocationsButton
            // 
            LocationsButton.Anchor = AnchorStyles.None;
            LocationsButton.Cursor = Cursors.Hand;
            LocationsButton.Font = new Font("Segoe UI", 14F);
            LocationsButton.Location = new Point(493, 23);
            LocationsButton.Name = "LocationsButton";
            LocationsButton.Size = new Size(132, 30);
            LocationsButton.TabIndex = 0;
            LocationsButton.Text = "Locations";
            LocationsButton.UseVisualStyleBackColor = true;
            LocationsButton.Click += LocationsButton_Click;
            // 
            // CraftingButton
            // 
            CraftingButton.Anchor = AnchorStyles.None;
            CraftingButton.Cursor = Cursors.Hand;
            CraftingButton.Font = new Font("Segoe UI", 10F);
            CraftingButton.Location = new Point(350, 23);
            CraftingButton.Name = "CraftingButton";
            CraftingButton.Size = new Size(132, 30);
            CraftingButton.TabIndex = 6;
            CraftingButton.Text = "Crafting Materials";
            CraftingButton.UseVisualStyleBackColor = true;
            CraftingButton.Click += CraftingButton_Click;
            // 
            // CharactersButton
            // 
            CharactersButton.Anchor = AnchorStyles.None;
            CharactersButton.Cursor = Cursors.Hand;
            CharactersButton.Font = new Font("Segoe UI", 14F);
            CharactersButton.Location = new Point(207, 23);
            CharactersButton.Name = "CharactersButton";
            CharactersButton.Size = new Size(132, 30);
            CharactersButton.TabIndex = 2;
            CharactersButton.Text = "Characters";
            CharactersButton.UseVisualStyleBackColor = true;
            CharactersButton.Click += CharactersButton_Click;
            // 
            // BossesButton
            // 
            BossesButton.Anchor = AnchorStyles.None;
            BossesButton.Cursor = Cursors.Hand;
            BossesButton.Font = new Font("Segoe UI", 14F);
            BossesButton.Location = new Point(64, 23);
            BossesButton.Name = "BossesButton";
            BossesButton.Size = new Size(132, 30);
            BossesButton.TabIndex = 3;
            BossesButton.Text = "Bosses";
            BossesButton.UseVisualStyleBackColor = true;
            BossesButton.Click += BossesButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.67048836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3301325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3301325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3301325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3301325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3344831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3344831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3344831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3344831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.671041F));
            tableLayoutPanel1.Controls.Add(BossesButton, 1, 1);
            tableLayoutPanel1.Controls.Add(CharactersButton, 2, 1);
            tableLayoutPanel1.Controls.Add(CraftingButton, 3, 1);
            tableLayoutPanel1.Controls.Add(LocationsButton, 4, 1);
            tableLayoutPanel1.Controls.Add(DugeonsButton, 8, 1);
            tableLayoutPanel1.Controls.Add(CraftsButton, 7, 1);
            tableLayoutPanel1.Controls.Add(ItemsButton, 6, 1);
            tableLayoutPanel1.Controls.Add(EnemiesButton, 5, 1);
            tableLayoutPanel1.Controls.Add(ShowTableInfo, 1, 4);
            tableLayoutPanel1.Controls.Add(DropBox, 5, 3);
            tableLayoutPanel1.Controls.Add(SearchDataBox, 7, 3);
            tableLayoutPanel1.Controls.Add(ClearFilter, 8, 3);
            tableLayoutPanel1.Controls.Add(DeleteButton, 3, 7);
            tableLayoutPanel1.Controls.Add(ClearSelectionButton, 8, 7);
            tableLayoutPanel1.Controls.Add(ChangeToTable, 1, 3);
            tableLayoutPanel1.Controls.Add(LogOut, 0, 1);
            tableLayoutPanel1.Controls.Add(button_attack_Search, 7, 7);
            tableLayoutPanel1.Controls.Add(textBox_Attacks, 6, 7);
            tableLayoutPanel1.Controls.Add(AddButton, 1, 7);
            tableLayoutPanel1.Controls.Add(EditButton, 2, 7);
            tableLayoutPanel1.Controls.Add(button1_prev, 2, 3);
            tableLayoutPanel1.Controls.Add(button2_next, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.64156318F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.037351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.777094F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.84554863F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.038332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.038332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9299183F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7628813F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.92898F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // button1_prev
            // 
            button1_prev.Anchor = AnchorStyles.None;
            button1_prev.Cursor = Cursors.Hand;
            button1_prev.Font = new Font("Segoe UI", 10F);
            button1_prev.Location = new Point(214, 122);
            button1_prev.Name = "button1_prev";
            button1_prev.Size = new Size(118, 23);
            button1_prev.TabIndex = 21;
            button1_prev.Text = "Previous";
            button1_prev.UseVisualStyleBackColor = true;
            button1_prev.Click += button1_prev_Click;
            // 
            // button2_next
            // 
            button2_next.Anchor = AnchorStyles.None;
            button2_next.Cursor = Cursors.Hand;
            button2_next.Font = new Font("Segoe UI", 10F);
            button2_next.Location = new Point(357, 122);
            button2_next.Name = "button2_next";
            button2_next.Size = new Size(118, 23);
            button2_next.TabIndex = 22;
            button2_next.Text = "Next";
            button2_next.UseVisualStyleBackColor = true;
            button2_next.Click += button2_next_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)ShowTableInfo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EditButton;
        private Button AddButton;
        private TextBox textBox_Attacks;
        private Button button_attack_Search;
        private Button LogOut;
        private Button ChangeToTable;
        private Button ClearSelectionButton;
        private Button DeleteButton;
        private Button ClearFilter;
        private TextBox SearchDataBox;
        private ComboBox DropBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BossesButton;
        private Button CharactersButton;
        private Button CraftingButton;
        private Button LocationsButton;
        private Button DugeonsButton;
        private Button CraftsButton;
        private Button ItemsButton;
        private Button EnemiesButton;
        private DataGridView ShowTableInfo;
        private Button button1_prev;
        private Button button2_next;
    }
}