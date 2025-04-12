using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clase3_POO
{
    internal class Vehiculo
    {
        private string Marca;
        public string PublicMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        private string Modelo;
        public string PublicModelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        private int Año;
        public int PublicAño
        {
            get { return Año; }
            set { Año = value; }
        }

        private double Kilometraje;
        public double PublicKilometraje
        {
            get { return Kilometraje; }
            set { Kilometraje = value; }
        }

        private string TipoDeVehiculo;
        public string PublicTipoDeVehiculo
        {
            get { return TipoDeVehiculo; }
            set { TipoDeVehiculo = value; }
        }

        public Vehiculo(string marca, string modelo, int año, double kilometraje, string tipodevehiculo)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Kilometraje = kilometraje;
            TipoDeVehiculo = tipodevehiculo;
        }

 
    }

}
