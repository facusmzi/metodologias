namespace trabajo_integrador
{
    public class ComparacionPorPromedio : IEstrategiaComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getPromedio().sosIgual(alumnoB.getPromedio());
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getPromedio().sosMenor(alumnoB.getPromedio());
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            Alumno alumnoA = (Alumno)a;
            Alumno alumnoB = (Alumno)b;
            return alumnoA.getPromedio().sosMayor(alumnoB.getPromedio());
        }
    }
}