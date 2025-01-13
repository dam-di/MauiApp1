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
    public partial class TiendaViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isEnabled = false;


        public Dictionary<string, ObservableCollection<string>> Dict { get; set; }
            = new Dictionary<string, ObservableCollection<string>>();

        public TiendaViewModel()
        {
            CargarDiccionario();
        }

        private void CargarDiccionario()
        {
            Dict.Add("Hogar", new ObservableCollection<string> { "hogar 1", "hogar 2" });
            Dict.Add("Elect", new ObservableCollection<string> { "elect 1", "elect 2" });
            Dict.Add("Jardin", new ObservableCollection<string> { "jardin 1", "jardin2" });

            ListaCategorias.Add("Selecciona una...");
            foreach (var key in Dict.Keys)
            {
                ListaCategorias.Add(key);
            }

        }

        public ProductoModel Producto { get; set; } = new ProductoModel();

        [ObservableProperty]
        private ObservableCollection<string> listaTipos =
            new ObservableCollection<string>();

        public ObservableCollection<string> ListaCategorias { get; set; } =
            new ObservableCollection<string>();

        [RelayCommand]
        public void ActualizarStock(object _stock)
        {
            if (_stock is not double)
            {
                return;
            }
            Producto.Stock = (int)(double)_stock;
        }


        [RelayCommand]
        public void HabilitarTipos(object _parametro)
        {
            if (_parametro is not int)
            {
                return;
            }

            int _selectedIndex = (int)_parametro;

            if (_selectedIndex == 0) //Producto.Categoria.Equals("Selecciona una...")
            {
                IsEnabled = false;
            }
            else
            {
                IsEnabled = true;
                ListaTipos = Dict[Producto.Categoria];
            }
        }

        [RelayCommand]
        public void MostrarDatos()
        {
            Application.Current.MainPage.DisplayAlert("PRODUCTO",
                Producto.Codigo + Producto.Fecha, "ACEPTAR");
        }
    }
}
