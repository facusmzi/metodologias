namespace trabajo_integrador
{
    public class ComparacionPorDNI : IEstrategiaComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return alumnoA.getDni().sosIgual(alumnoB.getDni());
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return alumnoA.getDni().sosMenor(alumnoB.getDni());
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            IAlumno alumnoA = (IAlumno)a;
            IAlumno alumnoB = (IAlumno)b;
            return alumnoA.getDni().sosMayor(alumnoB.getDni());
        }
    }
}