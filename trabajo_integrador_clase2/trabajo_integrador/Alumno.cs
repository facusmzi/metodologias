namespace trabajo_integrador;

public class Alumno : Persona
{
    private Numero legajo;
    private Numero promedio;
    private IEstrategiaComparacion estrategia;

    public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
    {
        legajo = l;
        promedio = p;
        estrategia = new ComparacionPorLegajo();
    }


    

    public Numero Legajo
    {
        get { return legajo; }
    }

    public Numero Promedio
    {
        get { return promedio; }
    }

    public IEstrategiaComparacion Estrategia
    {
        get { return estrategia; }
        set { estrategia = value; }
    }

    public override string ToString()
    {
        return $"{nombre} (DNI: {dni}, Legajo: {legajo}, Promedio: {promedio})";
    }

    public override bool SosIgual(IComparable comparable)
    {
        return estrategia.SosIgual(this, comparable);
    }


    public override bool SosMenor(IComparable comparable)
    {
        return estrategia.SosMenor(this, comparable);
    }


    public override bool SosMayor(IComparable comparable)
    {
        return estrategia.SosMayor(this, comparable);
    }

}
