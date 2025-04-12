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
        private string _marca;
        public string PublicMarca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private string _modelo;
        public string PublicModelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private int _año;
        public int PublicAño
        {
            get { return _año; }
            set { _año = value; }
        }

        private double _kilometraje;
        public double PublicKilometraje
        {
            get { return _kilometraje; }
            set { _kilometraje = value; }
        }

        private string _tipodevehiculo;
        public string PublicTipoDeVehiculo
        {
            get { return _tipoDeVehiculo; }
            set { _tipoDeVehiculo = value; }
        }

        public Vehiculo(string marca, string modelo, int año, double kilometraje, string tipodevehiculo)
        {
            _marca = marca;
            _modelo = modelo;
            _año = año;
            _kilometraje = kilometraje;
            _tipodevehiculo = tipodevehiculo;
        }

 
    }

}
