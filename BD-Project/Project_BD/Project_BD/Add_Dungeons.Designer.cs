namespace Project_BD
{
    partial class Add_Dungeons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Dungeons));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            textBox_Name = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label7 = new Label();
            textBox_Area = new TextBox();
            label2 = new Label();
            textBox_MainBoss = new TextBox();
            label3 = new Label();
            DropBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 6, 0);
            tableLayoutPanel1.Controls.Add(label7, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox_Area, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox_MainBoss, 4, 4);
            tableLayoutPanel1.Controls.Add(label3, 4, 3);
            tableLayoutPanel1.Controls.Add(DropBox, 4, 2);
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
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Name, 2);
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Location = new Point(117, 153);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(222, 23);
            textBox_Name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(197, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 4;
            label1.Text = "Name";
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
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label7, 2);
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(528, 100);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 15;
            label7.Text = "Location";
            // 
            // textBox_Area
            // 
            textBox_Area.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_Area, 2);
            textBox_Area.Cursor = Cursors.IBeam;
            textBox_Area.Location = new Point(117, 303);
            textBox_Area.Name = "textBox_Area";
            textBox_Area.Size = new Size(222, 23);
            textBox_Area.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(202, 250);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 5;
            label2.Text = "Area";
            // 
            // textBox_MainBoss
            // 
            textBox_MainBoss.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(textBox_MainBoss, 2);
            textBox_MainBoss.Cursor = Cursors.IBeam;
            textBox_MainBoss.Location = new Point(459, 303);
            textBox_MainBoss.Name = "textBox_MainBoss";
            textBox_MainBoss.Size = new Size(222, 23);
            textBox_MainBoss.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(523, 250);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 7;
            label3.Text = "MainBoss";
            // 
            // DropBox
            // 
            DropBox.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(DropBox, 2);
            DropBox.Cursor = Cursors.Hand;
            DropBox.FormattingEnabled = true;
            DropBox.Location = new Point(459, 153);
            DropBox.Name = "DropBox";
            DropBox.Size = new Size(222, 23);
            DropBox.TabIndex = 22;
            DropBox.Text = "Location";
            // 
            // Add_Dungeons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Dungeons";
            Text = "Add_Dungeons";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox textBox_Name;
        private Label label1;
        private Button button2;
        private Label label7;
        private TextBox textBox_Area;
        private Label label2;
        private TextBox textBox_MainBoss;
        private Label label3;
        private ComboBox DropBox;
    }
}