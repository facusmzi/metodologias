namespace trabajo_integrador;

public class ComparacionPorDNI : IEstrategiaComparacion
{
    public bool sosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getDni().sosIgual(alumnoB.getDni());
    }

    public bool sosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getDni().sosMenor(alumnoB.getDni());
    }

    public bool sosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getDni().sosMayor(alumnoB.getDni());
    }
}