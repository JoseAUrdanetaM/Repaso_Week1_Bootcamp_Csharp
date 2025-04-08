namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio #1 Tabla de Multiplicar 

            Console.WriteLine("Bienvenido a la tabla de multiplicación, ingrese el número de tabla a multiplicar:");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("");
            Console.WriteLine($"Tabla del {baseNumber}");
            for (int i = 0; i < 11; i++)
            {
                result = baseNumber * i;
                Console.WriteLine($"{baseNumber} x {i} = {result}");
            }

            //Ejercicio #2 Patrones en escalera 

            Console.WriteLine("Generador de patrón escalera");

            Console.WriteLine("Inserte la cantidad de pisos");
            int baseTriangleNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= baseTriangleNumber; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(b + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
