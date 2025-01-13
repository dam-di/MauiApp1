
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class FormularioViewModel: ObservableObject
    {
        public FormularioModel FormularioModel { get; set; } = 
            new FormularioModel();

        public ObservableCollection<string> ListaDptos { get; set; } = 
            new ObservableCollection<string>() {"Informatica",
                "Ventas","Mantenimiento" };


        public FormularioViewModel() { 
        

        }

        [RelayCommand]
        public void MostrarDatos()
        {
            //Toast.Make(FormularioModel.ToString()).Show();
            Application.Current.MainPage.DisplayAlert("Titulo",
                FormularioModel.ToString(), "OK");
        }



    }
}
