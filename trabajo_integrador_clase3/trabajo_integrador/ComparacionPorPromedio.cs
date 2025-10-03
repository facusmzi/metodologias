namespace trabajo_integrador;

public class ComparacionPorPromedio : IEstrategiaComparacion
{
    public bool SosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Promedio.SosIgual(alumnoB.Promedio);
    }

    public bool SosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Promedio.SosMenor(alumnoB.Promedio);
    }

    public bool SosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.Promedio.SosMayor(alumnoB.Promedio);
    }
}