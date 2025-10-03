namespace trabajo_integrador;

public class ComparacionPorDNI : IEstrategiaComparacion
{
    public bool SosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.DNI.SosIgual(alumnoB.DNI);
    }

    public bool SosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.DNI.SosMenor(alumnoB.DNI);
    }

    public bool SosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.DNI.SosMayor(alumnoB.DNI);
    }
}