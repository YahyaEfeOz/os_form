using System;
using System.Windows.Forms;

namespace os_form
{
    public partial class Calculator : Form
    {
        double firstNumber;
        string operation;
        double secondNUmber = 0;
        public Calculator()       
        {
            InitializeComponent();
        }      
        private void number_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if(entryBox.Text == "0" || secondNUmber != 0)
                entryBox.Text = number.Text;
            else
                entryBox.Text += number.Text;

            if (secondNUmber != 0)
            {
                opeLabel.Text = "";
                firstNumber = Convert.ToDouble(number.Text);
            }
        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (secondNUmber == 0)
                secondNUmber = Convert.ToDouble(entryBox.Text);

            if (operation == "+")
            {
                result = (secondNUmber + firstNumber);
                entryBox.Text = Convert.ToString(result);
                opeLabel.Text += secondNUmber+"=";
            }
            else if (operation == "-")
            {
                result = (firstNumber - secondNUmber);
                entryBox.Text = Convert.ToString(result);
                opeLabel.Text += secondNUmber + "=";
            }
            else if (operation == "/")
            {
                result = (firstNumber / secondNUmber);
                entryBox.Text = Convert.ToString(result);
                opeLabel.Text += secondNUmber + "=";
            }
            else if (operation == "*")
            {
                result = (firstNumber * secondNUmber);
                entryBox.Text = Convert.ToString(result);
                opeLabel.Text += secondNUmber + "=";
            }
            opeLabel.Text = firstNumber + operation + secondNUmber + "=";
            firstNumber = result;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (entryBox.Text.Length == 1)
            {
                entryBox.Text = "0";
            }
            else
            {
                 entryBox.Text = entryBox.Text.Substring(0, entryBox.Text.Length - 1);
            }
        }
        private void btnClear_click(object sender, EventArgs e)
        {
            opeLabel.Text = "";
            entryBox.Text = "0";
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            firstNumber = Convert.ToDouble(entryBox.Text);
            opeLabel.Text = firstNumber + oper.Text;
            entryBox.Text = "0";
            operation = Convert.ToString(oper.Text);
            secondNUmber = 0;
        }
    }
}