/*

namespace Project_BD
{
    partial class Add_General
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
            label2 = new Label();
            textBox_Attacks = new TextBox();
            label3 = new Label();
            textBox_Attributes = new TextBox();
            label4 = new Label();
            textBox_Description = new TextBox();
            Confirm = new Button();
            label5 = new Label();
            textBox_Class = new TextBox();
            label6 = new Label();
            textBox_Weakness = new TextBox();
            label7 = new Label();
            textBox_Location = new TextBox();
            textBox_Level = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
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
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox_Attacks, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox_Attributes, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Description, 4, 2);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_Class, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox_Weakness, 2, 4);
            tableLayoutPanel1.Controls.Add(label7, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox_Location, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox_Level, 4, 4);
            tableLayoutPanel1.Controls.Add(label8, 4, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
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
            label2.Location = new Point(296, 68);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Attacks";
            // 
            // textBox_Attacks
            // 
            textBox_Attacks.Anchor = AnchorStyles.Top;
            textBox_Attacks.Location = new Point(255, 89);
            textBox_Attacks.Name = "textBox_Attacks";
            textBox_Attacks.Size = new Size(127, 23);
            textBox_Attacks.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(426, 68);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Attributes";
            // 
            // textBox_Attributes
            // 
            textBox_Attributes.Anchor = AnchorStyles.Top;
            textBox_Attributes.Location = new Point(395, 89);
            textBox_Attributes.Name = "textBox_Attributes";
            textBox_Attributes.Size = new Size(122, 23);
            textBox_Attributes.TabIndex = 8;
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
            label5.Location = new Point(162, 126);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "Class";
            // 
            // textBox_Class
            // 
            textBox_Class.Anchor = AnchorStyles.Top;
            textBox_Class.Location = new Point(115, 161);
            textBox_Class.Name = "textBox_Class";
            textBox_Class.Size = new Size(129, 23);
            textBox_Class.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(289, 126);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 13;
            label6.Text = "Weakness";
            // 
            // textBox_Weakness
            // 
            textBox_Weakness.Anchor = AnchorStyles.Top;
            textBox_Weakness.Location = new Point(255, 161);
            textBox_Weakness.Name = "textBox_Weakness";
            textBox_Weakness.Size = new Size(127, 23);
            textBox_Weakness.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(429, 126);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 15;
            label7.Text = "Location";
            // 
            // textBox_Location
            // 
            textBox_Location.Anchor = AnchorStyles.Top;
            textBox_Location.Location = new Point(395, 161);
            textBox_Location.Name = "textBox_Location";
            textBox_Location.Size = new Size(122, 23);
            textBox_Location.TabIndex = 16;
            // 
            // textBox_Level
            // 
            textBox_Level.Anchor = AnchorStyles.Top;
            textBox_Level.Location = new Point(530, 161);
            textBox_Level.Name = "textBox_Level";
            textBox_Level.Size = new Size(122, 23);
            textBox_Level.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(574, 126);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 18;
            label8.Text = "Level";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(115, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 19;
            // 
            // Add_General
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_General";
            Text = "Add_General";
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
        private Button Confirm;
        private Label label5;
        private TextBox textBox_Class;
        private Label label6;
        private TextBox textBox_Weakness;
        private Label label7;
        private TextBox textBox_Location;
        private TextBox textBox_Level;
        private Label label8;
        private TextBox textBox1;
    }
}
*/