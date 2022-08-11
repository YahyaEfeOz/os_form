using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace os_form
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }
        string[] dayNames = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Saturday", "Sunday" };
        int year, month, todayIndex;

        private void Date_Load(object sender, EventArgs e)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;

            string firstDayOfMonth = new DateTime(year, month, DateTime.Now.Day).DayOfWeek.ToString();
            todayIndex = Array.IndexOf(dayNames, firstDayOfMonth) + 1;

            fillDates(year, month);

            lblMonth.Text = month.ToString();
            lblYear.Text = year.ToString();


        }   

        private void fillDates(int year, int month)
        {
            
            int numberDaysInMonth = DateTime.DaysInMonth(year, month);
            string firstDayOfMonth = new DateTime(year, month, 1).DayOfWeek.ToString();
            int todayIndex = Array.IndexOf(dayNames, firstDayOfMonth) + 1;


            Control buttons = this.Controls.Find("btn" + this.todayIndex, true)[0];
            if (year == DateTime.Now.Year && month == DateTime.Now.Month)
            {
                buttons.BackColor = Color.Red;
            }
            else
            {
                buttons.BackColor = DefaultBackColor;
            }


            Dictionary<string, int> lastDate = getLastDate();
            int fillDayCount = DateTime.DaysInMonth(lastDate["year"], lastDate["month"]);
            for (int i = todayIndex - 1; i > 0; i--)
            {
                Control button = this.Controls.Find("btn" + i.ToString(), true)[0];
                
                button.Text = fillDayCount.ToString();
                button.Enabled = false;
                fillDayCount--;
            }

            for (int i = todayIndex; i < numberDaysInMonth + todayIndex; i++)
            {
                Control button = this.Controls.Find("btn" + i.ToString(), true)[0];
                button.Text = (i - todayIndex + 1).ToString();
                button.Enabled = true;
            }               

            int a = 1;
            for(int i = numberDaysInMonth + todayIndex; i <= 42; i++)
            {
                Control button = this.Controls.Find("btn" + i.ToString(), true)[0];
                button.Text = a.ToString();
                button.Enabled = false;

                a++;
            }

        }
        
        private Dictionary<string,int> getLastDate()
        {
            Dictionary<string, int> date = new Dictionary<string, int>();
            if (month - 1 < 1)
            {
                date["month"] = 12;
                date["year"] = year - 1;
            }
            else
            {
                date["month"] = month - 1;
                date["year"] = year;
            }
            return date;
        }

        private Dictionary<string, int> getNextDate()
        {
            Dictionary<string, int> date = new Dictionary<string, int>();
            if (month +1 > 12)
            {
                date["month"] = 1;
                date["year"] = year + 1;
            }
            else
            {
                date["month"] = month + 1;
                date["year"] = year;
            }
            return date;
        }


        private void btnRight_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> nextDate = getNextDate();
            month = nextDate["month"];
            year = nextDate["year"];

            lblMonth.Text = month.ToString();
            lblYear.Text = year.ToString();

            fillDates(year, month);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> lastDate = getLastDate();

            month = lastDate["month"];
            year = lastDate["year"];

            lblMonth.Text = month.ToString();
            lblYear.Text = year.ToString();

            fillDates(year,month);
        }
    }
}
