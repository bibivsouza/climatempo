using ClimaTempo.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempo.Service
{
    public class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string appId = "2bac87e0cb16557bff7d4ebcbaa89d2f";
            Tempo previsao = new Tempo();


            //string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId + "&lang=pt";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + cidade + "&units=metric" + "&appid=" + appId;

            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);


            if (!string.IsNullOrEmpty((string)(string)resultado["name"]))
            {
                previsao.Title = (string)resultado["name"];
                previsao.Temperature = (string)resultado["main"]["temp"] + "° C";
                previsao.TemperatureMin = (string)resultado["main"]["temp_min"] + "° C";
                previsao.TemperatureMax = (string)resultado["main"]["temp_max"] + "° C";
                //previsao.Weather = (string)resultado["weather"]["description"];

                return previsao;
            }
            else
            {
                return null;
            }
        }
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);
            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
        public static async Task<dynamic> getDataFromServiceByCity(string city)
        {
            string appId = "2bac87e0cb16557bff7d4ebcbaa89d2f";
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", city.Trim(), appId);
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}
