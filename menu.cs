using System;
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
            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.Show();
        }
    }
}
