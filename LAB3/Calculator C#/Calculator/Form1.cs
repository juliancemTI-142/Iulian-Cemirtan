using System;
using System.Windows.Forms;
using Code_Module;


namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operator_pressed = false;
        bool final_result_computed = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            
            if (final_result_computed || result.Text == "0" || operator_pressed)
            {
                result.Text = "";
            }

            final_result_computed = false;
            operator_pressed = false;

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    if (result.Text.ToString() == "")
                        result.Text = "0" + b.Text;
                    else
                        result.Text += b.Text;
                }
            }
            else
                result.Text += b.Text;
        }

        private void delete_click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
        private void clear_click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
            value = 0.0;
            operator_pressed = false;
            final_result_computed = true;
        }
        private void closeButton_click(object sender, EventArgs e)
        {
            Close();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            equal.PerformClick();
            
            operation = b.AccessibleName;
            value = double.Parse(result.Text);
            operator_pressed = true;

            if (operation == "root")
            {
                string tmp = string.Format("sqrt({0})", value);
                equal.PerformClick();
                equation.Text = tmp;
            }       

            else if (operation == "pow")
                equation.Text = string.Format("{0}^", value);

            else if (operation == "inv")
                equal.PerformClick();

            else
                equation.Text = value + " " + operation;
        }

        private void equals_click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = Operators.Add(value, double.Parse(result.Text));
                    break;

                case "-":
                    result.Text = Operators.Sub(value, double.Parse(result.Text));
                    break;

                case "*":
                    result.Text = Operators.Mul(value, double.Parse(result.Text));
                    break;

                case "/":
                    if (result.Text == "0")
                    {
                        result.Text = "0";
                        //MessageBox.Show("So what are you hoping to obtain???", "Division by ZERO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        equation.Text = "ERROR: Division by ZERO";
                    }
                    else { result.Text = Operators.Div(value, double.Parse(result.Text)); }
                    break;
                case "root":

                    if (value < 0)
                    {
                        result.Text = "0";
                        //MessageBox.Show("So what are you hoping to obtain???", "Negative number inside SQUARE ROOT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        equation.Text = "Negative number inside square root";
                    }
                    else { result.Text = Operators.Root(value); }

                    break;
                case "pow":
                    {
                        //if (baza == 0 && exponent <= 0)
                        if (value == 0 && double.Parse(result.Text) <= 0)
                        {
                            result.Text = "0";
                            equation.Text = "Raising to the power can't be performed";
                        }
                        //else if (baza < 0 && Math.Abs((exponent - Math.Truncate(exponent))) > 0)
                        else if (value < 0 && Math.Abs((double.Parse(result.Text) - Math.Truncate(double.Parse(result.Text)))) > 0)
                        {
                            result.Text = "0";
                            equation.Text = "Raising to the power can't be performed";
                        }
                        else result.Text = Operators.Power(value, double.Parse(result.Text));
                    }
                    break;
                case "inv":
                    result.Text = Operators.Inverse(value);
                    break;
                default:
                    break;
            }
            operator_pressed = false;
            final_result_computed = true;

            value = double.Parse(result.Text);
            operation = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    zero.PerformClick();
                    break;
                case '1':
                    one.PerformClick();
                    break;
                case '2':
                    two.PerformClick();
                    break;
                case '3':
                    three.PerformClick();
                    break;
                case '4':
                    four.PerformClick();
                    break;
                case '5':
                    five.PerformClick();
                    break;
                case '6':
                    six.PerformClick();
                    break;
                case '7':
                    seven.PerformClick();
                    break;
                case '8':
                    eight.PerformClick();
                    break;
                case '9':
                    nine.PerformClick();
                    break;
                case '.':
                    dec.PerformClick();
                    break;
                case '+':
                    add.PerformClick();
                    break;
                case '-':
                    sub.PerformClick();
                    break;
                case '/':
                    div.PerformClick();
                    break;
                case '*':
                    times.PerformClick();
                    break;
                case '=':
                    equal.PerformClick();
                    break;
                case 'p':
                    power.PerformClick();
                    break;
                case 'i':
                    inverse.PerformClick();
                    break;
                case 'x':
                    closeButton.PerformClick();
                    break;
                case 'r':
                    root.PerformClick();
                    break;
                case 'd':
                    del.PerformClick();
                    break;
                case 'c':
                    clr.PerformClick();
                    break;
                case 'k': // keyboard is on
                    equal.Focus();
                    break;
                default: break;
            }

        }
    }
}
