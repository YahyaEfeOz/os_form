using System;
using System.Windows.Forms;

namespace os_form
{
    public partial class calculator : Form
    {
        double firstnum;
        string ope;
        double secnum = 0;
        public calculator()       
        {
            InitializeComponent();
        }      
        private void number_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if(entryBox.Text == "0" || secnum != 0)
                entryBox.Text = number.Text;
            else
                entryBox.Text += number.Text;

            if (secnum != 0)
            {
                opelabel.Text = "";
                firstnum = Convert.ToDouble(number.Text);
            }
        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (secnum == 0)
                secnum = Convert.ToDouble(entryBox.Text);

            if (ope == "+")
            {
                result = (secnum + firstnum);
                entryBox.Text = Convert.ToString(result);
                opelabel.Text += secnum+"=";
            }
            else if (ope == "-")
            {
                result = (firstnum - secnum);
                entryBox.Text = Convert.ToString(result);
                opelabel.Text += secnum + "=";
            }
            else if (ope == "/")
            {
                result = (firstnum / secnum);
                entryBox.Text = Convert.ToString(result);
                opelabel.Text += secnum + "=";
            }
            else if (ope == "*")
            {
                result = (firstnum * secnum);
                entryBox.Text = Convert.ToString(result);
                opelabel.Text += secnum + "=";
            }
            opelabel.Text = firstnum + ope + secnum + "=";
            firstnum = result;
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
            opelabel.Text = "";
            entryBox.Text = "0";
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            firstnum = Convert.ToDouble(entryBox.Text);
            opelabel.Text = firstnum + oper.Text;
            entryBox.Text = "0";
            ope = Convert.ToString(oper.Text);
            secnum = 0;
        }
    }
}