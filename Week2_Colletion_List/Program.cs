namespace Week2_Colletion_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    class Libro
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}
