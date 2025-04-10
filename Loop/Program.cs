namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de patrón escalera");

            Console.WriteLine("Inserte la cantidad de pisos");
            int baseTriangleNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            //for (int i = 0; i <= baseTriangleNumber; i++)
            //{
            //    Console.Write("* ");
            //    for (int b = 1; b <= i; b++)
            //    {
            //        Console.Write(b + " ");
            //    }
            //    Console.WriteLine(""); 
            //}

            /*
             * 
             * -----*
             * ----* *
             * ---* * *
             * --* * * *
             * -* * * * *
             * 
             * 
             */

            for (int i = 1; i <= baseTriangleNumber; i++)
            {
             
                for (int b = baseTriangleNumber; b >= i; b--)
                {
                    Console.Write("- ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Se acabó el bucle");
        }
    }
}
