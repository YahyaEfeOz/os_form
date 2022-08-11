using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Data;


namespace os_form
{
    public partial class WeatherForecast : Form
    {
        public WeatherForecast()
        {
            InitializeComponent();
        }

        const string apiKey = "697c07fc676b891978c2f4156b14ec6e";
        const string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&units=metric&appid=" + apiKey;


        private Dictionary<string, string> clouds(string city = "istanbul")
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string url = String.Format(apiUrl, city);
            XDocument weather = XDocument.Load(url);
            data.Add("clouds", weather.Descendants("clouds").ElementAt(0).Attribute("name").Value);
            return data;
        }

        private Dictionary<string, string> temperature(string city = "istanbul")
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string url = String.Format(apiUrl, city);
            XDocument weather = XDocument.Load(url);
            data.Add(
                "temperature",
                weather.Descendants("temperature").ElementAt(0).Attribute("value").Value
                );
            return data;
        }

        static string connectionString = @"Data Source=C:\Users\Efe\Desktop\os_form\Data\directory.db";
        SQLiteConnection connection = new SQLiteConnection(connectionString);


        private void WeatherForecast_Load(object sender, EventArgs e)
        {
            connection.Open();

            SQLiteCommand sQLiteCommand = new SQLiteCommand("Select * From cities", connection);
            SQLiteDataReader sQLiteDataReader;
            sQLiteDataReader = sQLiteCommand.ExecuteReader();
            while (sQLiteDataReader.Read())
            {
                cbxCityName.Items.Add(sQLiteDataReader["cityName"]);
            }

            cbxCityName.Text = "İstanbul";

            Dictionary<string, string> data = temperature();
            lblTemperature.Text = data["temperature"] + " Derece";

            Dictionary<string, string> data2 = clouds();
            lblWind.Text = "Hava " + data2["clouds"];            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> temperature = this.temperature(cbxCityName.Text);
            double a = Math.Round(Convert.ToDouble(temperature["temperature"].Replace(".",",")));
            string temperatureText;
            temperatureText = a.ToString();
            lblTemperature.Text = temperatureText + " Derece";

            Dictionary<string, string> clouds = this.clouds(cbxCityName.Text);
            lblWind.Text = "Hava " + clouds["clouds"];
        }

        private void WeatherForecast_Leave(object sender, EventArgs e)
        {
            connection.Close();
        }
    }
}
