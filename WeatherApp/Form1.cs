using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private const string apiKey = "aa20a5b1a8d5dead9d8239acffb7ee57";
        private const string apiBaseURL = "http://api.weatherstack.com/";

        public Form1()
        {
            InitializeComponent();
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string search = localTBox.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                string apiURL = $"{apiBaseURL}/current?access_key={apiKey}&query={search}&units=m";
                
                try
                {
                    var client = new HttpClient();
                    var response = await client.GetAsync(apiURL);
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    displayWeather(jsonResponse);   
                }
                catch
                {

                }
            }
        }

        private void displayWeather(string jsonResponse)
        {
            lblLocation.Text = $"City: ";
            lblTemp.Text = "Temp: °C";
        }
    }
}
