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
        Inverse,

        Sin,
        Cos,
        Tg,
        Ctg,

        Sh,
        Ch,
        Th,
        Cth,

        Asin,
        Acos,
        Atg,
        Actg,

        Exp,
        Ln,
        Log,
        ten_in_x
    }
    public partial class Form1 : Form
    {
        private double first;
        private double result;
        private Operations operation;

        public Form1()
        {
            InitializeComponent();

            this.Width = 330;
            this.Height = 514;
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
                double.TryParse(textBox.Text, out first);

            textBox.Clear();
            operation = Operations.Addition;
            label.Text = first.ToString() + "+";
        }
        private void b_Substraction_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            textBox.Clear();
            operation = Operations.Substraction;
            label.Text = first.ToString() + "-";
        }
        private void b_Multiplication_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            textBox.Clear();
            operation = Operations.Multiplication;
            label.Text = first.ToString() + "×";
        }
        private void b_Division_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

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
                double.TryParse(textBox.Text, out first);

            textBox.Clear();
            operation = Operations.Inverse;
            label.Text = "";
            Calculate();
        }
        private void b_Percentage_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            textBox.Clear();
            operation = Operations.Percentage;
            label.Text = first.ToString() + "%";
        }
        private void b_Square_Root_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Square_Root;
            Calculate();
        }
        private void b_Square_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

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
        private void b_Change_Sign_Click(object sender, EventArgs e)
        {
            if (textBox.Text[0] != '-')
                textBox.Text = '-' + textBox.Text;
            else
                textBox.Text = textBox.Text.Replace("-", "");
        }

        private void Calculate()
        {
            try
            {

                switch (operation)
                {
                    case Operations.Addition:
                        result = first + double.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Substraction:
                        result = first - double.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Multiplication:
                        result = first * double.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Division:
                        if (double.Parse(textBox.Text) == 0)
                        {
                            label.Text = "";
                            textBox.Text = "0";
                            break;
                        }
                        else
                        {
                            result = first / double.Parse(textBox.Text);
                            textBox.Text = result.ToString();
                            break;
                        }

                    case Operations.Percentage:
                        result = first % double.Parse(textBox.Text);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Square_Root:
                        result = Math.Sqrt(first);
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

                    case Operations.Sin:
                        result = Math.Sin(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Cos:
                        result = Math.Cos(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Tg:
                        result = Math.Tan(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Ctg:
                        result = 1 / Math.Tan(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Sh:
                        result = Math.Sinh(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Ch:
                        result = Math.Cosh(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Th:
                        result = Math.Tanh(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Cth:
                        result = 1 / Math.Tanh(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Asin:
                        result = Math.Asin(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Acos:
                        result = Math.Acos(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Atg:
                        result = Math.Atan(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Actg:
                        result = 1 / Math.Atan(1 / first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Exp:
                        result = Math.Exp(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Ln:
                        result = Math.Log(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.Log:
                        result = Math.Log10(first);
                        textBox.Text = result.ToString();
                        break;

                    case Operations.ten_in_x:
                        result = Math.Pow(10, first);
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
        private void b_Clear_Entry_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }


        private void b_E_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.E.ToString();
        }
        private void b_Pi_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.PI.ToString();
        }


        private void b_Sin_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Sin;
            Calculate();
        }
        private void b_Cos_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Cos;
            Calculate();
        }
        private void b_Tg_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Tg;
            Calculate();
        }
        private void b_Ctg_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Ctg;
            Calculate();
        }


        private void b_Sh_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Sh;
            Calculate();
        }
        private void b_Ch_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Ch;
            Calculate();
        }
        private void b_Th_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Th;
            Calculate();
        }
        private void b_Cth_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Cth;
            Calculate();
        }


        private void b_Asin_Click(object sender, EventArgs e)
        {

            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Asin;
            Calculate();
        }
        private void b_Acos_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Acos;
            Calculate();
        }
        private void b_Atg_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Atg;
            Calculate();
        }
        private void b_Actg_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Actg;
            Calculate();
        }


        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 330;
            this.Height = 514;
        }
        private void EngineerStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 582;
            this.Height = 514;
        }


        private void b_Exp_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Exp;
            Calculate();
        }
        private void b_Ln_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Ln;
            Calculate();
        }
        private void b_Log_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.Log;
            Calculate();
        }
        private void b_10_in_x_Click(object sender, EventArgs e)
        {

            if (textBox.Text != "")
                double.TryParse(textBox.Text, out first);

            label.Text = "";
            textBox.Clear();
            operation = Operations.ten_in_x;
            Calculate();
        }
    }
}
