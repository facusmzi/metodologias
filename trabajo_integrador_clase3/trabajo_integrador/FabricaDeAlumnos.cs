namespace trabajo_integrador;

public class FabricaDeAlumnos : FabricaDeComparables
{
    public override IComparable CrearPorAleatorio()
    {
        string nombre = GeneradorDeDatosAleatorios.StringAleatorio(8);
        int dni = GeneradorDeDatosAleatorios.NumeroAleatorio(45000000) + 20000000;
        int legajo = GeneradorDeDatosAleatorios.NumeroAleatorio(9999) + 1000;
        int promedio = GeneradorDeDatosAleatorios.NumeroAleatorio(10);
        
        return new Alumno(
            nombre,
            new Numero(dni),
            new Numero(legajo),
            new Numero(promedio)
        );
    }

    public override IComparable CrearPorLector()
    {
        Console.Write("Ingrese nombre: ");
        string nombre = LectorDeDatos.StringPorTeclado();
        
        Console.Write("Ingrese DNI: ");
        int dni = LectorDeDatos.NumeroPorTeclado();
        
        Console.Write("Ingrese legajo: ");
        int legajo = LectorDeDatos.NumeroPorTeclado();
        
        Console.Write("Ingrese promedio: ");
        int promedio = LectorDeDatos.NumeroPorTeclado();
        
        return new Alumno(
            nombre,
            new Numero(dni),
            new Numero(legajo),
            new Numero(promedio)
        );
    }
}