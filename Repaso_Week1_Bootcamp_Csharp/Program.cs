namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Saber si un número es par o impar
            int isPair;
            Console.WriteLine("Ingresa el primer número:");

            isPair = Convert.ToInt32(Console.ReadLine());

            if (isPair % 2 == 0)
            {
                Console.WriteLine($"El número {isPair} es par");
            }
            else
            {
                Console.WriteLine($"El número {isPair} es no es par");
            }

            //Validar mayor de 3 números
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
            if (segundoNumero < numeroMenor)
            {
                numeroMenor = segundoNumero;
            }

            Console.WriteLine("Ingresa el Tercer número:");
            tercerNumero = Convert.ToInt32(Console.ReadLine());
            if (tercerNumero < numeroMenor)
            {
                numeroMenor = tercerNumero;
            }

            Console.WriteLine($"El número menor es: {numeroMenor}");

            //Obtener el área del circulo o rectangulo. 
            string seleccion;
            double circulo;
            double cuadradoAncho;
            double cuadradoAlto;
            double resultado;
            Console.WriteLine("");
            Console.WriteLine("=============== ============");
            Console.WriteLine("Elegir opción de que área comprobar");
            Console.WriteLine("A: Circulo - B: Rectangulo");
            seleccion = Console.ReadLine();

            //Comprobar si has escogido circulo o cuadrado
            Console.WriteLine($"Has seleccionado: {seleccion}");

            //Si es circulo necesito que pidas el radio
            if (seleccion == "a")
            {
                Console.WriteLine("Ingrese el radio del circulo: ");
                circulo = Convert.ToInt32(Console.ReadLine());
                resultado = 3.14 * (circulo * circulo);
                Console.WriteLine($"El resultado es: {resultado}");
            }
            //Si has elegido rectangulo, tendría que pedir largo y ancho
            else if (seleccion == "b")
            {
                Console.WriteLine("Ingrese el ancho: ");
                cuadradoAncho = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el alto: ");
                cuadradoAlto = Convert.ToInt32(Console.ReadLine());

                resultado = cuadradoAncho * cuadradoAlto;

                Console.WriteLine($"El resultado es: {resultado}");
            }
            //Si has escodigo una opción que no es circulo o rectangulo, un mensaje de error
            else
            {
                Console.WriteLine("No has seleccionado correctamente una de las opciones");
            }


        }
    }
}
