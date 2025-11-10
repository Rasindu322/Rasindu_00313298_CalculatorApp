using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double result = 0;           // To store the first number
        string operation = "";       // To store the operator (+, -, *, /)
        bool isOperationPerformed = false; // To reset input after operator

        public Form1()
        {
            InitializeComponent();
        }

        // Common method for number buttons (0–9)
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        // Common method for operator buttons (+, -, *, /)
        private void Operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
        }

        // Equal button (=)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double.TryParse(txtDisplay.Text, out secondNumber);

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + secondNumber).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - secondNumber).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        txtDisplay.Text = (result / secondNumber).ToString();
                    else
                        txtDisplay.Text = "Error";
                    break;
                default:
                    break;
            }

            result = double.Parse(txtDisplay.Text);
            operation = "";
        }

        // Individual button click events (connect to common methods)
        private void btn0_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn1_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn2_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn3_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn4_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn5_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn6_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn7_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn8_Click(object sender, EventArgs e) => Numbers_Click(sender, e);
        private void btn9_Click(object sender, EventArgs e) => Numbers_Click(sender, e);

        private void btnAdd_Click(object sender, EventArgs e) => Operators_Click(sender, e);
        private void btnSub_Click(object sender, EventArgs e) => Operators_Click(sender, e);
        private void btnMul_Click(object sender, EventArgs e) => Operators_Click(sender, e);
        private void btnDiv_Click(object sender, EventArgs e) => Operators_Click(sender, e);
    }
}
