namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE CALIFICACIONES");
            Console.WriteLine("=========================\n");

            double[] calificaciones = new double[10];

            IngresarCalificaciones(calificaciones);
            MostrarCalificaciones(calificaciones);
            CalcularEstadisticas(calificaciones);
            OrdenarCalificaciones(calificaciones);
            MostrarDistribucionRangos(calificaciones);
        }

        private static void IngresarCalificaciones(double[] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                double entrada;
                do
                {
                    Console.Write($"Ingrese la nota #{i + 1} (0 - 100): ");
                    entrada = Convert.ToDouble(Console.ReadLine());

                    if (entrada < 0 || entrada > 100)
                    {
                        Console.WriteLine("Número inválido. Intenta de nuevo.");
                    }

                } while (entrada < 0 || entrada > 100);

                calificaciones[i] = entrada;
            }
        }

        private static void MostrarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("\nListado de calificaciones:");
            foreach (var nota in calificaciones)
            {
                Console.Write(nota + " ");
            }
            Console.WriteLine();

            double max = calificaciones[0];
            double min = calificaciones[0];

            foreach (var nota in calificaciones)
            {
                if (nota > max) max = nota;
                if (nota < min) min = nota;
            }

            Console.WriteLine($"Nota más alta: {max}");
            Console.WriteLine($"Nota más baja: {min}");
        }

        private static void CalcularEstadisticas(double[] calificaciones)
        {
            double suma = 0;
            int aprobados = 0;

            foreach (var nota in calificaciones)
            {
                suma += nota;
                if (nota >= 60)
                    aprobados++;
            }

            double promedio = suma / calificaciones.Length;

            Console.WriteLine($"\nPromedio general: {promedio:F2}");
            Console.WriteLine($"Cantidad de estudiantes aprobados (>=60): {aprobados}");
        }

        private static void OrdenarCalificaciones(double[] calificaciones)
        {
            Array.Sort(calificaciones);
            Console.WriteLine("\nCalificaciones en orden ascendente:");
            foreach (var nota in calificaciones)
            {
                Console.Write(nota + " ");
            }
            Console.WriteLine();
        }

        private static void MostrarDistribucionRangos(double[] calificaciones)
        {
            int reprobado = 0, suficiente = 0, bien = 0, notable = 0, excelente = 0;

            foreach (var nota in calificaciones)
            {
                if (nota < 60) reprobado++;
                else if (nota < 70) suficiente++;
                else if (nota < 80) bien++;
                else if (nota < 90) notable++;
                else excelente++;
            }

            Console.WriteLine("\nDistribución de calificaciones:");
            Console.WriteLine($"0 - 59 (Reprobado): {reprobado}");
            Console.WriteLine($"60 - 69 (Suficiente): {suficiente}");
            Console.WriteLine($"70 - 79 (Bien): {bien}");
            Console.WriteLine($"80 - 89 (Notable): {notable}");
            Console.WriteLine($"90 - 100 (Excelente): {excelente}");
        }
    }

}
