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
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(32, 32, 32);
            textBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(12, 22);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(288, 58);
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
            b_Clear.Location = new Point(166, 93);
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
            b_Delete.Location = new Point(243, 93);
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
            b_Percentage.Location = new Point(12, 93);
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
            b_Clear_Entry.Location = new Point(89, 93);
            b_Clear_Entry.Margin = new Padding(10);
            b_Clear_Entry.Name = "b_Clear_Entry";
            b_Clear_Entry.Size = new Size(57, 45);
            b_Clear_Entry.TabIndex = 25;
            b_Clear_Entry.Text = "CE";
            b_Clear_Entry.UseVisualStyleBackColor = false;
            b_Clear_Entry.Click += b_Clear_Entry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(314, 475);
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
            Name = "Form1";
            Text = "Калькулятор";
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
    }
}
