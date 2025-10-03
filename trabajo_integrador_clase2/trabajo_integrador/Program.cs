namespace trabajo_integrador;

class Program
{

    private static Random Random = new Random();

    // Arrays para generar nombres aleatorios
    private static string[] nombres = {
        "Juan", "María", "Carlos", "Ana", "Luis", "Carmen", "Pedro", "Laura",
        "Miguel", "Sofia", "Diego", "Valeria", "Pablo", "Gabriela", "Andrés",
        "Camila", "Sebastián", "Martina", "Federico", "Agustina"
    };

    private static string[] apellidos = {
        "González", "Rodríguez", "Pérez", "López", "Martínez", "García",
        "Fernández", "Álvarez", "Romero", "Suárez", "Torres", "Ruiz",
        "Ramírez", "Flores", "Benítez", "Medina", "Herrera", "Castillo",
        "Morales", "Ortega"
    };


    static void Main(string[] args)
    {
        IColeccionable pila = new Pila();
        IColeccionable cola = new Cola();
        IColeccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
        LlenarAlumnos(pila);
        LlenarAlumnos(cola);

        Console.WriteLine("=== INFORME DE LA PILA ===");
        Informar(pila);

        Console.WriteLine("\n=== INFORME DE LA COLA ===");
        Informar(cola);
    }


    // ej 2
    public static void LlenarAlumnos(IColeccionable coleccionable)
    {
        for (int i = 0; i < 20; i++)
        {
            string nombreAlAzar = nombres[Random.Next(nombres.Length)];
            int dniAlAzar = Random.Next(20000000, 45000000);
            int legajoAlAzar = Random.Next(1000, 9999);
            int promedioAlAzar = Random.Next(0, 11);

            Alumno alumno = new Alumno(
                nombreAlAzar,
                new Numero(dniAlAzar),
                new Numero(legajoAlAzar),
                new Numero(promedioAlAzar)
            );
            
            
            alumno.Estrategia = new ComparacionPorDNI();

            coleccionable.Agregar(alumno);
        }
    }
    
    // ej 2
    public static void Informar(IColeccionable col)
    {
        Console.WriteLine("Cantidad de elementos: " + col.Cuantos().ToString());
        Console.WriteLine("El mínimo es: " + col.Minimo().ToString());
        Console.WriteLine("El máximo es: " + col.Maximo().ToString());

        Console.WriteLine("Ingrese valor a buscar en el coleccionable: ");
        int valorBuscado = int.Parse(Console.ReadLine()!);

        // Alumno ficticio con solo el promedio cargado
        Alumno alumnoBuscado = new Alumno(
            "",
            new Numero(valorBuscado),   // DNI 
            new Numero(0),   // Legajo vacío
            new Numero(0) // Promedio vacio
        );
        alumnoBuscado.Estrategia = new ComparacionPorPromedio();

        if (col.Contiene(alumnoBuscado))
            Console.WriteLine("El elemento leído está en la colección.");
        else
            Console.WriteLine("El elemento leído no está en la colección.");
    }

    
    
    



}
