using ClimaTempo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClimaTempo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pesquisa : ContentPage
	{
        //public IList<Cidade> Cidades { get; private set; }
        string jsonFileName = "city.json";

        // json obj
        public static object JsonConvert { get; private set; }

        public Pesquisa()
		{
			InitializeComponent ();

            // lista as cidades através do json local
            GetJsonData();
        }

        // captura o nome da cidade da ListView
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cidade cidade = e.SelectedItem as Cidade;

            //redireciona para a página de Detalhes, enviando nome da cidade como parâmetro
            Navigation.PushAsync(new Detalhes(cidade.Name));
        }

        public void GetJsonData()
        {
            List<Cidade> cidades = new List<Cidade>();

            //lê o arquivo local  .json
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                jsonString = jsonString.Substring(13);
                jsonString = jsonString.Remove(jsonString.Length - 1);

                //Converte JSON Array Objects em lista degenérica (no caso cidade)   
                cidades = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cidade>>(jsonString);

                //popula a lista de cidades
                ListCidades.ItemsSource = cidades.ToList().OrderBy(x => x.Name);
            }

        }
    }
}