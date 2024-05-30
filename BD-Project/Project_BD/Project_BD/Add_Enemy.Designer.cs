namespace Project_BD
{
    partial class Add_Enemy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Enemy));
            tableLayoutPanel1 = new TableLayoutPanel();
            Cancel = new Button();
            Confirm = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.Controls.Add(Cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 8;
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
            Confirm.Size = new Size(98, 57);
            Confirm.TabIndex = 2;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(368, 155);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(comboBox1, 3);
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 23);
            comboBox1.TabIndex = 25;
            comboBox1.Text = "Character";
            // 
            // Add_Enemy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Enemy";
            Text = "Add_Enemy";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Cancel;
        private Button Confirm;
        private Label label4;
        private ComboBox comboBox1;
    }
}