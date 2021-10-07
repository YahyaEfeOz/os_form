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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = Convert.ToString(DateTime.Now);
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            Directory directory = new Directory();
            directory.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void btnWeatherForecast_Click(object sender, EventArgs e)
        {
            Weather_Forecast weather_Forecast = new Weather_Forecast();
            weather_Forecast.Show();
        }
    }
}
