namespace Clase3_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("Toyota", "Yaris", 2025, 0, "Sedan");
            vehiculo.PublicMarca = "Lexus";
            Console.WriteLine(vehiculo.PublicMarca);
        }
    }
}
