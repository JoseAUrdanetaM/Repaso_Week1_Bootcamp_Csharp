namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            int numeroMenor;

            Console.WriteLine("");
            Console.WriteLine("============================");
            Console.WriteLine("¿Cuál es el número mayor de 3 números: ");
            Console.WriteLine("============================");


            Console.WriteLine("Ingresa el primer número:");

            primerNumero = Convert.ToInt32(Console.ReadLine());
            numeroMenor = primerNumero;

            Console.WriteLine("Ingresa el segundo número:");

            segundoNumero = Convert.ToInt32(Console.ReadLine());
            if(segundoNumero < numeroMenor)
            {
                numeroMenor=segundoNumero;
            }

            Console.WriteLine("Ingresa el Tercer número:");

            tercerNumero = Convert.ToInt32(Console.ReadLine());
            if (tercerNumero < numeroMenor)
            {
                numeroMenor = tercerNumero;
            }

            Console.WriteLine($"El número menor es: { numeroMenor}");


            //Obtener el área del circulo o rectangulo. 
            Console.WriteLine("");
            Console.WriteLine("===============  ============");
            Console.WriteLine("Elegir opción de que área comprobar");
            Console.WriteLine("============================");



            //Comprobar si has escogido circulo o cuadrado
            //Si es circulo necesito que pidas el radio
            //Si has elegido rectangulo, tendría que pedir largo y ancho
            //Si has escodigo una opción que no es circulo o rectangulo, un mensaje de error



        }
    }
}
