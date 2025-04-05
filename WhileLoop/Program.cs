namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los while loops");

            int contadorTabla = 0;
            int valorTabla;
            int resutado;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            valorTabla = Convert.ToInt32(Console.ReadLine());
            while(contadorTabla <= 12)
            {
                resutado = valorTabla * contadorTabla;
                Console.WriteLine("La tabla del número: " + valorTabla + " es igual a: " + valorTabla + "x" + contadorTabla + "=" + resutado);
                contadorTabla++;
            }
         
        }
    }
}
