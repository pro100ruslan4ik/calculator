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
            textBox1 = new TextBox();
            b_plus_minus = new Button();
            b_0 = new Button();
            b_point = new Button();
            b_equals = new Button();
            b_1 = new Button();
            b_2 = new Button();
            b_3 = new Button();
            b_plus = new Button();
            b_4 = new Button();
            b_5 = new Button();
            b_6 = new Button();
            b_minus = new Button();
            b_7 = new Button();
            b_8 = new Button();
            b_9 = new Button();
            b_multi = new Button();
            b_procent = new Button();
            b_division = new Button();
            b_root = new Button();
            b_clear = new Button();
            b_delete = new Button();
            b_squere = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 58);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // b_plus_minus
            // 
            b_plus_minus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_plus_minus.BackColor = Color.FromArgb(59, 59, 59);
            b_plus_minus.BackgroundImageLayout = ImageLayout.None;
            b_plus_minus.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_plus_minus.FlatAppearance.BorderSize = 0;
            b_plus_minus.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_plus_minus.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_plus_minus.FlatStyle = FlatStyle.Flat;
            b_plus_minus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_plus_minus.ForeColor = Color.White;
            b_plus_minus.Location = new Point(12, 418);
            b_plus_minus.Margin = new Padding(10);
            b_plus_minus.Name = "b_plus_minus";
            b_plus_minus.Size = new Size(57, 45);
            b_plus_minus.TabIndex = 1;
            b_plus_minus.Text = "+/-";
            b_plus_minus.UseVisualStyleBackColor = false;
            b_plus_minus.Click += b_plus_minus_Click;
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
            b_0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // b_point
            // 
            b_point.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_point.BackColor = Color.FromArgb(59, 59, 59);
            b_point.BackgroundImageLayout = ImageLayout.None;
            b_point.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_point.FlatAppearance.BorderSize = 0;
            b_point.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_point.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_point.FlatStyle = FlatStyle.Flat;
            b_point.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_point.ForeColor = Color.White;
            b_point.Location = new Point(166, 418);
            b_point.Margin = new Padding(10);
            b_point.Name = "b_point";
            b_point.Size = new Size(57, 45);
            b_point.TabIndex = 3;
            b_point.Text = ",";
            b_point.UseVisualStyleBackColor = false;
            b_point.Click += b_point_Click;
            // 
            // b_equals
            // 
            b_equals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_equals.BackColor = Color.FromArgb(118, 185, 237);
            b_equals.BackgroundImageLayout = ImageLayout.None;
            b_equals.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_equals.FlatAppearance.BorderSize = 0;
            b_equals.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_equals.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_equals.FlatStyle = FlatStyle.Flat;
            b_equals.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_equals.ForeColor = Color.FromArgb(52, 82, 104);
            b_equals.Location = new Point(243, 418);
            b_equals.Margin = new Padding(10);
            b_equals.Name = "b_equals";
            b_equals.Size = new Size(57, 45);
            b_equals.TabIndex = 4;
            b_equals.Text = "=";
            b_equals.UseVisualStyleBackColor = false;
            b_equals.Click += b_equals_Click;
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
            b_1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // b_plus
            // 
            b_plus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_plus.BackColor = Color.FromArgb(50, 50, 50);
            b_plus.BackgroundImageLayout = ImageLayout.None;
            b_plus.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_plus.FlatAppearance.BorderSize = 0;
            b_plus.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_plus.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_plus.FlatStyle = FlatStyle.Flat;
            b_plus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_plus.ForeColor = Color.White;
            b_plus.Location = new Point(243, 353);
            b_plus.Margin = new Padding(10);
            b_plus.Name = "b_plus";
            b_plus.Size = new Size(57, 45);
            b_plus.TabIndex = 8;
            b_plus.Text = "+";
            b_plus.UseVisualStyleBackColor = false;
            b_plus.Click += b_plus_Click;
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
            b_4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // b_minus
            // 
            b_minus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_minus.BackColor = Color.FromArgb(50, 50, 50);
            b_minus.BackgroundImageLayout = ImageLayout.None;
            b_minus.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_minus.FlatAppearance.BorderSize = 0;
            b_minus.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_minus.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_minus.FlatStyle = FlatStyle.Flat;
            b_minus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_minus.ForeColor = Color.White;
            b_minus.Location = new Point(243, 288);
            b_minus.Margin = new Padding(10);
            b_minus.Name = "b_minus";
            b_minus.Size = new Size(57, 45);
            b_minus.TabIndex = 12;
            b_minus.Text = "-";
            b_minus.UseVisualStyleBackColor = false;
            b_minus.Click += b_minus_Click;
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
            b_7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            b_9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // b_multi
            // 
            b_multi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_multi.BackColor = Color.FromArgb(50, 50, 50);
            b_multi.BackgroundImageLayout = ImageLayout.None;
            b_multi.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_multi.FlatAppearance.BorderSize = 0;
            b_multi.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_multi.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_multi.FlatStyle = FlatStyle.Flat;
            b_multi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_multi.ForeColor = Color.White;
            b_multi.Location = new Point(243, 223);
            b_multi.Margin = new Padding(10);
            b_multi.Name = "b_multi";
            b_multi.Size = new Size(57, 45);
            b_multi.TabIndex = 16;
            b_multi.Text = "×";
            b_multi.UseVisualStyleBackColor = false;
            b_multi.Click += b_multi_Click;
            // 
            // b_procent
            // 
            b_procent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_procent.BackColor = Color.FromArgb(50, 50, 50);
            b_procent.BackgroundImageLayout = ImageLayout.None;
            b_procent.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_procent.FlatAppearance.BorderSize = 0;
            b_procent.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_procent.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_procent.FlatStyle = FlatStyle.Flat;
            b_procent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_procent.ForeColor = Color.White;
            b_procent.Location = new Point(12, 158);
            b_procent.Margin = new Padding(10);
            b_procent.Name = "b_procent";
            b_procent.Size = new Size(57, 45);
            b_procent.TabIndex = 17;
            b_procent.Text = "%";
            b_procent.UseVisualStyleBackColor = false;
            b_procent.Click += b_procent_Click;
            // 
            // b_division
            // 
            b_division.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_division.BackColor = Color.FromArgb(50, 50, 50);
            b_division.BackgroundImageLayout = ImageLayout.None;
            b_division.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_division.FlatAppearance.BorderSize = 0;
            b_division.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_division.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_division.FlatStyle = FlatStyle.Flat;
            b_division.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_division.ForeColor = Color.White;
            b_division.Location = new Point(243, 158);
            b_division.Margin = new Padding(10);
            b_division.Name = "b_division";
            b_division.Size = new Size(57, 45);
            b_division.TabIndex = 18;
            b_division.Text = "÷";
            b_division.UseVisualStyleBackColor = false;
            b_division.Click += b_division_Click;
            // 
            // b_root
            // 
            b_root.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_root.BackColor = Color.FromArgb(50, 50, 50);
            b_root.BackgroundImageLayout = ImageLayout.None;
            b_root.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_root.FlatAppearance.BorderSize = 0;
            b_root.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_root.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_root.FlatStyle = FlatStyle.Flat;
            b_root.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_root.ForeColor = Color.White;
            b_root.Location = new Point(166, 158);
            b_root.Margin = new Padding(10);
            b_root.Name = "b_root";
            b_root.Size = new Size(57, 45);
            b_root.TabIndex = 19;
            b_root.Text = "√";
            b_root.UseVisualStyleBackColor = false;
            b_root.Click += b_root_Click;
            // 
            // b_clear
            // 
            b_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_clear.BackColor = Color.FromArgb(50, 50, 50);
            b_clear.BackgroundImageLayout = ImageLayout.None;
            b_clear.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_clear.FlatAppearance.BorderSize = 0;
            b_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_clear.FlatStyle = FlatStyle.Flat;
            b_clear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_clear.ForeColor = Color.White;
            b_clear.Location = new Point(166, 93);
            b_clear.Margin = new Padding(10);
            b_clear.Name = "b_clear";
            b_clear.Size = new Size(57, 45);
            b_clear.TabIndex = 20;
            b_clear.Text = "C";
            b_clear.UseVisualStyleBackColor = false;
            b_clear.Click += b_clear_Click;
            // 
            // b_delete
            // 
            b_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_delete.BackColor = Color.FromArgb(50, 50, 50);
            b_delete.BackgroundImageLayout = ImageLayout.None;
            b_delete.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_delete.FlatAppearance.BorderSize = 0;
            b_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_delete.FlatStyle = FlatStyle.Flat;
            b_delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_delete.ForeColor = Color.White;
            b_delete.Location = new Point(243, 93);
            b_delete.Margin = new Padding(10);
            b_delete.Name = "b_delete";
            b_delete.Size = new Size(57, 45);
            b_delete.TabIndex = 21;
            b_delete.Text = "⌫";
            b_delete.UseVisualStyleBackColor = false;
            b_delete.Click += b_delete_Click;
            // 
            // b_squere
            // 
            b_squere.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            b_squere.BackColor = Color.FromArgb(50, 50, 50);
            b_squere.BackgroundImageLayout = ImageLayout.None;
            b_squere.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            b_squere.FlatAppearance.BorderSize = 0;
            b_squere.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            b_squere.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58);
            b_squere.FlatStyle = FlatStyle.Flat;
            b_squere.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_squere.ForeColor = Color.White;
            b_squere.Location = new Point(89, 158);
            b_squere.Margin = new Padding(10);
            b_squere.Name = "b_squere";
            b_squere.Size = new Size(57, 45);
            b_squere.TabIndex = 22;
            b_squere.Text = "x²";
            b_squere.UseVisualStyleBackColor = false;
            b_squere.Click += b_squere_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 23;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(314, 475);
            Controls.Add(label1);
            Controls.Add(b_squere);
            Controls.Add(b_delete);
            Controls.Add(b_clear);
            Controls.Add(b_root);
            Controls.Add(b_division);
            Controls.Add(b_procent);
            Controls.Add(b_multi);
            Controls.Add(b_9);
            Controls.Add(b_8);
            Controls.Add(b_7);
            Controls.Add(b_minus);
            Controls.Add(b_6);
            Controls.Add(b_5);
            Controls.Add(b_4);
            Controls.Add(b_plus);
            Controls.Add(b_3);
            Controls.Add(b_2);
            Controls.Add(b_1);
            Controls.Add(b_equals);
            Controls.Add(b_point);
            Controls.Add(b_0);
            Controls.Add(b_plus_minus);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button b_plus_minus;
        private Button b_0;
        private Button b_point;
        private Button b_equals;
        private Button b_1;
        private Button b_2;
        private Button b_3;
        private Button b_plus;
        private Button b_4;
        private Button b_5;
        private Button b_6;
        private Button b_minus;
        private Button b_7;
        private Button b_8;
        private Button b_9;
        private Button b_multi;
        private Button b_procent;
        private Button b_division;
        private Button b_root;
        private Button b_clear;
        private Button b_delete;
        private Button b_squere;
        private Label label1;
    }
}
