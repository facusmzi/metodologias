namespace trabajo_integrador;

public class FabricaDeProfesores : FabricaDeComparables
{
    public override IComparable CrearPorAleatorio()
    {
        string nombre = GeneradorDeDatosAleatorios.StringAleatorio(8);
        int dni = GeneradorDeDatosAleatorios.NumeroAleatorio(45000000) + 20000000;
        int antiguedad = GeneradorDeDatosAleatorios.NumeroAleatorio(40);
        
        return new Profesor(
            nombre,
            new Numero(dni),
            new Numero(antiguedad)
        );
    }

    public override IComparable CrearPorLector()
    {
        Console.Write("Ingrese nombre: ");
        string nombre = LectorDeDatos.StringPorTeclado();
        
        Console.Write("Ingrese DNI: ");
        int dni = LectorDeDatos.NumeroPorTeclado();
        
        Console.Write("Ingrese antigüedad (años): ");
        int antiguedad = LectorDeDatos.NumeroPorTeclado();
        
        return new Profesor(
            nombre,
            new Numero(dni),
            new Numero(antiguedad)
        );
    }
}