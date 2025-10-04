namespace trabajo_integrador;

public class ComparacionPorLegajo : IEstrategiaComparacion
{
    public bool sosIgual(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getLegajo().sosIgual(alumnoB.getLegajo());
    }

    public bool sosMenor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getLegajo().sosMenor(alumnoB.getLegajo());
    }

    public bool sosMayor(IComparable a, IComparable b)
    {
        Alumno alumnoA = (Alumno)a;
        Alumno alumnoB = (Alumno)b;
        return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
    }
}