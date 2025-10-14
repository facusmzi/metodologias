namespace trabajo_integrador;

public class FabricaDeAlumnosMuyEstudiososProxy : FabricaDeComparables
{
    public override IComparable crearPorAleatorio()
    {
        string nombre = GeneradorDeDatosAleatorios.stringAleatorio(8);

        return new AlumnoProxy(nombre, 4);
    }
        
    public override IComparable crearPorLector()
    {
        Console.Write("Ingrese nombre para el proxy: ");
        string nombre = LectorDeDatos.stringPorTeclado();

        return new AlumnoProxy(nombre, 4);
    }
}
