namespace Calculator
{
    partial class Form1
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
            textBox = new TextBox();
            b_Change_Sign = new Button();
            b_0 = new Button();
            b_Point = new Button();
            b_Equals = new Button();
            b_1 = new Button();
            b_2 = new Button();
            b_3 = new Button();
            b_Addition = new Button();
            b_4 = new Button();
            b_5 = new Button();
            b_6 = new Button();
            b_Substraction = new Button();
            b_7 = new Button();
            b_8 = new Button();
            b_9 = new Button();
            b_Multiplication = new Button();
            b_Inverse = new Button();
            b_Division = new Button();
            b_Square_Root = new Button();
            b_Clear = new Button();
            b_Delete = new Button();
            b_Square = new Button();
            label = new Label();
            b_Percentage = new Button();
            b_Clear_Entry = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            DefaultToolStripMenuItem = new ToolStripMenuItem();
            EngineerStripMenuItem = new ToolStripMenuItem();
            b_Sin = new Button();
            b_Cos = new Button();
            b_Tg = new Button();
            b_Ctg = new Button();
            b_Exp = new Button();
            b_Ln = new Button();
            b_Sh = new Button();
            b_Ch = new Button();
            b_Th = new Button();
            b_Cth = new Button();
            b_E = new Button();
            b_Log = new Button();
            b_Asin = new Button();
            b_Acos = new Button();
            b_Atg = new Button();
            b_Actg = new Button();
            b_Pi = new Button();
            b_10_in_x = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(32, 32, 32);
            textBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(12, 27);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(550, 58);
            textBox.TabIndex = 0;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // b_Change_Sign
            // 
            b_Change_Sign.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Change_Sign.BackColor = Color.FromArgb(59, 59, 59);
            b_Change_Sign.BackgroundImageLayout = ImageLayout.None;
            b_Change_Sign.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Change_Sign.FlatAppearance.BorderSize = 0;
            b_Change_Sign.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Change_Sign.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Change_Sign.FlatStyle = FlatStyle.Flat;
            b_Change_Sign.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Change_Sign.ForeColor = Color.White;
            b_Change_Sign.Location = new Point(12, 418);
            b_Change_Sign.Margin = new Padding(10);
            b_Change_Sign.Name = "b_Change_Sign";
            b_Change_Sign.Size = new Size(57, 45);
            b_Change_Sign.TabIndex = 1;
            b_Change_Sign.Text = "+/-";
            b_Change_Sign.UseVisualStyleBackColor = false;
            b_Change_Sign.Click += b_Change_Sign_Click;
            // 
            // b_0
            // 
            b_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_0.BackColor = Color.FromArgb(59, 59, 59);
            b_0.BackgroundImageLayout = ImageLayout.None;
            b_0.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_0.FlatAppearance.BorderSize = 0;
            b_0.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_0.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_0.FlatStyle = FlatStyle.Flat;
            b_0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_0.ForeColor = Color.White;
            b_0.Location = new Point(89, 418);
            b_0.Margin = new Padding(10);
            b_0.Name = "b_0";
            b_0.Size = new Size(57, 45);
            b_0.TabIndex = 2;
            b_0.Text = "0";
            b_0.UseVisualStyleBackColor = false;
            b_0.Click += b_0_Click;
            // 
            // b_Point
            // 
            b_Point.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Point.BackColor = Color.FromArgb(59, 59, 59);
            b_Point.BackgroundImageLayout = ImageLayout.None;
            b_Point.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Point.FlatAppearance.BorderSize = 0;
            b_Point.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Point.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Point.FlatStyle = FlatStyle.Flat;
            b_Point.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Point.ForeColor = Color.White;
            b_Point.Location = new Point(166, 418);
            b_Point.Margin = new Padding(10);
            b_Point.Name = "b_Point";
            b_Point.Size = new Size(57, 45);
            b_Point.TabIndex = 3;
            b_Point.Text = ",";
            b_Point.UseVisualStyleBackColor = false;
            b_Point.Click += b_Point_Click;
            // 
            // b_Equals
            // 
            b_Equals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Equals.BackColor = Color.FromArgb(118, 185, 237);
            b_Equals.BackgroundImageLayout = ImageLayout.None;
            b_Equals.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Equals.FlatAppearance.BorderSize = 0;
            b_Equals.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Equals.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Equals.FlatStyle = FlatStyle.Flat;
            b_Equals.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Equals.ForeColor = Color.FromArgb(52, 82, 104);
            b_Equals.Location = new Point(243, 418);
            b_Equals.Margin = new Padding(10);
            b_Equals.Name = "b_Equals";
            b_Equals.Size = new Size(57, 45);
            b_Equals.TabIndex = 4;
            b_Equals.Text = "=";
            b_Equals.UseVisualStyleBackColor = false;
            b_Equals.Click += b_Equals_Click;
            // 
            // b_1
            // 
            b_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_1.BackColor = Color.FromArgb(59, 59, 59);
            b_1.BackgroundImageLayout = ImageLayout.None;
            b_1.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_1.FlatAppearance.BorderSize = 0;
            b_1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_1.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_1.FlatStyle = FlatStyle.Flat;
            b_1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_1.ForeColor = Color.White;
            b_1.Location = new Point(12, 353);
            b_1.Margin = new Padding(10);
            b_1.Name = "b_1";
            b_1.Size = new Size(57, 45);
            b_1.TabIndex = 5;
            b_1.Text = "1";
            b_1.UseVisualStyleBackColor = false;
            b_1.Click += b_1_Click;
            // 
            // b_2
            // 
            b_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_2.BackColor = Color.FromArgb(59, 59, 59);
            b_2.BackgroundImageLayout = ImageLayout.None;
            b_2.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_2.FlatAppearance.BorderSize = 0;
            b_2.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_2.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_2.FlatStyle = FlatStyle.Flat;
            b_2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_2.ForeColor = Color.White;
            b_2.Location = new Point(89, 353);
            b_2.Margin = new Padding(10);
            b_2.Name = "b_2";
            b_2.Size = new Size(57, 45);
            b_2.TabIndex = 6;
            b_2.Text = "2";
            b_2.UseVisualStyleBackColor = false;
            b_2.Click += b_2_Click;
            // 
            // b_3
            // 
            b_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_3.BackColor = Color.FromArgb(59, 59, 59);
            b_3.BackgroundImageLayout = ImageLayout.None;
            b_3.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_3.FlatAppearance.BorderSize = 0;
            b_3.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_3.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_3.FlatStyle = FlatStyle.Flat;
            b_3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_3.ForeColor = Color.White;
            b_3.Location = new Point(166, 353);
            b_3.Margin = new Padding(10);
            b_3.Name = "b_3";
            b_3.Size = new Size(57, 45);
            b_3.TabIndex = 7;
            b_3.Text = "3";
            b_3.UseVisualStyleBackColor = false;
            b_3.Click += b_3_Click;
            // 
            // b_Addition
            // 
            b_Addition.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Addition.BackColor = Color.FromArgb(50, 50, 50);
            b_Addition.BackgroundImageLayout = ImageLayout.None;
            b_Addition.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Addition.FlatAppearance.BorderSize = 0;
            b_Addition.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Addition.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Addition.FlatStyle = FlatStyle.Flat;
            b_Addition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Addition.ForeColor = Color.White;
            b_Addition.Location = new Point(243, 353);
            b_Addition.Margin = new Padding(10);
            b_Addition.Name = "b_Addition";
            b_Addition.Size = new Size(57, 45);
            b_Addition.TabIndex = 8;
            b_Addition.Text = "+";
            b_Addition.UseVisualStyleBackColor = false;
            b_Addition.Click += b_Addition_Click;
            // 
            // b_4
            // 
            b_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_4.BackColor = Color.FromArgb(59, 59, 59);
            b_4.BackgroundImageLayout = ImageLayout.None;
            b_4.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_4.FlatAppearance.BorderSize = 0;
            b_4.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_4.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_4.FlatStyle = FlatStyle.Flat;
            b_4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_4.ForeColor = Color.White;
            b_4.Location = new Point(12, 288);
            b_4.Margin = new Padding(10);
            b_4.Name = "b_4";
            b_4.Size = new Size(57, 45);
            b_4.TabIndex = 9;
            b_4.Text = "4";
            b_4.UseVisualStyleBackColor = false;
            b_4.Click += b_4_Click;
            // 
            // b_5
            // 
            b_5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_5.BackColor = Color.FromArgb(59, 59, 59);
            b_5.BackgroundImageLayout = ImageLayout.None;
            b_5.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_5.FlatAppearance.BorderSize = 0;
            b_5.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_5.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_5.FlatStyle = FlatStyle.Flat;
            b_5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_5.ForeColor = Color.White;
            b_5.Location = new Point(89, 288);
            b_5.Margin = new Padding(10);
            b_5.Name = "b_5";
            b_5.Size = new Size(57, 45);
            b_5.TabIndex = 10;
            b_5.Text = "5";
            b_5.UseVisualStyleBackColor = false;
            b_5.Click += b_5_Click;
            // 
            // b_6
            // 
            b_6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_6.BackColor = Color.FromArgb(59, 59, 59);
            b_6.BackgroundImageLayout = ImageLayout.None;
            b_6.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_6.FlatAppearance.BorderSize = 0;
            b_6.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_6.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_6.FlatStyle = FlatStyle.Flat;
            b_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_6.ForeColor = Color.White;
            b_6.Location = new Point(166, 288);
            b_6.Margin = new Padding(10);
            b_6.Name = "b_6";
            b_6.Size = new Size(57, 45);
            b_6.TabIndex = 11;
            b_6.Text = "6";
            b_6.UseVisualStyleBackColor = false;
            b_6.Click += b_6_Click;
            // 
            // b_Substraction
            // 
            b_Substraction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Substraction.BackColor = Color.FromArgb(50, 50, 50);
            b_Substraction.BackgroundImageLayout = ImageLayout.None;
            b_Substraction.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Substraction.FlatAppearance.BorderSize = 0;
            b_Substraction.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Substraction.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Substraction.FlatStyle = FlatStyle.Flat;
            b_Substraction.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Substraction.ForeColor = Color.White;
            b_Substraction.Location = new Point(243, 288);
            b_Substraction.Margin = new Padding(10);
            b_Substraction.Name = "b_Substraction";
            b_Substraction.Size = new Size(57, 45);
            b_Substraction.TabIndex = 12;
            b_Substraction.Text = "-";
            b_Substraction.UseVisualStyleBackColor = false;
            b_Substraction.Click += b_Substraction_Click;
            // 
            // b_7
            // 
            b_7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_7.BackColor = Color.FromArgb(59, 59, 59);
            b_7.BackgroundImageLayout = ImageLayout.None;
            b_7.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_7.FlatAppearance.BorderSize = 0;
            b_7.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_7.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_7.FlatStyle = FlatStyle.Flat;
            b_7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_7.ForeColor = Color.White;
            b_7.Location = new Point(12, 223);
            b_7.Margin = new Padding(10);
            b_7.Name = "b_7";
            b_7.Size = new Size(57, 45);
            b_7.TabIndex = 13;
            b_7.Text = "7";
            b_7.UseVisualStyleBackColor = false;
            b_7.Click += b_7_Click;
            // 
            // b_8
            // 
            b_8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_8.BackColor = Color.FromArgb(59, 59, 59);
            b_8.BackgroundImageLayout = ImageLayout.None;
            b_8.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_8.FlatAppearance.BorderSize = 0;
            b_8.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_8.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_8.FlatStyle = FlatStyle.Flat;
            b_8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_8.ForeColor = Color.White;
            b_8.Location = new Point(89, 223);
            b_8.Margin = new Padding(10);
            b_8.Name = "b_8";
            b_8.Size = new Size(57, 45);
            b_8.TabIndex = 14;
            b_8.Text = "8";
            b_8.UseVisualStyleBackColor = false;
            b_8.Click += b_8_Click;
            // 
            // b_9
            // 
            b_9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_9.BackColor = Color.FromArgb(59, 59, 59);
            b_9.BackgroundImageLayout = ImageLayout.None;
            b_9.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_9.FlatAppearance.BorderSize = 0;
            b_9.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_9.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_9.FlatStyle = FlatStyle.Flat;
            b_9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_9.ForeColor = Color.White;
            b_9.Location = new Point(166, 223);
            b_9.Margin = new Padding(10);
            b_9.Name = "b_9";
            b_9.Size = new Size(57, 45);
            b_9.TabIndex = 15;
            b_9.Text = "9";
            b_9.UseVisualStyleBackColor = false;
            b_9.Click += b_9_Click;
            // 
            // b_Multiplication
            // 
            b_Multiplication.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Multiplication.BackColor = Color.FromArgb(50, 50, 50);
            b_Multiplication.BackgroundImageLayout = ImageLayout.None;
            b_Multiplication.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Multiplication.FlatAppearance.BorderSize = 0;
            b_Multiplication.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Multiplication.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Multiplication.FlatStyle = FlatStyle.Flat;
            b_Multiplication.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Multiplication.ForeColor = Color.White;
            b_Multiplication.Location = new Point(243, 223);
            b_Multiplication.Margin = new Padding(10);
            b_Multiplication.Name = "b_Multiplication";
            b_Multiplication.Size = new Size(57, 45);
            b_Multiplication.TabIndex = 16;
            b_Multiplication.Text = "×";
            b_Multiplication.UseVisualStyleBackColor = false;
            b_Multiplication.Click += b_Multiplication_Click;
            // 
            // b_Inverse
            // 
            b_Inverse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Inverse.BackColor = Color.FromArgb(50, 50, 50);
            b_Inverse.BackgroundImageLayout = ImageLayout.None;
            b_Inverse.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Inverse.FlatAppearance.BorderSize = 0;
            b_Inverse.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Inverse.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Inverse.FlatStyle = FlatStyle.Flat;
            b_Inverse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Inverse.ForeColor = Color.White;
            b_Inverse.Location = new Point(12, 158);
            b_Inverse.Margin = new Padding(10);
            b_Inverse.Name = "b_Inverse";
            b_Inverse.Size = new Size(57, 45);
            b_Inverse.TabIndex = 17;
            b_Inverse.Text = "1/x";
            b_Inverse.UseVisualStyleBackColor = false;
            b_Inverse.Click += b_Inverse_Click;
            // 
            // b_Division
            // 
            b_Division.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Division.BackColor = Color.FromArgb(50, 50, 50);
            b_Division.BackgroundImageLayout = ImageLayout.None;
            b_Division.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Division.FlatAppearance.BorderSize = 0;
            b_Division.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Division.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Division.FlatStyle = FlatStyle.Flat;
            b_Division.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Division.ForeColor = Color.White;
            b_Division.Location = new Point(243, 158);
            b_Division.Margin = new Padding(10);
            b_Division.Name = "b_Division";
            b_Division.Size = new Size(57, 45);
            b_Division.TabIndex = 18;
            b_Division.Text = "÷";
            b_Division.UseVisualStyleBackColor = false;
            b_Division.Click += b_Division_Click;
            // 
            // b_Square_Root
            // 
            b_Square_Root.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Square_Root.BackColor = Color.FromArgb(50, 50, 50);
            b_Square_Root.BackgroundImageLayout = ImageLayout.None;
            b_Square_Root.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Square_Root.FlatAppearance.BorderSize = 0;
            b_Square_Root.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Square_Root.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Square_Root.FlatStyle = FlatStyle.Flat;
            b_Square_Root.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Square_Root.ForeColor = Color.White;
            b_Square_Root.Location = new Point(166, 158);
            b_Square_Root.Margin = new Padding(10);
            b_Square_Root.Name = "b_Square_Root";
            b_Square_Root.Size = new Size(57, 45);
            b_Square_Root.TabIndex = 19;
            b_Square_Root.Text = "√x";
            b_Square_Root.UseVisualStyleBackColor = false;
            b_Square_Root.Click += b_Square_Root_Click;
            // 
            // b_Clear
            // 
            b_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Clear.BackColor = Color.FromArgb(50, 50, 50);
            b_Clear.BackgroundImageLayout = ImageLayout.None;
            b_Clear.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Clear.FlatAppearance.BorderSize = 0;
            b_Clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Clear.FlatStyle = FlatStyle.Flat;
            b_Clear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Clear.ForeColor = Color.White;
            b_Clear.Location = new Point(166, 98);
            b_Clear.Margin = new Padding(10);
            b_Clear.Name = "b_Clear";
            b_Clear.Size = new Size(57, 45);
            b_Clear.TabIndex = 20;
            b_Clear.Text = "C";
            b_Clear.UseVisualStyleBackColor = false;
            b_Clear.Click += b_Clear_Click;
            // 
            // b_Delete
            // 
            b_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Delete.BackColor = Color.FromArgb(50, 50, 50);
            b_Delete.BackgroundImageLayout = ImageLayout.None;
            b_Delete.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Delete.FlatAppearance.BorderSize = 0;
            b_Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Delete.FlatStyle = FlatStyle.Flat;
            b_Delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Delete.ForeColor = Color.White;
            b_Delete.Location = new Point(243, 98);
            b_Delete.Margin = new Padding(10);
            b_Delete.Name = "b_Delete";
            b_Delete.Size = new Size(57, 45);
            b_Delete.TabIndex = 21;
            b_Delete.Text = "⌫";
            b_Delete.UseVisualStyleBackColor = false;
            b_Delete.Click += b_Delete_Click;
            // 
            // b_Square
            // 
            b_Square.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Square.BackColor = Color.FromArgb(50, 50, 50);
            b_Square.BackgroundImageLayout = ImageLayout.None;
            b_Square.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Square.FlatAppearance.BorderSize = 0;
            b_Square.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Square.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Square.FlatStyle = FlatStyle.Flat;
            b_Square.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Square.ForeColor = Color.White;
            b_Square.Location = new Point(89, 158);
            b_Square.Margin = new Padding(10);
            b_Square.Name = "b_Square";
            b_Square.Size = new Size(57, 45);
            b_Square.TabIndex = 22;
            b_Square.Text = "x²";
            b_Square.UseVisualStyleBackColor = false;
            b_Square.Click += b_Square_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(23, 33);
            label.Name = "label";
            label.Size = new Size(0, 37);
            label.TabIndex = 23;
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b_Percentage
            // 
            b_Percentage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Percentage.BackColor = Color.FromArgb(50, 50, 50);
            b_Percentage.BackgroundImageLayout = ImageLayout.None;
            b_Percentage.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Percentage.FlatAppearance.BorderSize = 0;
            b_Percentage.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Percentage.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Percentage.FlatStyle = FlatStyle.Flat;
            b_Percentage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Percentage.ForeColor = Color.White;
            b_Percentage.Location = new Point(12, 98);
            b_Percentage.Margin = new Padding(10);
            b_Percentage.Name = "b_Percentage";
            b_Percentage.Size = new Size(57, 45);
            b_Percentage.TabIndex = 24;
            b_Percentage.Text = "%";
            b_Percentage.UseVisualStyleBackColor = false;
            b_Percentage.Click += b_Percentage_Click;
            // 
            // b_Clear_Entry
            // 
            b_Clear_Entry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Clear_Entry.BackColor = Color.FromArgb(50, 50, 50);
            b_Clear_Entry.BackgroundImageLayout = ImageLayout.None;
            b_Clear_Entry.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Clear_Entry.FlatAppearance.BorderSize = 0;
            b_Clear_Entry.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Clear_Entry.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Clear_Entry.FlatStyle = FlatStyle.Flat;
            b_Clear_Entry.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Clear_Entry.ForeColor = Color.White;
            b_Clear_Entry.Location = new Point(89, 98);
            b_Clear_Entry.Margin = new Padding(10);
            b_Clear_Entry.Name = "b_Clear_Entry";
            b_Clear_Entry.Size = new Size(57, 45);
            b_Clear_Entry.TabIndex = 25;
            b_Clear_Entry.Text = "CE";
            b_Clear_Entry.UseVisualStyleBackColor = false;
            b_Clear_Entry.Click += b_Clear_Entry_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(576, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { DefaultToolStripMenuItem, EngineerStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "Режим";
            // 
            // DefaultToolStripMenuItem
            // 
            DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            DefaultToolStripMenuItem.Size = new Size(148, 22);
            DefaultToolStripMenuItem.Text = "Обычный";
            DefaultToolStripMenuItem.Click += DefaultToolStripMenuItem_Click;
            // 
            // EngineerStripMenuItem
            // 
            EngineerStripMenuItem.Name = "EngineerStripMenuItem";
            EngineerStripMenuItem.Size = new Size(148, 22);
            EngineerStripMenuItem.Text = "Инженерный";
            EngineerStripMenuItem.Click += EngineerStripMenuItem_Click;
            // 
            // b_Sin
            // 
            b_Sin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Sin.BackColor = Color.FromArgb(50, 50, 50);
            b_Sin.BackgroundImageLayout = ImageLayout.None;
            b_Sin.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Sin.FlatAppearance.BorderSize = 0;
            b_Sin.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Sin.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Sin.FlatStyle = FlatStyle.Flat;
            b_Sin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Sin.ForeColor = Color.White;
            b_Sin.Location = new Point(345, 98);
            b_Sin.Margin = new Padding(10);
            b_Sin.Name = "b_Sin";
            b_Sin.Size = new Size(57, 45);
            b_Sin.TabIndex = 32;
            b_Sin.Text = "sin";
            b_Sin.UseVisualStyleBackColor = false;
            b_Sin.Click += b_Sin_Click;
            // 
            // b_Cos
            // 
            b_Cos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Cos.BackColor = Color.FromArgb(50, 50, 50);
            b_Cos.BackgroundImageLayout = ImageLayout.None;
            b_Cos.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Cos.FlatAppearance.BorderSize = 0;
            b_Cos.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Cos.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Cos.FlatStyle = FlatStyle.Flat;
            b_Cos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Cos.ForeColor = Color.White;
            b_Cos.Location = new Point(345, 158);
            b_Cos.Margin = new Padding(10);
            b_Cos.Name = "b_Cos";
            b_Cos.Size = new Size(57, 45);
            b_Cos.TabIndex = 31;
            b_Cos.Text = "cos";
            b_Cos.UseVisualStyleBackColor = false;
            b_Cos.Click += b_Cos_Click;
            // 
            // b_Tg
            // 
            b_Tg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Tg.BackColor = Color.FromArgb(50, 50, 50);
            b_Tg.BackgroundImageLayout = ImageLayout.None;
            b_Tg.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Tg.FlatAppearance.BorderSize = 0;
            b_Tg.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Tg.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Tg.FlatStyle = FlatStyle.Flat;
            b_Tg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Tg.ForeColor = Color.White;
            b_Tg.Location = new Point(345, 223);
            b_Tg.Margin = new Padding(10);
            b_Tg.Name = "b_Tg";
            b_Tg.Size = new Size(57, 45);
            b_Tg.TabIndex = 30;
            b_Tg.Text = "tg";
            b_Tg.UseVisualStyleBackColor = false;
            b_Tg.Click += b_Tg_Click;
            // 
            // b_Ctg
            // 
            b_Ctg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Ctg.BackColor = Color.FromArgb(50, 50, 50);
            b_Ctg.BackgroundImageLayout = ImageLayout.None;
            b_Ctg.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Ctg.FlatAppearance.BorderSize = 0;
            b_Ctg.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Ctg.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Ctg.FlatStyle = FlatStyle.Flat;
            b_Ctg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Ctg.ForeColor = Color.White;
            b_Ctg.Location = new Point(345, 288);
            b_Ctg.Margin = new Padding(10);
            b_Ctg.Name = "b_Ctg";
            b_Ctg.Size = new Size(57, 45);
            b_Ctg.TabIndex = 29;
            b_Ctg.Text = "ctg";
            b_Ctg.UseVisualStyleBackColor = false;
            b_Ctg.Click += b_Ctg_Click;
            // 
            // b_Exp
            // 
            b_Exp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Exp.BackColor = Color.FromArgb(50, 50, 50);
            b_Exp.BackgroundImageLayout = ImageLayout.None;
            b_Exp.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Exp.FlatAppearance.BorderSize = 0;
            b_Exp.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Exp.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Exp.FlatStyle = FlatStyle.Flat;
            b_Exp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Exp.ForeColor = Color.White;
            b_Exp.Location = new Point(345, 353);
            b_Exp.Margin = new Padding(10);
            b_Exp.Name = "b_Exp";
            b_Exp.Size = new Size(57, 45);
            b_Exp.TabIndex = 28;
            b_Exp.Text = "exp";
            b_Exp.UseVisualStyleBackColor = false;
            b_Exp.Click += b_Exp_Click;
            // 
            // b_Ln
            // 
            b_Ln.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Ln.BackColor = Color.FromArgb(50, 50, 50);
            b_Ln.BackgroundImageLayout = ImageLayout.None;
            b_Ln.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Ln.FlatAppearance.BorderSize = 0;
            b_Ln.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Ln.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Ln.FlatStyle = FlatStyle.Flat;
            b_Ln.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Ln.ForeColor = Color.White;
            b_Ln.Location = new Point(345, 418);
            b_Ln.Margin = new Padding(10);
            b_Ln.Name = "b_Ln";
            b_Ln.Size = new Size(57, 45);
            b_Ln.TabIndex = 27;
            b_Ln.Text = "ln";
            b_Ln.UseVisualStyleBackColor = false;
            b_Ln.Click += b_Ln_Click;
            // 
            // b_Sh
            // 
            b_Sh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Sh.BackColor = Color.FromArgb(50, 50, 50);
            b_Sh.BackgroundImageLayout = ImageLayout.None;
            b_Sh.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Sh.FlatAppearance.BorderSize = 0;
            b_Sh.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Sh.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Sh.FlatStyle = FlatStyle.Flat;
            b_Sh.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Sh.ForeColor = Color.White;
            b_Sh.Location = new Point(413, 98);
            b_Sh.Margin = new Padding(10);
            b_Sh.Name = "b_Sh";
            b_Sh.Size = new Size(57, 45);
            b_Sh.TabIndex = 38;
            b_Sh.Text = "sh";
            b_Sh.UseVisualStyleBackColor = false;
            b_Sh.Click += b_Sh_Click;
            // 
            // b_Ch
            // 
            b_Ch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Ch.BackColor = Color.FromArgb(50, 50, 50);
            b_Ch.BackgroundImageLayout = ImageLayout.None;
            b_Ch.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Ch.FlatAppearance.BorderSize = 0;
            b_Ch.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Ch.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Ch.FlatStyle = FlatStyle.Flat;
            b_Ch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Ch.ForeColor = Color.White;
            b_Ch.Location = new Point(413, 158);
            b_Ch.Margin = new Padding(10);
            b_Ch.Name = "b_Ch";
            b_Ch.Size = new Size(57, 45);
            b_Ch.TabIndex = 37;
            b_Ch.Text = "ch";
            b_Ch.UseVisualStyleBackColor = false;
            b_Ch.Click += b_Ch_Click;
            // 
            // b_Th
            // 
            b_Th.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Th.BackColor = Color.FromArgb(50, 50, 50);
            b_Th.BackgroundImageLayout = ImageLayout.None;
            b_Th.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Th.FlatAppearance.BorderSize = 0;
            b_Th.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Th.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Th.FlatStyle = FlatStyle.Flat;
            b_Th.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Th.ForeColor = Color.White;
            b_Th.Location = new Point(413, 223);
            b_Th.Margin = new Padding(10);
            b_Th.Name = "b_Th";
            b_Th.Size = new Size(57, 45);
            b_Th.TabIndex = 36;
            b_Th.Text = "th";
            b_Th.UseVisualStyleBackColor = false;
            b_Th.Click += b_Th_Click;
            // 
            // b_Cth
            // 
            b_Cth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Cth.BackColor = Color.FromArgb(50, 50, 50);
            b_Cth.BackgroundImageLayout = ImageLayout.None;
            b_Cth.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Cth.FlatAppearance.BorderSize = 0;
            b_Cth.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Cth.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Cth.FlatStyle = FlatStyle.Flat;
            b_Cth.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Cth.ForeColor = Color.White;
            b_Cth.Location = new Point(413, 288);
            b_Cth.Margin = new Padding(10);
            b_Cth.Name = "b_Cth";
            b_Cth.Size = new Size(57, 45);
            b_Cth.TabIndex = 35;
            b_Cth.Text = "cth";
            b_Cth.UseVisualStyleBackColor = false;
            b_Cth.Click += b_Cth_Click;
            // 
            // b_E
            // 
            b_E.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_E.BackColor = Color.FromArgb(50, 50, 50);
            b_E.BackgroundImageLayout = ImageLayout.None;
            b_E.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_E.FlatAppearance.BorderSize = 0;
            b_E.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_E.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_E.FlatStyle = FlatStyle.Flat;
            b_E.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_E.ForeColor = Color.White;
            b_E.Location = new Point(413, 353);
            b_E.Margin = new Padding(10);
            b_E.Name = "b_E";
            b_E.Size = new Size(57, 45);
            b_E.TabIndex = 34;
            b_E.Text = "e";
            b_E.UseVisualStyleBackColor = false;
            b_E.Click += b_E_Click;
            // 
            // b_Log
            // 
            b_Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Log.BackColor = Color.FromArgb(50, 50, 50);
            b_Log.BackgroundImageLayout = ImageLayout.None;
            b_Log.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Log.FlatAppearance.BorderSize = 0;
            b_Log.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Log.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Log.FlatStyle = FlatStyle.Flat;
            b_Log.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Log.ForeColor = Color.White;
            b_Log.Location = new Point(413, 418);
            b_Log.Margin = new Padding(10);
            b_Log.Name = "b_Log";
            b_Log.Size = new Size(57, 45);
            b_Log.TabIndex = 33;
            b_Log.Text = "log";
            b_Log.UseVisualStyleBackColor = false;
            b_Log.Click += b_Log_Click;
            // 
            // b_Asin
            // 
            b_Asin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Asin.BackColor = Color.FromArgb(50, 50, 50);
            b_Asin.BackgroundImageLayout = ImageLayout.None;
            b_Asin.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Asin.FlatAppearance.BorderSize = 0;
            b_Asin.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Asin.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Asin.FlatStyle = FlatStyle.Flat;
            b_Asin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Asin.ForeColor = Color.White;
            b_Asin.Location = new Point(482, 98);
            b_Asin.Margin = new Padding(10);
            b_Asin.Name = "b_Asin";
            b_Asin.Size = new Size(71, 45);
            b_Asin.TabIndex = 44;
            b_Asin.Text = "asin";
            b_Asin.UseVisualStyleBackColor = false;
            b_Asin.Click += b_Asin_Click;
            // 
            // b_Acos
            // 
            b_Acos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Acos.BackColor = Color.FromArgb(50, 50, 50);
            b_Acos.BackgroundImageLayout = ImageLayout.None;
            b_Acos.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Acos.FlatAppearance.BorderSize = 0;
            b_Acos.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Acos.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Acos.FlatStyle = FlatStyle.Flat;
            b_Acos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Acos.ForeColor = Color.White;
            b_Acos.Location = new Point(482, 158);
            b_Acos.Margin = new Padding(10);
            b_Acos.Name = "b_Acos";
            b_Acos.Size = new Size(71, 45);
            b_Acos.TabIndex = 43;
            b_Acos.Text = "acos";
            b_Acos.UseVisualStyleBackColor = false;
            b_Acos.Click += b_Acos_Click;
            // 
            // b_Atg
            // 
            b_Atg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Atg.BackColor = Color.FromArgb(50, 50, 50);
            b_Atg.BackgroundImageLayout = ImageLayout.None;
            b_Atg.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Atg.FlatAppearance.BorderSize = 0;
            b_Atg.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Atg.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Atg.FlatStyle = FlatStyle.Flat;
            b_Atg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Atg.ForeColor = Color.White;
            b_Atg.Location = new Point(482, 223);
            b_Atg.Margin = new Padding(10);
            b_Atg.Name = "b_Atg";
            b_Atg.Size = new Size(70, 45);
            b_Atg.TabIndex = 42;
            b_Atg.Text = "atg";
            b_Atg.UseVisualStyleBackColor = false;
            b_Atg.Click += b_Atg_Click;
            // 
            // b_Actg
            // 
            b_Actg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Actg.BackColor = Color.FromArgb(50, 50, 50);
            b_Actg.BackgroundImageLayout = ImageLayout.None;
            b_Actg.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Actg.FlatAppearance.BorderSize = 0;
            b_Actg.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Actg.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Actg.FlatStyle = FlatStyle.Flat;
            b_Actg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Actg.ForeColor = Color.White;
            b_Actg.Location = new Point(482, 288);
            b_Actg.Margin = new Padding(10);
            b_Actg.Name = "b_Actg";
            b_Actg.Size = new Size(71, 45);
            b_Actg.TabIndex = 41;
            b_Actg.Text = "actg";
            b_Actg.UseVisualStyleBackColor = false;
            b_Actg.Click += b_Actg_Click;
            // 
            // b_Pi
            // 
            b_Pi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_Pi.BackColor = Color.FromArgb(50, 50, 50);
            b_Pi.BackgroundImageLayout = ImageLayout.None;
            b_Pi.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_Pi.FlatAppearance.BorderSize = 0;
            b_Pi.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_Pi.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_Pi.FlatStyle = FlatStyle.Flat;
            b_Pi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_Pi.ForeColor = Color.White;
            b_Pi.Location = new Point(482, 353);
            b_Pi.Margin = new Padding(10);
            b_Pi.Name = "b_Pi";
            b_Pi.Size = new Size(70, 45);
            b_Pi.TabIndex = 40;
            b_Pi.Text = "π";
            b_Pi.UseVisualStyleBackColor = false;
            b_Pi.Click += b_Pi_Click;
            // 
            // b_10_in_x
            // 
            b_10_in_x.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_10_in_x.BackColor = Color.FromArgb(50, 50, 50);
            b_10_in_x.BackgroundImageLayout = ImageLayout.None;
            b_10_in_x.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_10_in_x.FlatAppearance.BorderSize = 0;
            b_10_in_x.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_10_in_x.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_10_in_x.FlatStyle = FlatStyle.Flat;
            b_10_in_x.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b_10_in_x.ForeColor = Color.White;
            b_10_in_x.Location = new Point(482, 418);
            b_10_in_x.Margin = new Padding(10);
            b_10_in_x.Name = "b_10_in_x";
            b_10_in_x.Size = new Size(71, 45);
            b_10_in_x.TabIndex = 39;
            b_10_in_x.Text = "10^x";
            b_10_in_x.UseVisualStyleBackColor = false;
            b_10_in_x.Click += b_10_in_x_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(576, 475);
            Controls.Add(b_Asin);
            Controls.Add(b_Acos);
            Controls.Add(b_Atg);
            Controls.Add(b_Actg);
            Controls.Add(b_Pi);
            Controls.Add(b_10_in_x);
            Controls.Add(b_Sh);
            Controls.Add(b_Ch);
            Controls.Add(b_Th);
            Controls.Add(b_Cth);
            Controls.Add(b_E);
            Controls.Add(b_Log);
            Controls.Add(b_Sin);
            Controls.Add(b_Cos);
            Controls.Add(b_Tg);
            Controls.Add(b_Ctg);
            Controls.Add(b_Exp);
            Controls.Add(b_Ln);
            Controls.Add(b_Clear_Entry);
            Controls.Add(b_Percentage);
            Controls.Add(label);
            Controls.Add(b_Square);
            Controls.Add(b_Delete);
            Controls.Add(b_Clear);
            Controls.Add(b_Square_Root);
            Controls.Add(b_Division);
            Controls.Add(b_Inverse);
            Controls.Add(b_Multiplication);
            Controls.Add(b_9);
            Controls.Add(b_8);
            Controls.Add(b_7);
            Controls.Add(b_Substraction);
            Controls.Add(b_6);
            Controls.Add(b_5);
            Controls.Add(b_4);
            Controls.Add(b_Addition);
            Controls.Add(b_3);
            Controls.Add(b_2);
            Controls.Add(b_1);
            Controls.Add(b_Equals);
            Controls.Add(b_Point);
            Controls.Add(b_0);
            Controls.Add(b_Change_Sign);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Калькулятор";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button b_Change_Sign;
        private Button b_0;
        private Button b_Point;
        private Button b_Equals;
        private Button b_1;
        private Button b_2;
        private Button b_3;
        private Button b_Addition;
        private Button b_4;
        private Button b_5;
        private Button b_6;
        private Button b_Substraction;
        private Button b_7;
        private Button b_8;
        private Button b_9;
        private Button b_Multiplication;
        private Button b_Inverse;
        private Button b_Division;
        private Button b_Square_Root;
        private Button b_Clear;
        private Button b_Delete;
        private Button b_Square;
        private Label label;
        private Button b_Percentage;
        private Button b_Clear_Entry;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem DefaultToolStripMenuItem;
        private ToolStripMenuItem EngineerStripMenuItem;
        private Button b_Sin;
        private Button b_Cos;
        private Button b_Tg;
        private Button b_Ctg;
        private Button b_Exp;
        private Button b_Ln;
        private Button b_Sh;
        private Button b_Ch;
        private Button b_Th;
        private Button b_Cth;
        private Button b_E;
        private Button b_Log;
        private Button b_Asin;
        private Button b_Acos;
        private Button b_Atg;
        private Button b_Actg;
        private Button b_Pi;
        private Button b_10_in_x;
    }
}
