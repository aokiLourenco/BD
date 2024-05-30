namespace Project_BD
{
    partial class Add_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            DropBox = new ComboBox();
            label4 = new Label();
            textBox_Description = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox_UR = new TextBox();
            textBox_Name = new TextBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 6, 0);
            tableLayoutPanel1.Controls.Add(DropBox, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 5, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 5, 2);
            tableLayoutPanel1.Controls.Add(label3, 4, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 4, 2);
            tableLayoutPanel1.Controls.Add(textBox_UR, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 3, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(15, 15);
            button1.Margin = new Padding(15, 15, 3, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 1, 0, 0);
            button1.Size = new Size(52, 45);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(140, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(252, 100);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Award";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(687, 15);
            button2.Margin = new Padding(3, 15, 15, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 1, 0, 0);
            button2.Size = new Size(98, 57);
            button2.TabIndex = 2;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.Top;
            DropBox.Cursor = Cursors.Hand;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(231, 153);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(108, 23);
            DropBox.TabIndex = 23;
            DropBox.Text = "Dungeon";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(573, 100);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // textBox_Description
            // 
            textBox_Description.Anchor = AnchorStyles.Top;
            textBox_Description.Cursor = Cursors.IBeam;
            textBox_Description.Location = new Point(573, 153);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(108, 23);
            textBox_Description.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(479, 100);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 7;
            label3.Text = "Owner";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(459, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 23);
            comboBox1.TabIndex = 24;
            comboBox1.Text = "Character";
            // 
            // textBox_UR
            // 
            tableLayoutPanel1.SetColumnSpan(textBox_UR, 2);
            textBox_UR.Cursor = Cursors.IBeam;
            textBox_UR.Location = new Point(345, 303);
            textBox_UR.Name = "textBox_UR";
            textBox_UR.Size = new Size(132, 23);
            textBox_UR.TabIndex = 12;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Location = new Point(117, 153);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(108, 23);
            textBox_Name.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(345, 250);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 11;
            label5.Text = "Use Requisites";
            // 
            // Add_Items
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Items";
            Text = "Add_Items";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox textBox_Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Description;
        private Button button2;
        private Label label5;
        private TextBox textBox_UR;
        private ComboBox DropBox;
        private ComboBox comboBox1;
    }
}