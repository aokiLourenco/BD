namespace Project_BD
{
    partial class Add_Crafts
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
            label4 = new Label();
            Confirm = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label8, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 4, 2);
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 2);
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
            tableLayoutPanel1.TabIndex = 7;
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
            Cancel.Click += Cancel_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(571, 68);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Name";
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
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(148, 68);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 18;
            label8.Text = "UsedItems";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(529, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Material";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(117, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(124, 23);
            comboBox2.TabIndex = 27;
            comboBox2.Text = "Items";
            // 
            // Add_Crafts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Crafts";
            Text = "Add_Crafts";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Cancel;
        private Label label4;
        private Button Confirm;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}