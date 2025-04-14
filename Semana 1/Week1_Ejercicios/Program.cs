namespace Week1_Ejercicios
{
    internal class Program
    {
             static void Main(string[] args)
            {

                    Console.WriteLine("Calcualdora .Net");
                    Console.WriteLine("----------------");

                    Console.Write("Ingresa el primer número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingresa el segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());


                    Console.Write("¿Qué operación deseas realizar? (+, -, *, /): ");
                    string operacion = Console.ReadLine();

                    double resultado = 0;

                    if (operacion == "+")
                    {
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado {num1} + {num2} es:{resultado}");
                    }
                    else if (operacion == "-")
                    {
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado {num1} - {num2} es: {resultado}");
                    }
                    else if (operacion == "*")
                    {
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado {num1} * {num2} es: {resultado}");
                    }
                    else if (operacion == "/")
                    {
                        if (num2 > 0)
                        {
                            resultado = num1 + num2;
                            Console.WriteLine($"El resultado {num1} / {num2} es: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error matemático, no se puede dividir entre 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El operador ingresado es inválido");
                    }
                }
            }
    }
}
