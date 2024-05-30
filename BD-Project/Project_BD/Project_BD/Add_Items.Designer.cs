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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            textBox_Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_Description = new TextBox();
            button2 = new Button();
            label5 = new Label();
            textBox_UR = new TextBox();
            DropBox = new ComboBox();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3947372F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6052628F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 4, 2);
            tableLayoutPanel1.Controls.Add(button2, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_UR, 1, 4);
            tableLayoutPanel1.Controls.Add(DropBox, 2, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 3, 2);
            tableLayoutPanel1.Location = new Point(8, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.06977F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.930233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(15, 15);
            button1.Margin = new Padding(15, 15, 3, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 1, 0, 0);
            button1.Size = new Size(94, 46);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(115, 89);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(129, 23);
            textBox_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(160, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(298, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Award";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(435, 68);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Owner";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(557, 68);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // textBox_Description
            // 
            textBox_Description.Anchor = AnchorStyles.Top;
            textBox_Description.Location = new Point(530, 89);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(122, 23);
            textBox_Description.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(714, 15);
            button2.Margin = new Padding(3, 15, 15, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 1, 0, 0);
            button2.Size = new Size(71, 46);
            button2.TabIndex = 2;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(138, 126);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 11;
            label5.Text = "Use Requisites";
            // 
            // textBox_UR
            // 
            textBox_UR.Anchor = AnchorStyles.Top;
            textBox_UR.Location = new Point(115, 161);
            textBox_UR.Name = "textBox_UR";
            textBox_UR.Size = new Size(129, 23);
            textBox_UR.TabIndex = 12;
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.Top;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(257, 89);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(124, 23);
            DropBox.TabIndex = 23;
            DropBox.Text = "Dungeon";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 24;
            comboBox1.Text = "Character";
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