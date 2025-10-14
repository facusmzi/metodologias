namespace trabajo_integrador;

public class DecoradorNumeroOrden : AlumnoDecorator
{
    private static int contador = 0;
    private int numeroOrden;

    public DecoradorNumeroOrden(IAlumno alumno) : base(alumno)
    {
        contador++;
        numeroOrden = contador;
    }

    public override string mostrarCalificacion()
    {
        string resultado = base.mostrarCalificacion();
        return $"{numeroOrden}) {resultado}";
    }

    // Método estático para resetear el contador si es necesario
    public static void resetearContador()
    {
        contador = 0;
    }
}