using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    internal class Vehiculo : IVehiculo
    {
        public void Encender()  
        {
            Console.WriteLine("Auto Encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("Auto apagado");
        }

    }
}
