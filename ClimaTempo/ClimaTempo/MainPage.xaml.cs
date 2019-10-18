using ClimaTempo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using System.Collections.ObjectModel;


namespace ClimaTempo
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
           
            InitializeComponent();

        }



        private void Button_Pesquisa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pesquisa());
        }
    }
}
