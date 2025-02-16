using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

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

        public async void searchBtn_Click(object sender, EventArgs e)
        {
            string search = localTBox.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                string apiURL = $"{apiBaseURL}/current?access_key={apiKey}&query={search}&units=m";

                try
                {
                    var client = new HttpClient();
                    var response = await client.GetStringAsync(apiURL);
                    JObject data = JObject.Parse(response);

                    if (data["success"] != null && (bool)data["success"] == false)
                    {
                        string errorMsg = data["error"]["info"].ToString();
                        MessageBox.Show($"Error: {errorMsg}");
                    } 
                    else
                    {
                        displayWeather(data);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void displayWeather(JObject data)
        {
            lblTemp.Visible = true;
            pbIcon.Visible = true;
            lblTemp.Text = $"{data["current"]["temperature"]}°C";
            string iconURL = $"{data["current"]["weather_icons"]}";
            pbIcon.Load(iconURL);
        }

        
    }
}
