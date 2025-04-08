namespace Week2_Arrays_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
       RETO: SISTEMA DE CALIFICACIONES

       Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
       diferentes operaciones estadísticas.

       Requisitos:
       1. Crear un array para almacenar las calificaciones de 10 estudiantes (valores entre 0 y 100)
       2. Implementar las siguientes funcionalidades:
          - Calcular el promedio de calificaciones
          - Encontrar la calificación más alta y la más baja
          - Calcular cuántos estudiantes aprobaron (calificación >= 60)
          - Mostrar las calificaciones en orden ascendente
          - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
            * 0-59 (Reprobado)
            * 60-69 (Suficiente)
            * 70-79 (Bien)
            * 80-89 (Notable)
            * 90-100 (Excelente)

       Extra (opcional):
       - Permitir que el usuario ingrese las calificaciones
       - Implementar un menú para que el usuario elija la operación a realizar
       */
            Console.WriteLine("SISTEMA DE CALIFICACIONES");
            Console.WriteLine("=========================\n");

            // 1. Declarar el array de calificaciones
            double[] calificaciones = new double[10];
            string bienvenida;
            // 2. Ingresar las calificaciones (puede ser manual o automático)
            IngresarCalificaciones(calificaciones);

            //// // 3. Mostrar todas las calificaciones
            MostrarCalificaciones(calificaciones);

            //// // 4. Calcular y mostrar estadísticas
            CalcularEstadisticas(calificaciones);

            //// // 5. Ordenar y mostrar calificaciones
            //OrdenarCalificaciones(calificaciones);

            //// // 6. Mostrar distribución por rangos
            //MostrarDistribucionRangos(calificaciones);


        }

        private static void MostrarDistribucionRangos(double[] calificaciones)
        {

        }

        private static void OrdenarCalificaciones(double[] calificaciones)
        {
            throw new NotImplementedException();
        }

        private static void CalcularEstadisticas(double[] calificaciones)
        {
            double promedio = 0;
            double resultado;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                promedio += calificaciones[i];
            }
            resultado = promedio / calificaciones.Length;

            Console.WriteLine($"El promedio de notas es {resultado}");
        }

        private static void MostrarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("Las notas son las siguientes:");

            double numeroMenor = calificaciones[0];
            double numeroMayor = calificaciones[0];

            for (int i = 0; i < calificaciones.Length; i++)
            {


                if (numeroMenor > calificaciones[i])
                {
                    numeroMenor = calificaciones[i];
                }
                else if (numeroMayor < calificaciones[i])
                {
                    numeroMayor = calificaciones[i];
                }

            }
            Console.WriteLine($"El La nota Mayor es {numeroMayor}");
            Console.WriteLine($"El La nota Menor es {numeroMenor}");


        }


        private static void IngresarCalificaciones(double[] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                double entrada = calificaciones[0];
                Console.WriteLine($"Ingrese la nota #{i + 1}");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada >= 0 && entrada <= 100)
                {
                    calificaciones[i] = entrada;
                }
                else
                {
                    Console.WriteLine("Numero ingresado inválido");
                }
            }
        }
    }
}
