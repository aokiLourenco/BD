namespace Project_BD
{
    partial class Edit_Locations
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
            Cancel = new Button();
            label1 = new Label();
            label4 = new Label();
            textBox_Description = new TextBox();
            Confirm = new Button();
            label5 = new Label();
            textBox_Name = new TextBox();
            textBox_POI = new TextBox();
            label8 = new Label();
            textBox_Area = new TextBox();
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
            tableLayoutPanel1.Controls.Add(Cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 4, 2);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox_POI, 4, 4);
            tableLayoutPanel1.Controls.Add(label8, 4, 3);
            tableLayoutPanel1.Controls.Add(textBox_Area, 1, 2);
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
            tableLayoutPanel1.TabIndex = 6;
            // 
            // Cancel
            // 
            Cancel.ForeColor = SystemColors.ControlText;
            Cancel.Location = new Point(15, 15);
            Cancel.Margin = new Padding(15, 15, 3, 3);
            Cancel.Name = "Cancel";
            Cancel.Padding = new Padding(0, 1, 0, 0);
            Cancel.Size = new Size(94, 46);
            Cancel.TabIndex = 0;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(164, 68);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Area";
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
            // Confirm
            // 
            Confirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Confirm.ForeColor = SystemColors.ControlText;
            Confirm.Location = new Point(714, 15);
            Confirm.Margin = new Padding(3, 15, 15, 3);
            Confirm.Name = "Confirm";
            Confirm.Padding = new Padding(0, 1, 0, 0);
            Confirm.Size = new Size(71, 46);
            Confirm.TabIndex = 2;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(160, 126);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            textBox_Name.Location = new Point(115, 161);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(129, 23);
            textBox_Name.TabIndex = 12;
            // 
            // textBox_POI
            // 
            textBox_POI.Anchor = AnchorStyles.Top;
            textBox_POI.Location = new Point(530, 161);
            textBox_POI.Name = "textBox_POI";
            textBox_POI.Size = new Size(122, 23);
            textBox_POI.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(543, 126);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 18;
            label8.Text = "Points of interest";
            // 
            // textBox_Area
            // 
            textBox_Area.Anchor = AnchorStyles.Top;
            textBox_Area.Location = new Point(115, 89);
            textBox_Area.Name = "textBox_Area";
            textBox_Area.Size = new Size(129, 23);
            textBox_Area.TabIndex = 19;
            // 
            // Edit_Locations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Edit_Locations";
            Text = "Edit_Locations";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Cancel;
        private Label label1;
        private Label label4;
        private TextBox textBox_Description;
        private Button Confirm;
        private Label label5;
        private TextBox textBox_Name;
        private TextBox textBox_POI;
        private Label label8;
        private TextBox textBox_Area;
    }
}