namespace trabajo_integrador;

public abstract class Persona : IComparable
{
    protected string nombre;
    protected Numero dni;

    public Persona(string n, Numero d)
    {
        nombre = n;
        dni = d;
    }

    public string Nombre
    {
        get { return nombre; }
    }

    public Numero DNI
    {
        get { return dni; }
    }

    public virtual bool SosIgual(IComparable comparable)
    {
        Persona persona = (Persona)comparable;
        return this.dni.SosIgual(persona.DNI);
    }

    public virtual bool SosMenor(IComparable comparable)
    {
        Persona persona = (Persona)comparable;
        return this.dni.SosMenor(persona.DNI);
    }

    public virtual bool SosMayor(IComparable comparable)
    {
        Persona persona = (Persona)comparable;
        return this.dni.SosMayor(persona.DNI);
    }
}
