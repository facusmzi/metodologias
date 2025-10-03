namespace trabajo_integrador;

public class Conjunto : IColeccionable
{
    private List<IComparable> elementosComparables;

    public Conjunto()
    {
        this.elementosComparables = new List<IComparable>();
    }

    public void Agregar(IComparable comparable)
    {
        if (!Pertenece(comparable))
        {
            elementosComparables.Add(comparable);
        }
    }
    
    public bool Pertenece(IComparable comparable)
    {
        for (int i = 0; i < this.elementosComparables.Count; i++)
        {
            if (this.elementosComparables[i].SosIgual(comparable))
            {
                return true;
            }
        }
        return false;
    }
    
    public int Cuantos()
    {
        return elementosComparables.Count;
    }

    public IComparable Minimo()
    {
        if (elementosComparables.Count == 0)
        {
            return null; 
        }

        IComparable minimo = this.elementosComparables[0];

        for (int i = 1; i < this.Cuantos(); i++)
        {
            if (this.elementosComparables[i].SosMenor(minimo))
            {
                minimo = this.elementosComparables[i];
            }
        }
        return minimo;
    }

    public IComparable Maximo()
    {
        if (elementosComparables.Count == 0)
        {
            return null; 
        }

        IComparable maximo = this.elementosComparables[0];

        for (int i = 1; i < this.Cuantos(); i++)
        {
            if (this.elementosComparables[i].SosMayor(maximo))
            {
                maximo = this.elementosComparables[i];
            }
        }
        return maximo;
    }
    
    public bool Contiene(IComparable comparable)
    {
        return Pertenece(comparable);
    }

}