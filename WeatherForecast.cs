using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
        
        private Dictionary<string, string> getData(string city = "istanbul")
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string url = String.Format(apiUrl, city);
            XDocument weather = XDocument.Load(url);
            data.Add("temperature", weather.Descendants("temperature").ElementAt(0).Attribute("value").Value);s
            return data;
        }
        private void WeatherForecast_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> data = getData();
            comboBox1.Text = "İstanbul";
            cityName.Text = data["temperature"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> data = getData(comboBox1.Text);

            cityName.Text = data["temperature"];
        }
    }
}
