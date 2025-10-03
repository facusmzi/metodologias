namespace trabajo_integrador;

public class IteradorDeLista : IIterador
{
    private List<IComparable> elementos;
    private int posicionActual;

    public IteradorDeLista(List<IComparable> elementos)
    {
        this.elementos = elementos;
        Primero();
    }

    public void Primero()
    {
        posicionActual = 0;
    }

    public void Siguiente()
    {
        posicionActual++;
    }

    public bool Fin()
    {
        return posicionActual >= elementos.Count;
    }

    public IComparable Actual()
    {
        return elementos[posicionActual];
    }
}