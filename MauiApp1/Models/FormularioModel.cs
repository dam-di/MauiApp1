using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class FormularioModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = "rafa@gmail.com";
        public string Departamento { get; set; } = string.Empty;
        public bool Terminos { get; set; } = false;

        public override string ToString()
        {
            return Nombre + " " + Correo + " " + 
                Departamento + " " + Terminos;
        }
    }
}
