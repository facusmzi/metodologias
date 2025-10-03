namespace trabajo_integrador;

public class Numero : IComparable
	{

	    private int valor;

	    public Numero(int valor)
	    {
	        this.valor = valor;
	    }

	    public int Valor
	    {
	      get {return this.valor;}
          set {valor = value;}
	    }


	    // Implementamos interfaz Comparable
	    public bool SosIgual(IComparable comparable)
	    {
	        return (this.valor == ((Numero)comparable).valor);
	    }

	    public bool SosMenor(IComparable Comparable)
	    {
	        return (this.valor < ((Numero)Comparable).valor);
	    }

	    public bool SosMayor(IComparable comparable)
	    {
	        return (this.valor > ((Numero)comparable).valor);
	    }

	    // @override
	    public override string ToString()
	    {
	        return this.valor.ToString();
	    }

	}
