﻿using ClimaTempo.Context;
using ClimaTempo.Model;
using ClimaTempo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClimaTempo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalhes : ContentPage
	{
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public Detalhes (string nome)
		{
            // inicializa 
			InitializeComponent ();

            this.BindingContext = new Tempo();

            inicializa(nome);

        }

        private void inicializa(string nome)
        {
            Tempo tempo = new Tempo();
            buscarDados(nome);

        }

        // padda o nome da cidade para buscar a previsão do tempo
        private async void buscarDados(string cidade)
        {
            try
            {
                if (!String.IsNullOrEmpty(cidade))
                {
                    //acesso a API do openweathermap.or
                    Tempo previsaoDoTempo = await DataService.GetPrevisaoDoTempo(cidade);
                    this.BindingContext = previsaoDoTempo;
                    if (this.BindingContext != null)
                    {
                      
                    }
                
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro ", ex.Message, "OK");
            }
        }

        private async void btnFavorito_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lbTitle.Text))
            {
                await App.DbContext.SaveCidadesAsync(new Cidade
                {
                    Name = lbTitle.Text,

                });

                lbTitle.Text = string.Empty;
               // listView.ItemsSource = await App.Database.Get();
            }
        }
    }
}