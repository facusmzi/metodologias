namespace trabajo_integrador;

public class Alumno : Persona
{
    private Numero legajo;
    private Numero promedio;

    public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
    {
        legajo = l;
        promedio = p;
    }


    

    public Numero Legajo
    {
        get { return legajo; }
    }

    public Numero Promedio
    {
        get { return promedio; }
    }

    public override string ToString()
    {
        return $"{nombre} (DNI: {dni}, Legajo: {legajo}, Promedio: {promedio})";
    }

    public override bool SosIgual(IComparable comparable)
    {
        return this.legajo.SosIgual((Numero)comparable);
    }

    public override bool SosMenor(IComparable comparable)
    {
        Alumno otro = (Alumno)comparable;
        return this.legajo.SosMenor(otro.legajo);
    }

    public override bool SosMayor(IComparable comparable)
    {
        Alumno otro = (Alumno)comparable;
        return this.legajo.SosMayor(otro.legajo);
    }

}
