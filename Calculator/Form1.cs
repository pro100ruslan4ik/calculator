namespace Calculator
{

    public enum Operations
    {
        Addition,
        Substraction,
        Multiplication,
        Division,
        Percentage,
        Square_Root,
        Square,
        Inverse
    }
    public partial class Form1 : Form
    {
        private float first, result;
        private Operations operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null || textBox.Text == "Error")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void b_Addition_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Addition;
            label.Text = first.ToString() + "+";
        }

        private void b_Substraction_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Substraction;
            label.Text = first.ToString() + "-";
        }

        private void b_Multiplication_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Multiplication;
            label.Text = first.ToString() + "×";
        }

        private void b_Division_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Division;
            label.Text = first.ToString() + "÷";
        }
        private void b_Point_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "0";
            }
            else
            {
                if (textBox.Text != null && textBox.Text.Contains(',') == false)
                    textBox.Text = textBox.Text + ",";
            }
        }


        private void b_Inverse_Click(object sender, EventArgs e)
        {

            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Inverse;
            label.Text = "";
            Calculate();
        }
        private void b_Percentage_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            textBox.Clear();
            operation = Operations.Percentage;
            label.Text = first.ToString() + "%";
        }
        private void b_Square_Root_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Square_Root;
            Calculate();
        }

        private void b_Square_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                first = float.Parse(textBox.Text);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Square;
            Calculate();
        }

        private void b_Equals_Click(object sender, EventArgs e)
        {
            Calculate();
            label.Text = "";
        }

        private void Calculate()
        {
            try
            {

                switch (operation)
                {
                    case Operations.Addition:
                        result = first + float.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Substraction:
                        result = first - float.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Multiplication:
                        result = first * float.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Division:
                        if (float.Parse(textBox.Text) == 0)
                        {
                            label.Text = "";
                            textBox.Text = "0";
                            break;
                        }
                        else
                        {
                            result = first / float.Parse(textBox.Text);
                            textBox.Text = result.ToString();
                            break;
                        }

                    case Operations.Percentage:
                        result = first % float.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Square_Root:
                        result = MathF.Sqrt(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Square:
                        result = first * first;
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Inverse:
                        result = 1 / first;
                        textBox.Text = result.ToString();
                        break;


                    default:
                        label.Text = "";
                        textBox.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                textBox.Text = "Error";
                label.Text = "";
            }

        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            label.Text = "";
            textBox.Text = "0";
            first = 0;
            result = 0;
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            int lenght = textBox.Text.Length - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox.Text = textBox.Text + text[i];
            }
        }

        private void b_Change_Sign_Click(object sender, EventArgs e)
        {
            if (textBox.Text[0] != '-')
                textBox.Text = '-' + textBox.Text;
            else
                textBox.Text = textBox.Text.Replace("-", "");
        }

        private void b_Clear_Entry_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }
    }
}
