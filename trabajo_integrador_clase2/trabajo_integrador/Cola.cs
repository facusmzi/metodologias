namespace trabajo_integrador;

public class Cola : IColeccionable
{
    private List<IComparable> elementos;

    public Cola()
    {
        this.elementos = new List<IComparable>();
    }

    public void Encolar(IComparable elem)
    {
        elementos.Add(elem);
    }

    public IComparable Desencolar()
    {
        if (this.Vacia())
        {
            return null;
        }

        IComparable aux = elementos[0];
        elementos.RemoveAt(0);
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

        return elementos[0];
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
        Encolar(comparable);
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
}
