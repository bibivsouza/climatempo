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


            //Verificar cidades favoritas
            verificarCidades();

        }

        private async void  verificarCidades()
        {
            List<Cidade> Cidades = new List<Cidade>();
            Cidades = await App.DbContext.GetCidadesAsync();
            if (Cidades != null)
            {
                ListCidades.ItemsSource = Cidades.OrderBy(x=>x.Name);
            }
            else
            {
                await DisplayAlert("alert1","Não existem Cidades em Favoritos!","ok");
            }
        }

        private void Button_Pesquisa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pesquisa());
        }
    }
}
