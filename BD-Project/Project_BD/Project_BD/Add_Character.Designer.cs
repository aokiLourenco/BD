namespace Project_BD
{
    partial class Add_Character
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Character));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            textBox_Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Attacks = new TextBox();
            label3 = new Label();
            textBox_Attributes = new TextBox();
            label4 = new Label();
            textBox_Description = new TextBox();
            button2 = new Button();
            label5 = new Label();
            textBox_Class = new TextBox();
            label6 = new Label();
            textBox_Weakness = new TextBox();
            label7 = new Label();
            textBox_Level = new TextBox();
            label8 = new Label();
            DropBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666737F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox_Attacks, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox_Attributes, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 4, 2);
            tableLayoutPanel1.Controls.Add(button2, 5, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_Class, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox_Weakness, 2, 4);
            tableLayoutPanel1.Controls.Add(label7, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox_Level, 4, 4);
            tableLayoutPanel1.Controls.Add(label8, 4, 3);
            tableLayoutPanel1.Controls.Add(DropBox, 3, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
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
            button1.Click += button1_Click_1;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Location = new Point(136, 151);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(127, 23);
            textBox_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(168, 98);
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
            label2.Location = new Point(296, 98);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 5;
            label2.Text = "Attacks";
            // 
            // textBox_Attacks
            // 
            textBox_Attacks.Anchor = AnchorStyles.Top;
            textBox_Attacks.Cursor = Cursors.IBeam;
            textBox_Attacks.Location = new Point(269, 151);
            textBox_Attacks.Name = "textBox_Attacks";
            textBox_Attacks.Size = new Size(127, 23);
            textBox_Attacks.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(418, 98);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 7;
            label3.Text = "Attributes";
            // 
            // textBox_Attributes
            // 
            textBox_Attributes.Anchor = AnchorStyles.Top;
            textBox_Attributes.Cursor = Cursors.IBeam;
            textBox_Attributes.Location = new Point(404, 151);
            textBox_Attributes.Name = "textBox_Attributes";
            textBox_Attributes.Size = new Size(122, 23);
            textBox_Attributes.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(544, 98);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // textBox_Description
            // 
            textBox_Description.Anchor = AnchorStyles.Top;
            textBox_Description.Cursor = Cursors.IBeam;
            textBox_Description.Location = new Point(537, 151);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(122, 23);
            textBox_Description.TabIndex = 10;
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
            button2.Size = new Size(98, 56);
            button2.TabIndex = 2;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(172, 246);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 11;
            label5.Text = "Class";
            // 
            // textBox_Class
            // 
            textBox_Class.Anchor = AnchorStyles.Top;
            textBox_Class.Cursor = Cursors.IBeam;
            textBox_Class.Location = new Point(136, 299);
            textBox_Class.Name = "textBox_Class";
            textBox_Class.Size = new Size(127, 23);
            textBox_Class.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(285, 246);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 13;
            label6.Text = "Weakness";
            // 
            // textBox_Weakness
            // 
            textBox_Weakness.Anchor = AnchorStyles.Top;
            textBox_Weakness.Cursor = Cursors.IBeam;
            textBox_Weakness.Location = new Point(269, 299);
            textBox_Weakness.Name = "textBox_Weakness";
            textBox_Weakness.Size = new Size(127, 23);
            textBox_Weakness.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(423, 246);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 15;
            label7.Text = "Location";
            // 
            // textBox_Level
            // 
            textBox_Level.Anchor = AnchorStyles.Top;
            textBox_Level.Cursor = Cursors.IBeam;
            textBox_Level.Location = new Point(537, 299);
            textBox_Level.Name = "textBox_Level";
            textBox_Level.Size = new Size(122, 23);
            textBox_Level.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(571, 246);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 18;
            label8.Text = "Level";
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.Top;
            DropBox.Cursor = Cursors.Hand;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(403, 299);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(124, 23);
            DropBox.TabIndex = 22;
            DropBox.Text = "Location";
            // 
            // Add_Character
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Character";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private TextBox textBox_Name;
        private Label label2;
        private TextBox textBox_Attacks;
        private Label label3;
        private TextBox textBox_Attributes;
        private Label label4;
        private TextBox textBox_Description;
        private Label label1;
        private Label label5;
        private TextBox textBox_Class;
        private Label label6;
        private TextBox textBox_Weakness;
        private Label label7;
        private TextBox textBox_Level;
        private Label label8;
        private ComboBox DropBox;
    }
}