using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class ReportsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string urlPDF; // Para source del webview (endpoint)

        [ObservableProperty]
        private string filtroCorreo; // Capturar el texto del correo

        [RelayCommand]
        public void GetPDF()
        {
            UrlPDF = "http://localhost:8080/report/getReport2/" + FiltroCorreo;
        }



    }
}
