namespace Project_BD
{
    partial class Add_CraftingMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_CraftingMaterials));
            tableLayoutPanel1 = new TableLayoutPanel();
            Cancel = new Button();
            label4 = new Label();
            textBox_Source = new TextBox();
            Confirm = new Button();
            label8 = new Label();
            DropBox = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            textBox_Quantity = new TextBox();
            textBox_CraftingUse = new TextBox();
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
            tableLayoutPanel1.Controls.Add(Cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Source, 4, 2);
            tableLayoutPanel1.Controls.Add(Confirm, 6, 0);
            tableLayoutPanel1.Controls.Add(label8, 4, 3);
            tableLayoutPanel1.Controls.Add(DropBox, 4, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_Quantity, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox_CraftingUse, 1, 4);
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
            tableLayoutPanel1.TabIndex = 6;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(535, 100);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 9;
            label4.Text = "Source";
            // 
            // textBox_Source
            // 
            textBox_Source.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Source, 2);
            textBox_Source.Cursor = Cursors.IBeam;
            textBox_Source.Location = new Point(459, 153);
            textBox_Source.Name = "textBox_Source";
            textBox_Source.Size = new Size(222, 23);
            textBox_Source.TabIndex = 10;
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
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label8, 2);
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(518, 250);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 18;
            label8.Text = "Used Items";
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(DropBox, 2);
            DropBox.Cursor = Cursors.Hand;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(459, 303);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(222, 23);
            DropBox.TabIndex = 23;
            DropBox.Text = "Item";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(186, 100);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 4;
            label1.Text = "Quantity";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(170, 250);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 11;
            label5.Text = "Crafting Use";
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Quantity, 2);
            textBox_Quantity.Cursor = Cursors.IBeam;
            textBox_Quantity.Location = new Point(117, 153);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(222, 23);
            textBox_Quantity.TabIndex = 19;
            // 
            // textBox_CraftingUse
            // 
            textBox_CraftingUse.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_CraftingUse, 2);
            textBox_CraftingUse.Cursor = Cursors.IBeam;
            textBox_CraftingUse.Location = new Point(117, 303);
            textBox_CraftingUse.Name = "textBox_CraftingUse";
            textBox_CraftingUse.Size = new Size(222, 23);
            textBox_CraftingUse.TabIndex = 12;
            // 
            // Add_CraftingMaterials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_CraftingMaterials";
            Text = "Add_CraftingMaterials";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Cancel;
        private Label label1;
        private Label label4;
        private TextBox textBox_Source;
        private Button Confirm;
        private Label label5;
        private TextBox textBox_CraftingUse;
        private Label label8;
        private TextBox textBox_Quantity;
        private ComboBox DropBox;
    }
}