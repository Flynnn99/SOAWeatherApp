using APITest;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            CitiesListBox.Items.Clear();
            //CitiesListBox.Items.Add("We will add Cities Here");

            List<City> cities = new List<City>();
            int count = 0;
            using (var reader = new StreamReader("C:\\Users\\micfl\\OneDrive\\Desktop\\SOA\\Lab2\\WeatherApp\\WeatherApp\\WeatherApp\\city.json"))
            {
                while (!reader.EndOfStream)
                {
                    cities.Add(JsonConvert.DeserializeObject<City>(reader.ReadLine()));
                    count++;
                }
            }
            DisplayWeatherLabel.Text = $"Total Numbers of Cities: {count}";

            var SortedCities = cities.OrderBy(x => x.country);
            List<City> irishCities = new List<City>();
            foreach (City city in SortedCities)
            {
                if (city.country == "IE")
                {
                    irishCities.Add(city);
                }
            }
            irishCities.Sort((x, y) => x.name.CompareTo(y.name));
            CitiesListBox.DisplayMember = "name";
            CitiesListBox.ValueMember = "_id";
            CitiesListBox.DataSource = irishCities;

        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string weather = DownloadWeather((int)CitiesListBox.SelectedValue);
            DisplayWeatherLabel.Text = weather;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string DownloadWeather(int cityID)
        {
            WebClient client = new WebClient();
            string apiKey = "3f454798ef934199f65dcbd884202095";
            string webUrl = "http://api.openweathermap.org/data/2.5/weather?id=" + cityID + "&APPID=" + apiKey;
            string receivedJson = client.DownloadString(webUrl);
            return receivedJson;

        }
        private void CitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayWeatherLabel.Text = $"Entered City ID is: {CitiesListBox.SelectedValue}";
        }

 
    }
}