﻿
namespace Project_BD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            ClearButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(LoginButton, 2);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 6;
            LoginButton.Font = new Font("Segoe UI", 14F);
            LoginButton.Location = new Point(451, 543);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(353, 60);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Location = new Point(451, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(323, 303);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Location = new Point(451, 403);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(486, 25);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(323, 403);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click_2;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Left;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatAppearance.BorderSize = 6;
            ClearButton.Font = new Font("Segoe UI", 10F);
            ClearButton.Location = new Point(943, 349);
            ClearButton.Name = "ClearButton";
            tableLayoutPanel1.SetRowSpan(ClearButton, 2);
            ClearButton.Size = new Size(89, 34);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3933735F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1564341F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.6695442F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3903217F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3903217F));
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(LoginButton, 2, 3);
            tableLayoutPanel1.Controls.Add(ClearButton, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.12188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.70329F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.70329F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4715462F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Welcome";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button ClearButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
