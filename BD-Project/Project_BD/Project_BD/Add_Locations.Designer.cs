namespace Project_BD
{
    partial class Add_Locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Locations));
            tableLayoutPanel1 = new TableLayoutPanel();
            Cancel = new Button();
            label1 = new Label();
            Confirm = new Button();
            label5 = new Label();
            textBox_Name = new TextBox();
            textBox_Area = new TextBox();
            label4 = new Label();
            textBox_Description = new TextBox();
            label8 = new Label();
            textBox_POI = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881632F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853088F));
            tableLayoutPanel1.Controls.Add(Cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox_Area, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 4, 2);
            tableLayoutPanel1.Controls.Add(label8, 4, 3);
            tableLayoutPanel1.Controls.Add(textBox_POI, 4, 4);
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
            tableLayoutPanel1.TabIndex = 5;
            // 
            // Cancel
            // 
            Cancel.BackgroundImage = (Image)resources.GetObject("Cancel.BackgroundImage");
            Cancel.BackgroundImageLayout = ImageLayout.Stretch;
            Cancel.Cursor = Cursors.Hand;
            Cancel.ForeColor = SystemColors.ControlText;
            Cancel.Location = new Point(15, 15);
            Cancel.Margin = new Padding(15, 15, 3, 3);
            Cancel.Name = "Cancel";
            Cancel.Padding = new Padding(0, 1, 0, 0);
            Cancel.Size = new Size(52, 45);
            Cancel.TabIndex = 0;
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(202, 98);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 4;
            label1.Text = "Area";
            // 
            // Confirm
            // 
            Confirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Confirm.Cursor = Cursors.Hand;
            Confirm.Font = new Font("Segoe UI", 10F);
            Confirm.ForeColor = SystemColors.ControlText;
            Confirm.Location = new Point(687, 15);
            Confirm.Margin = new Padding(3, 15, 15, 3);
            Confirm.Name = "Confirm";
            Confirm.Padding = new Padding(0, 1, 0, 0);
            Confirm.Size = new Size(98, 50);
            Confirm.TabIndex = 2;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(197, 246);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Name, 2);
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Location = new Point(117, 299);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(222, 23);
            textBox_Name.TabIndex = 12;
            // 
            // textBox_Area
            // 
            textBox_Area.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Area, 2);
            textBox_Area.Cursor = Cursors.IBeam;
            textBox_Area.Location = new Point(117, 151);
            textBox_Area.Name = "textBox_Area";
            textBox_Area.Size = new Size(222, 23);
            textBox_Area.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(516, 98);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // textBox_Description
            // 
            textBox_Description.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Description, 2);
            textBox_Description.Cursor = Cursors.IBeam;
            textBox_Description.Location = new Point(459, 151);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(222, 23);
            textBox_Description.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label8, 2);
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(493, 246);
            label8.Name = "label8";
            label8.Size = new Size(153, 25);
            label8.TabIndex = 18;
            label8.Text = "Points of interest";
            // 
            // textBox_POI
            // 
            textBox_POI.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_POI, 2);
            textBox_POI.Cursor = Cursors.IBeam;
            textBox_POI.Location = new Point(459, 299);
            textBox_POI.Name = "textBox_POI";
            textBox_POI.Size = new Size(222, 23);
            textBox_POI.TabIndex = 17;
            // 
            // Add_Locations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Locations";
            Text = "Add_Locations";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Cancel;
        private Label label1;
        private Label label2;
        private TextBox textBox_Attacks;
        private Label label3;
        private TextBox textBox_Attributes;
        private Label label4;
        private TextBox textBox_Description;
        private Label label5;
        private TextBox textBox_Name;
        private Label label6;
        private TextBox textBox_Weakness;
        private Label label7;
        private TextBox textBox_Location;
        private TextBox textBox_POI;
        private Label label8;
        private TextBox textBox_Area;
        private Button Confirm;
    }
}