namespace Week2_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RETO BUCLES #1 Tabla de Multiplicar ##################################################################
            //Console.WriteLine("Bienvenido a la tabla de multiplicación, ingrese el número de tabla a multiplicar:");
            //int baseNumber = Convert.ToInt32(Console.ReadLine());
            //int result;
            //Console.WriteLine("");
            //Console.WriteLine($"Tabla del {baseNumber}");
            //for (int i = 0; i < 11; i++)
            //{
            //    result = baseNumber * i;
            //    Console.WriteLine($"{baseNumber} x {i} = {result}");
            //}
            //######################################################################################################

            //RETO BUCLES #2 Patrones en escalera ##################################################################
            //Console.WriteLine("");
            //Console.WriteLine("Generador de patrón escalera");
            //Console.WriteLine("Inserte la cantidad de pisos");
            //int baseTriangleNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //for (int i = 0; i <= baseTriangleNumber; i++)
            //{
            //    Console.Write("* ");
            //    for (int b = 1; b <= i; b++)
            //    {
            //        Console.Write(b + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("Se acabó el bucle");
            //######################################################################################################

            //RETO BUCLES #3 Write a program in C# Sharp to display the multiplication table of a given integer. ####
            // Test Data:
            // Input the number(Table to be calculated) : 15
            // Expected Output :
            // 15 X 1 = 15...
            // ...
            // 15 X 10 = 150

            //Console.WriteLine("\nBienvenido a los while loops");
            //Console.WriteLine("Ingrese el valor de la tabla de multiplicar:");
            //int valorTabla = Convert.ToInt32(Console.ReadLine());
            //int contadorTabla = 0;
            //while (contadorTabla <= 12)
            //{
            //    int resultado = valorTabla * contadorTabla;
            //    Console.WriteLine($"{valorTabla} x {contadorTabla} = {resultado}");
            //    contadorTabla++;
            //}
            //######################################################################################################


            ////  RETO BUCLES #4 Patrones en escalera ##############################################################
            //int inicio = 1;
            //while (inicio <= 5)
            //{
            //    int b = 1;
            //    while (b <= inicio)
            //    {
            //        Console.Write(b + " ");
            //        b++;
            //    }
            //    Console.Write("*");
            //    Console.WriteLine();
            //    inicio++;
            //}
            //######################################################################################################


            //RETO ARRAYS #1: Arrays Unilaterales SISTEMA DE CALIFICACIONES ########################################
            /*
             Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
             diferentes operaciones estadísticas.

                Requisitos:
                1.Crear un array para almacenar las calificaciones de 10 estudiantes(valores entre 0 y 100)
                2.Implementar las siguientes funcionalidades:
                -Calcular el promedio de calificaciones
                   -Encontrar la calificación más alta y la más baja
                   -Calcular cuántos estudiantes aprobaron(calificación >= 60)
                   - Mostrar las calificaciones en orden ascendente
                   - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
                     *0 - 59(Reprobado)
                     * 60 - 69(Suficiente)
                     * 70 - 79(Bien)
                     * 80 - 89(Notable)
                     * 90 - 100(Excelente)

                Extra(opcional):
                -Permitir que el usuario ingrese las calificaciones
                -Implementar un menú para que el usuario elija la operación a realizar
            */

        //    {
        //        Console.WriteLine("SISTEMA DE CALIFICACIONES");
        //        Console.WriteLine("=========================\n");

        //        double[] calificaciones = new double[10];

        //        IngresarCalificaciones(calificaciones);
        //        MostrarCalificaciones(calificaciones);
        //        CalcularEstadisticas(calificaciones);
        //        OrdenarCalificaciones(calificaciones);
        //        MostrarDistribucionRangos(calificaciones);
        //    }

        //private static void IngresarCalificaciones(double[] calificaciones)
        //{
        //    for (int i = 0; i < calificaciones.Length; i++)
        //    {
        //        double entrada;
        //        do
        //        {
        //            Console.Write($"Ingrese la nota #{i + 1} (0 - 100): ");
        //            entrada = Convert.ToDouble(Console.ReadLine());

        //            if (entrada < 0 || entrada > 100)
        //            {
        //                Console.WriteLine("Número inválido. Intenta de nuevo.");
        //            }

        //        } while (entrada < 0 || entrada > 100);

        //        calificaciones[i] = entrada;
        //    }
        //}

        //private static void MostrarCalificaciones(double[] calificaciones)
        //{
        //    Console.WriteLine("\nListado de calificaciones:");
        //    foreach (var nota in calificaciones)
        //    {
        //        Console.Write(nota + " ");
        //    }
        //    Console.WriteLine();

        //    double max = calificaciones[0];
        //    double min = calificaciones[0];

        //    foreach (var nota in calificaciones)
        //    {
        //        if (nota > max) max = nota;
        //        if (nota < min) min = nota;
        //    }

        //    Console.WriteLine($"Nota más alta: {max}");
        //    Console.WriteLine($"Nota más baja: {min}");
        //}

        //private static void CalcularEstadisticas(double[] calificaciones)
        //{
        //    double suma = 0;
        //    int aprobados = 0;

        //    foreach (var nota in calificaciones)
        //    {
        //        suma += nota;
        //        if (nota >= 60)
        //            aprobados++;
        //    }

        //    double promedio = suma / calificaciones.Length;

        //    Console.WriteLine($"\nPromedio general: {promedio:F2}");
        //    Console.WriteLine($"Cantidad de estudiantes aprobados (>=60): {aprobados}");
        //}

        //private static void OrdenarCalificaciones(double[] calificaciones)
        //{
        //    Array.Sort(calificaciones);
        //    Console.WriteLine("\nCalificaciones en orden ascendente:");
        //    foreach (var nota in calificaciones)
        //    {
        //        Console.Write(nota + " ");
        //    }
        //    Console.WriteLine();
        //}

        //private static void MostrarDistribucionRangos(double[] calificaciones)
        //{
        //    int reprobado = 0, suficiente = 0, bien = 0, notable = 0, excelente = 0;

        //    foreach (var nota in calificaciones)
        //    {
        //        if (nota < 60) reprobado++;
        //        else if (nota < 70) suficiente++;
        //        else if (nota < 80) bien++;
        //        else if (nota < 90) notable++;
        //        else excelente++;
        //    }

        //    Console.WriteLine("\nDistribución de calificaciones:");
        //    Console.WriteLine($"0 - 59 (Reprobado): {reprobado}");
        //    Console.WriteLine($"60 - 69 (Suficiente): {suficiente}");
        //    Console.WriteLine($"70 - 79 (Bien): {bien}");
        //    Console.WriteLine($"80 - 89 (Notable): {notable}");
        //    Console.WriteLine($"90 - 100 (Excelente): {excelente}");
        //}



        //RETO ARRAYS #2: List
        //Operaciones del reto

        // Crear la lista, agregar los valores y hacer las operaciones
        List<Libro> libros = new List<Libro>
            {
                new Libro { Nombre = "Cien años de soledad", Precio = 34.50, Stock = 12 },
                new Libro { Nombre = "Don Quijote de la Mancha", Precio = 42.75, Stock = 4 },
                new Libro { Nombre = "1984", Precio = 19.99, Stock = 8 },
                new Libro { Nombre = "El nombre del viento", Precio = 29.90, Stock = 10 },
                new Libro { Nombre = "La sombra del viento", Precio = 27.40, Stock = 7 },
                new Libro { Nombre = "Crónica de una muerte anunciada", Precio = 15.60, Stock = 15 },
                new Libro { Nombre = "Los juegos del hambre", Precio = 23.20, Stock = 11 },
                new Libro { Nombre = "Rayuela", Precio = 31.99, Stock = 3 },
                new Libro { Nombre = "Fahrenheit 451", Precio = 18.25, Stock = 9 },
                new Libro { Nombre = "El alquimista", Precio = 20.00, Stock = 6 },
             };

            // Filtrar los libros con stock de mas de 10 unidades
            List<Libro> stockSobreDiez = libros.FindAll(p => p.Stock > 10);
            Console.WriteLine($"Libros con más de 10 unidades:");
            foreach (var stock in stockSobreDiez)
            {
                Console.WriteLine($"{stock.Nombre}, {stock.Stock}");
            }
            Console.WriteLine("");

            // Filtrar el stock por precio mas grande de 10.99 soles
            List<Libro> precios = libros.FindAll(p => p.Precio > 10.99);
            Console.WriteLine($"Libros mayores a S/10.99:");
            foreach (var precio in precios)
            {
            Console.WriteLine($"{precio.Nombre}, S/{precio.Precio}");
            }
            Console.WriteLine("");

            // Encontrar el indice del libro que empiece con "El"
            int indiceMLetra = libros.FindIndex(p => p.Nombre.StartsWith("El"));
            Console.WriteLine($"Índice del libro que comienza en 'El' es: {indiceMLetra}");
            Console.WriteLine("");
            }
       
           class Libro
            {
                public string Nombre { get; set; }
                public double Precio { get; set; }
                public int Stock { get; set; }
             }

      

        

    }
}
