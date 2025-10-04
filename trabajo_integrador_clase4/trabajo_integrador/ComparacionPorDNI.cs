namespace trabajo_integrador
{
    public class ComparacionPorDNI : IEstrategiaComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getDNI().sosIgual(alumnoB.getDNI());
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getDNI().sosMenor(alumnoB.getDNI());
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getDNI().sosMayor(alumnoB.getDNI());
        }
    }
}