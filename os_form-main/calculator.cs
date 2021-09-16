using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_form
{
    public partial class calculator : Form
    {
        double firstnum;
        string ope;
        double secnum;
        double result;
        double frstnum, scndnum;
        public calculator()       
        {
            InitializeComponent();
        }      
        private void number_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if(entryBox.Text == "0")
            entryBox.Text = number.Text;
            else
                entryBox.Text += number.Text;
        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            secnum = Convert.ToDouble(entryBox.Text);
            scndnum = secnum;
            if (ope == "+")
            {
                result = (secnum + firstnum);
                entryBox.Text = Convert.ToString(result);
                opelabel.Text += secnum+"=";
            }
            else if (ope == "-")
            {
                result = (firstnum - secnum);
                opelabel.Text += secnum + "=";
                entryBox.Text = Convert.ToString(result);
                opelabel.Text = result + "-" + scndnum;
            }
            else if (ope == "/")
            {
                result = (firstnum / secnum);
                opelabel.Text += secnum + "=";
            }
            else if (ope == "*")
            {
                result = (firstnum * secnum);
                opelabel.Text += secnum + "=";
            }
            opelabel.Text = frstnum + ope + secnum + "=";
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (entryBox.Text.Length == 1)
            {
                entryBox.Text = "0";
            }
            else
            {
                 string delete = entryBox.Text.Substring(0, entryBox.Text.Length - 1);
                 entryBox.Text = delete;
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
            frstnum = firstnum;
            opelabel.Text = frstnum + oper.Text;
            entryBox.Text = "0";
            ope = Convert.ToString(oper.Text);
        }
    }
}