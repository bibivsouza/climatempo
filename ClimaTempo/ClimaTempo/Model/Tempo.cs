using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaTempo.Model
{
    public class Tempo
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string TemperatureMin { get; set; }
        public string TemperatureMax { get; set; }
        public string Weather { get; set; }

        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public Tempo()
        {
            // Como as Labels se vinculam a estes valores vamos defini-los 
            // como uma string vazia no construtor 
            this.Title = " ";
            this.Temperature = " ";
            this.Weather = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";
            this.TemperatureMax = "";
            this.TemperatureMin = "";
        }
    }

}