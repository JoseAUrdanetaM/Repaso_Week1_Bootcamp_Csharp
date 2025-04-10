namespace Week2_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RETO #1: Arrays Unilaterales

            //SISTEMA DE CALIFICACIONES

            // Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
            // diferentes operaciones estadísticas.

            //    Requisitos:
            //    1.Crear un array para almacenar las calificaciones de 10 estudiantes(valores entre 0 y 100)
            //    2.Implementar las siguientes funcionalidades:
            //    -Calcular el promedio de calificaciones
            //       -Encontrar la calificación más alta y la más baja
            //       -Calcular cuántos estudiantes aprobaron(calificación >= 60)
            //       - Mostrar las calificaciones en orden ascendente
            //       - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
            //         *0 - 59(Reprobado)
            //         * 60 - 69(Suficiente)
            //         * 70 - 79(Bien)
            //         * 80 - 89(Notable)
            //         * 90 - 100(Excelente)

            //    Extra(opcional):
            //    -Permitir que el usuario ingrese las calificaciones
            //    -Implementar un menú para que el usuario elija la operación a realizar
            //    */

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

        /*
         * 
         * 
        RETO #2: List
        // Operaciones del reto
        // Crear la lista, agregar los valores y hacer las operaciones
        // Filtrar los libros con stock de mas de 10 unidades
        // Filtrar el stock por precio mas grande de 10.99 soles
        // Encontrar el indice del libro que empiece con "El"


        RETO #3 OPCIONAL: MATRIZ DE TEMPERATURAS SEMANALES

           Objetivo: Crear un programa que registre y analice temperaturas diarias por semana usando arrays bidimensionales.

           Requisitos:
           1. Crear una matriz para almacenar las temperaturas de 4 semanas (filas) y 7 días por semana (columnas)
           2. Permitir al usuario introducir las temperaturas o generarlas aleatoriamente entre 10°C y 35°C
           3. Calcular y mostrar:
              - La temperatura media de cada semana
              - La temperatura media de cada día de la semana (todos los lunes, todos los martes, etc.)
              - El día más caluroso y el más frío (indicando semana y día)
           4. Mostrar gráficamente la matriz de temperaturas con formato adecuado

           Bonus (opcional):
           - Generar un gráfico ASCII simple que muestre la evolución de temperaturas
           - Permitir buscar días con temperatura superior o inferior a un valor introducido por el usuario
           */

        
            // Operaciones del reto
            // Crear la lista, agregar los valores y hacer las operaciones
            // Filtrar los libros con stock de mas de 10 unidades
            // Filtrar el stock por precio mas grande de 10.99 soles
            // Encontrar el indice del libro que empiece con "El"
        }


        List<Libro> libros = new List<Libro>
        {
                new Libro { Nombre = "Cien años de soledad", Precio = 34.50, Stock = 12 },
                new Libro { Nombre = "1984", Precio = 19.99, Stock = 8 },
                new Libro { Nombre = "Don Quijote de la Mancha", Precio = 42.75, Stock = 4 },
                new Libro { Nombre = "El nombre del viento", Precio = 29.90, Stock = 10 },
                new Libro { Nombre = "La sombra del viento", Precio = 27.40, Stock = 7 },
                new Libro { Nombre = "Crónica de una muerte anunciada", Precio = 15.60, Stock = 15 },
                new Libro { Nombre = "Los juegos del hambre", Precio = 23.20, Stock = 11 },
                new Libro { Nombre = "Rayuela", Precio = 31.99, Stock = 3 },
                new Libro { Nombre = "Fahrenheit 451", Precio = 18.25, Stock = 9 },
                new Libro { Nombre = "El alquimista", Precio = 20.00, Stock = 6 },
        };

            // Operaciones del reto
            // Crear la lista, agregar los valores y hacer las operaciones


            // Filtrar los libros con stock de mas de 10 unidades
            List<Libro> stockSobreDiez = libros.FindAll(p => p.Stock > 10);
            Console.WriteLine($"Libros con más de 10 unidades:");
            foreach(var stock in stockSobreDiez)
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
    }


    // Clase auxiliar para demostraciones
    class Persona
{    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Dni { get; set; }
}

class Libro
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
    }
    }
}
