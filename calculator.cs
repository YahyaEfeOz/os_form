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
            Button numberButtons = (Button)sender;

            if(entryBox.Text == "0" || secondNUmber != 0)
                entryBox.Text = numberButtons.Text;
            else
                entryBox.Text += numberButtons.Text;

            if (secondNUmber != 0)
            {
                lblOperation.Text = "";
                firstNumber = Convert.ToDouble(numberButtons.Text);
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (secondNUmber == 0)
                secondNUmber = Convert.ToDouble(entryBox.Text);

            if (operation == "+")
            {
                result = (secondNUmber + firstNumber);
                entryBox.Text = Convert.ToString(result);
                lblOperation.Text += secondNUmber+"=";
            }
            else if (operation == "-")
            {
                result = (firstNumber - secondNUmber);
                entryBox.Text = Convert.ToString(result);
                lblOperation.Text += secondNUmber + "=";
            }
            else if (operation == "/")
            {
                result = (firstNumber / secondNUmber);
                entryBox.Text = Convert.ToString(result);
                lblOperation.Text += secondNUmber + "=";
            }
            else if (operation == "*")
            {
                result = (firstNumber * secondNUmber);
                entryBox.Text = Convert.ToString(result);
                lblOperation.Text += secondNUmber + "=";
            }
            lblOperation.Text = firstNumber + operation + secondNUmber + "=";
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
            lblOperation.Text = "";
            entryBox.Text = "0";
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            firstNumber = Convert.ToDouble(entryBox.Text);
            lblOperation.Text = firstNumber + oper.Text;
            entryBox.Text = "0";
            operation = Convert.ToString(oper.Text);
            secondNUmber = 0;
        }
    }
}