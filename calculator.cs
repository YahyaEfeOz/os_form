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

            if (ope == "+")
            {
                result = (firstnum + secnum);
                entryBox.Text = Convert.ToString(result);
                firstnum = result;
            }
            else if (ope == "-")
            {
                result = (firstnum - secnum);
                entryBox.Text = Convert.ToString(result);
                firstnum = result;
            }
            else if (ope == "/")
            {
                result = (firstnum / secnum);
                entryBox.Text = Convert.ToString(result);
                firstnum = result;
            }
            else if (ope == "*")
            {
                result = (firstnum * secnum);
                entryBox.Text = Convert.ToString(result);
                firstnum = result;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
          if(entryBox.Text.Lenght == 1)
          {
               entryBox.Text = "0"
          }
          else
          {
               string delete = entryBox.Text.Substring(0, entryBox.Text.Length - 1);
               entryBox.Text = delete;
          }
        }
        private void btnClear_click(object sender, EventArgs e)
        {
            entryBox.Text = "0";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(entryBox.Text);
            entryBox.Text = "0";
            ope = "+";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(entryBox.Text);
            entryBox.Text = "0";
            ope = "/";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(entryBox.Text);
            entryBox.Text = "0";
            ope = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(entryBox.Text);
            entryBox.Text = "0";
            ope = "*";
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            entryBox.Text = "!";
            
        }

        private void entryBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
