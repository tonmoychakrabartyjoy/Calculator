namespace Analog_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double input1;
        string op;
        double ans;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt_display.Text.IsWhiteSpace())
            {
                return;
            }
            txt_display.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_display.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_display.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_display.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_display.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_display.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_display.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_display.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_display.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_display.Text += 9;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (txt_display.Text.Contains("."))
            {
                return;
            }

            if (txt_display.Text.IsWhiteSpace())
            {
                txt_display.Text = "0";
            }
            txt_display.Text += ".";
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            txt_display.Text = "";
            op = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (op.IsWhiteSpace())
            {
                input1 = double.Parse(txt_display.Text);
                op = "+";
            }
            else
            {
                switch (op)
                {
                    case "+":
                        input1 += double.Parse(txt_display.Text);
                        break;

                    case "-":
                        input1 -= double.Parse(txt_display.Text);
                        break;
                    case "*":
                        input1 *= double.Parse(txt_display.Text);
                        break;
                    case "/":
                        input1 /= double.Parse(txt_display.Text);
                        break;
                }
            }
            txt_display.Text = "";
        }

        

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (op.IsWhiteSpace())
            {
                input1 = double.Parse(txt_display.Text);
                op = "-";
            }
            else
            {
                switch (op)
                {
                    case "+":
                        input1 += double.Parse(txt_display.Text);
                        break;

                    case "-":
                        input1 -= double.Parse(txt_display.Text);
                        break;
                    case "*":
                        input1 *= double.Parse(txt_display.Text);
                        break;
                    case "/":
                        input1 /= double.Parse(txt_display.Text);
                        break;
                }
            }
            txt_display.Text = "";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (op.IsWhiteSpace())
            {
                input1 = double.Parse(txt_display.Text);
                op = "*";
            }
            else
            {
                switch (op)
                {
                    case "+":
                        input1 += double.Parse(txt_display.Text);
                        break;

                    case "-":
                        input1 -= double.Parse(txt_display.Text);
                        break;
                    case "*":
                        input1 *= double.Parse(txt_display.Text);
                        break;
                    case "/":
                        input1 /= double.Parse(txt_display.Text);
                        break;
                }
            }
            txt_display.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (op.IsWhiteSpace())
            {
                input1 = double.Parse(txt_display.Text);
                op = "/";
            }
            else
            {
                switch (op)
                {
                    case "+":
                        input1 += double.Parse(txt_display.Text);
                        break;

                    case "-":
                        input1 -= double.Parse(txt_display.Text);
                        break;
                    case "*":
                        input1 *= double.Parse(txt_display.Text);
                        break;
                    case "/":
                        input1 /= double.Parse(txt_display.Text);
                        break;
                }
            }
            txt_display.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    ans = input1 += double.Parse(txt_display.Text);
                    break;

                case "-":
                    ans = input1 -= double.Parse(txt_display.Text);
                    break;
                case "*":
                    ans = input1 *= double.Parse(txt_display.Text);
                    break;
                case "/":
                    ans = input1 /= double.Parse(txt_display.Text);
                    break;
            }

            txt_display.Text = ans.ToString();
            op = "";

        }
    }
}
