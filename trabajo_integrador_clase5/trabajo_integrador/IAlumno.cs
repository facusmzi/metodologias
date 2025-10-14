namespace trabajo_integrador
{
    public interface IAlumno : IComparable
    {
        Numero getLegajo();
        string getNombre();
        Numero getDni();
        Numero getPromedio();

        int getCalificacion();
        void setCalificacion(int calificacion);

        void setNombre(string nombre);

        void setEstrategia(IEstrategiaComparacion estrategia);
        IEstrategiaComparacion getEstrategia();

        void prestarAtencion();
        void distraerse();
        void actualizar(IObservado observado);

        int responderPregunta(int pregunta);
        string mostrarCalificacion();
    }
}