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
        
        // ej 9
        Pila pila = new Pila();
        LlenarAlumnos(pila);
        CambiarEstrategia(pila, new ComparacionPorNombre());
        Console.WriteLine("Comparando por nombre (alfabeticamente): ");
        Informar(pila, "nombre");

        CambiarEstrategia(pila, new ComparacionPorLegajo());
        Console.WriteLine("\nComparando por legajo: ");
        Informar(pila, "legajo");


        CambiarEstrategia(pila, new ComparacionPorPromedio());
        Console.WriteLine("\nComparando por promedio: ");
        Informar(pila, "promedio");

        CambiarEstrategia(pila, new ComparacionPorDNI());
        Console.WriteLine("\nComparando por dni: ");
        Informar(pila, "dni");
        
        
        
        
        
        // ej 2
        // IColeccionable pila = new Pila();
        // IColeccionable cola = new Cola();
        // IColeccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
        // LlenarAlumnos(pila);
        // LlenarAlumnos(cola);
        //
        // Console.WriteLine("=== INFORME DE LA PILA ===");
        // Informar(pila);
        //
        // Console.WriteLine("\n=== INFORME DE LA COLA ===");
        // Informar(cola);
        
        
        
        // ej 7
        /*Pila pila = new Pila();
        Cola cola = new Cola();
        Conjunto conjunto = new Conjunto();
    
        LlenarAlumnos(pila);
        LlenarAlumnos(cola);
        LlenarAlumnos(conjunto);
    
        Console.WriteLine("=== ELEMENTOS DE LA PILA ===");
        ImprimirElementos(pila);
    
        Console.WriteLine("\n=== ELEMENTOS DE LA COLA ===");
        ImprimirElementos(cola);
    
        Console.WriteLine("\n=== ELEMENTOS DEL CONJUNTO ===");
        ImprimirElementos(conjunto);*/
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
    /*public static void Informar(IColeccionable col)
    {
        Console.WriteLine("Cantidad de elementos: " + col.Cuantos().ToString());
        Console.WriteLine("El mínimo es: " + col.Minimo().ToString());
        Console.WriteLine("El máximo es: " + col.Maximo().ToString());

        Console.WriteLine("Ingrese valor a buscar en el coleccionable: ");
        int valorBuscado = int.Parse(Console.ReadLine()!);

       
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
    }*/
    
    // ej 9
    static void Informar(IColeccionable col, string tipoBusqueda)
    {
        Console.WriteLine("Cantidad de elementos: " + col.Cuantos());
        Console.WriteLine("El mínimo es: " + col.Minimo());
        Console.WriteLine("El máximo es: " + col.Maximo());

        Alumno alumnoBuscado = null;

        switch (tipoBusqueda.ToLower())
        {
            case "nombre":
                Console.Write("Ingrese nombre a buscar: ");
                string nombre = Console.ReadLine() ?? "";
                alumnoBuscado = new Alumno(nombre, new Numero(0), new Numero(0), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorNombre();
                break;

            case "legajo":
                Console.Write("Ingrese legajo a buscar: ");
                int legajo = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(legajo), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorLegajo();
                break;

            case "promedio":
                Console.Write("Ingrese promedio a buscar: ");
                int promedio = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(0), new Numero(0), new Numero(promedio));
                alumnoBuscado.Estrategia = new ComparacionPorPromedio();
                break;

            case "dni":
                Console.Write("Ingrese DNI a buscar: ");
                int dni = int.Parse(Console.ReadLine()!);
                alumnoBuscado = new Alumno("", new Numero(dni), new Numero(0), new Numero(0));
                alumnoBuscado.Estrategia = new ComparacionPorDNI();
                break;

            default:
                Console.WriteLine("Tipo de búsqueda desconocido.");
                return;
        }

        Console.WriteLine("El valor " + (col.Contiene(alumnoBuscado) ? "está" : "no está") + " en la colección.");
    }


    
    // Ejercicio 6
    public static void ImprimirElementos(IColeccionable coleccionable)
    {
        
        IIterable iterable = (IIterable)coleccionable;
        IIterador iterador = iterable.CrearIterador();
    
        while (!iterador.Fin())
        {
            Console.WriteLine(iterador.Actual());
            iterador.Siguiente();
        }
    }
    
    
    static void CambiarEstrategia(IColeccionable coleccionable, IEstrategiaComparacion estrategia)
    {
        IIterable iterable = (IIterable)coleccionable; 
        IIterador iterador = iterable.CrearIterador();
        iterador.Primero();

        while (!iterador.Fin())
        {
            Alumno alumno = (Alumno)iterador.Actual(); 
            alumno.Estrategia = estrategia;
            iterador.Siguiente();
        }
    }
    



}
