namespace trabajo_integrador
{
    public interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable comparable);
        bool contiene(IComparable comparable);
    }
}