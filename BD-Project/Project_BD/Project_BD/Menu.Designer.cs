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
            CharactersButton = new Button();
            LocationsButton = new Button();
            BossesButton = new Button();
            DugeonsButton = new Button();
            CraftingButton = new Button();
            EnemiesButton = new Button();
            CraftsButton = new Button();
            ItemsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            DropBox = new ComboBox();
            SearchDataBox = new TextBox();
            ClearFilter = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            ClearSelectionButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CharactersButton
            // 
            CharactersButton.Anchor = AnchorStyles.None;
            CharactersButton.Font = new Font("Segoe UI", 14F);
            CharactersButton.Location = new Point(205, 16);
            CharactersButton.Name = "CharactersButton";
            CharactersButton.Size = new Size(137, 38);
            CharactersButton.TabIndex = 2;
            CharactersButton.Text = "Characters";
            CharactersButton.UseVisualStyleBackColor = true;
            CharactersButton.Click += button3_Click;
            // 
            // LocationsButton
            // 
            LocationsButton.Anchor = AnchorStyles.None;
            LocationsButton.Font = new Font("Segoe UI", 14F);
            LocationsButton.Location = new Point(491, 16);
            LocationsButton.Name = "LocationsButton";
            LocationsButton.Size = new Size(137, 38);
            LocationsButton.TabIndex = 0;
            LocationsButton.Text = "Locations";
            LocationsButton.UseVisualStyleBackColor = true;
            LocationsButton.Click += button1_Click;
            // 
            // BossesButton
            // 
            BossesButton.Anchor = AnchorStyles.None;
            BossesButton.Font = new Font("Segoe UI", 14F);
            BossesButton.Location = new Point(62, 16);
            BossesButton.Name = "BossesButton";
            BossesButton.Size = new Size(137, 38);
            BossesButton.TabIndex = 3;
            BossesButton.Text = "Bosses";
            BossesButton.UseVisualStyleBackColor = true;
            BossesButton.Click += button4_Click;
            // 
            // DugeonsButton
            // 
            DugeonsButton.Anchor = AnchorStyles.None;
            DugeonsButton.Font = new Font("Segoe UI", 14F);
            DugeonsButton.Location = new Point(1063, 16);
            DugeonsButton.Name = "DugeonsButton";
            DugeonsButton.Size = new Size(137, 38);
            DugeonsButton.TabIndex = 1;
            DugeonsButton.Text = "Dungeons";
            DugeonsButton.UseVisualStyleBackColor = true;
            DugeonsButton.Click += button2_Click;
            // 
            // CraftingButton
            // 
            CraftingButton.Anchor = AnchorStyles.None;
            CraftingButton.Font = new Font("Segoe UI", 11F);
            CraftingButton.Location = new Point(348, 16);
            CraftingButton.Name = "CraftingButton";
            CraftingButton.Size = new Size(137, 38);
            CraftingButton.TabIndex = 6;
            CraftingButton.Text = "Crafting Materials";
            CraftingButton.UseVisualStyleBackColor = true;
            CraftingButton.Click += button7_Click;
            // 
            // EnemiesButton
            // 
            EnemiesButton.Anchor = AnchorStyles.None;
            EnemiesButton.Font = new Font("Segoe UI", 14F);
            EnemiesButton.Location = new Point(634, 16);
            EnemiesButton.Name = "EnemiesButton";
            EnemiesButton.Size = new Size(137, 38);
            EnemiesButton.TabIndex = 4;
            EnemiesButton.Text = "Enemies";
            EnemiesButton.UseVisualStyleBackColor = true;
            EnemiesButton.Click += button5_Click;
            // 
            // CraftsButton
            // 
            CraftsButton.Anchor = AnchorStyles.None;
            CraftsButton.Font = new Font("Segoe UI", 14F);
            CraftsButton.Location = new Point(920, 16);
            CraftsButton.Name = "CraftsButton";
            CraftsButton.Size = new Size(137, 38);
            CraftsButton.TabIndex = 7;
            CraftsButton.Text = "Crafts";
            CraftsButton.UseVisualStyleBackColor = true;
            CraftsButton.Click += button8_Click;
            // 
            // ItemsButton
            // 
            ItemsButton.Anchor = AnchorStyles.None;
            ItemsButton.Font = new Font("Segoe UI", 14F);
            ItemsButton.Location = new Point(777, 16);
            ItemsButton.Name = "ItemsButton";
            ItemsButton.Size = new Size(137, 38);
            ItemsButton.TabIndex = 5;
            ItemsButton.Text = "Items";
            ItemsButton.UseVisualStyleBackColor = true;
            ItemsButton.Click += button6_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.668984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3303127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3303127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3303127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3303127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3346605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3346605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3346605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3346605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.671115F));
            tableLayoutPanel1.Controls.Add(BossesButton, 1, 1);
            tableLayoutPanel1.Controls.Add(CharactersButton, 2, 1);
            tableLayoutPanel1.Controls.Add(CraftingButton, 3, 1);
            tableLayoutPanel1.Controls.Add(LocationsButton, 4, 1);
            tableLayoutPanel1.Controls.Add(DugeonsButton, 8, 1);
            tableLayoutPanel1.Controls.Add(CraftsButton, 7, 1);
            tableLayoutPanel1.Controls.Add(ItemsButton, 6, 1);
            tableLayoutPanel1.Controls.Add(EnemiesButton, 5, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 4);
            tableLayoutPanel1.Controls.Add(DropBox, 6, 3);
            tableLayoutPanel1.Controls.Add(SearchDataBox, 7, 3);
            tableLayoutPanel1.Controls.Add(ClearFilter, 8, 3);
            tableLayoutPanel1.Controls.Add(AddButton, 1, 6);
            tableLayoutPanel1.Controls.Add(EditButton, 2, 6);
            tableLayoutPanel1.Controls.Add(DeleteButton, 3, 6);
            tableLayoutPanel1.Controls.Add(ClearSelectionButton, 8, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.96078444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.46383429F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.094983F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.176749F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5461082F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5461082F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5461082F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6653252F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 8);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(62, 170);
            dataGridView1.Name = "dataGridView1";
            tableLayoutPanel1.SetRowSpan(dataGridView1, 2);
            dataGridView1.Size = new Size(1138, 286);
            dataGridView1.TabIndex = 8;
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.None;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(785, 128);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(121, 23);
            DropBox.TabIndex = 9;
            DropBox.Text = "Search";
            // 
            // SearchDataBox
            // 
            SearchDataBox.Anchor = AnchorStyles.None;
            SearchDataBox.ForeColor = SystemColors.WindowFrame;
            SearchDataBox.Location = new Point(938, 128);
            SearchDataBox.Name = "SearchDataBox";
            SearchDataBox.Size = new Size(100, 23);
            SearchDataBox.TabIndex = 11;
            SearchDataBox.Text = "Search data";
            // 
            // ClearFilter
            // 
            ClearFilter.Anchor = AnchorStyles.None;
            ClearFilter.Location = new Point(1094, 128);
            ClearFilter.Name = "ClearFilter";
            ClearFilter.Size = new Size(75, 23);
            ClearFilter.TabIndex = 12;
            ClearFilter.Text = "Clear";
            ClearFilter.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.None;
            AddButton.Font = new Font("Segoe UI", 14F);
            AddButton.Location = new Point(67, 503);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(127, 58);
            AddButton.TabIndex = 13;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.None;
            DeleteButton.Font = new Font("Segoe UI", 14F);
            DeleteButton.Location = new Point(353, 503);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(127, 58);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.None;
            EditButton.Font = new Font("Segoe UI", 14F);
            EditButton.Location = new Point(210, 503);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(127, 58);
            EditButton.TabIndex = 15;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // ClearSelectionButton
            // 
            ClearSelectionButton.Anchor = AnchorStyles.None;
            ClearSelectionButton.Font = new Font("Segoe UI", 14F);
            ClearSelectionButton.Location = new Point(1068, 503);
            ClearSelectionButton.Name = "ClearSelectionButton";
            ClearSelectionButton.Size = new Size(127, 58);
            ClearSelectionButton.TabIndex = 16;
            ClearSelectionButton.Text = "Clear Selection";
            ClearSelectionButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button CharactersButton;
        private Button LocationsButton;
        private Button BossesButton;
        private Button DugeonsButton;
        private Button CraftingButton;
        private Button EnemiesButton;
        private Button CraftsButton;
        private Button ItemsButton;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private ComboBox DropBox;
        private TextBox SearchDataBox;
        private Button ClearFilter;
        private Button AddButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button ClearSelectionButton;
    }
}