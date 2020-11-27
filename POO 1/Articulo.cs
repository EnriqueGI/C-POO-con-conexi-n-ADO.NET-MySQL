using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Articulo
    {
        private String nombre;
        private double precio;
        private String descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string Barato()
        {
            if(precio < 500)
            {
               return "Es barato";
            }
            else
            {
                return "no es barato";
            }
        }
        
    }
}
