namespace trabajo_integrador;

public class Pila : IColeccionable, IIterable
{

    private List<IComparable> elementos;

    public Pila()
    {
        elementos = new List<IComparable>();
    }

    public void Apilar(IComparable elem)
    {
        elementos.Add(elem);
    }

    public IComparable Desapilar()
    {
        if (this.Vacia())
            return null;

        IComparable aux;
        int tam = elementos.Count;
        aux = elementos[tam - 1];
        elementos.RemoveAt(tam - 1);
        return aux;
    }

    public bool Vacia()
    {
        return elementos.Count == 0;
    }

    public IComparable Tope()
    {
        if (this.Vacia())
            return null;

        int tam = elementos.Count;
        return elementos[tam - 1];
    }

    // Implementación de IColeccionable
    public int Cuantos()
    {
        return elementos.Count;
    }

    public IComparable Minimo()
    {
        if (this.Vacia())
            return null;

        IComparable min = elementos[0];
        for (int i = 1; i < elementos.Count; i++)
        {
            IComparable actual = elementos[i];
            if (actual.SosMenor(min))
            {
                min = actual;
            }
        }
        return min;
    }

    public IComparable Maximo()
    {
        if (this.Vacia())
            return null;

        IComparable max = elementos[0];
        for (int i = 1; i < elementos.Count; i++)
        {
            IComparable actual = elementos[i];
            if (actual.SosMayor(max))
            {
                max = actual;
            }
        }
        return max;
    }

    public void Agregar(IComparable comparable)
    {
        Apilar(comparable);
    }

    public bool Contiene(IComparable comparable)
    {
        for (int i = 0; i < elementos.Count; i++)
        {
            IComparable actual = elementos[i];
            if (actual.SosIgual(comparable))
            {
                return true;
            }
        }
        return false;
    }
    
    public IIterador CrearIterador()
    {
        return new IteradorDeLista(elementos);
    }
}
