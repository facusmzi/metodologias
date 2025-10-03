namespace trabajo_integrador;

public class ColeccionMultiple : IColeccionable
{
    private Pila pila;
    private Cola cola;


    public ColeccionMultiple(Pila p, Cola c)
    {
        this.pila = p;
        this.cola = c;
    }


    public int Cuantos()
    {
        return pila.Cuantos() + cola.Cuantos();
    }


    public IComparable Minimo()
    {

        if (pila.Cuantos() == 0 && cola.Cuantos() == 0)
            throw new InvalidOperationException("Ambas colecciones están vacías");


        if (pila.Cuantos() == 0)
            return cola.Minimo();
        if (cola.Cuantos() == 0)
            return pila.Minimo();


        IComparable minPila = pila.Minimo();
        IComparable minCola = cola.Minimo();

        if (minPila.SosMenor(minCola))
            return minPila;
        else
            return minCola;
    }


    public IComparable Maximo()
    {

        if (pila.Cuantos() == 0 && cola.Cuantos() == 0)
            throw new InvalidOperationException("Ambas colecciones están vacías");


        if (pila.Cuantos() == 0)
            return cola.Maximo();
        if (cola.Cuantos() == 0)
            return pila.Maximo();


        IComparable maxPila = pila.Maximo();
        IComparable maxCola = cola.Maximo();

        if (maxPila.SosMayor(maxCola))
            return maxPila;
        else
            return maxCola;
    }


    public void Agregar(IComparable comparable)
    {

    }


    public bool Contiene(IComparable comparable)
    {
        return pila.Contiene(comparable) || cola.Contiene(comparable);
    }
}
