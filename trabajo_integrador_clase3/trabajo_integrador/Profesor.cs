namespace trabajo_integrador;

public class Profesor : Persona, IObservado
{
    private Numero antiguedad;
    private List<IObservador> observadores;
    private string ultimaAccion;

    public Profesor(string n, Numero d, Numero a) : base(n, d)
    {
        antiguedad = a;
        observadores = new List<IObservador>();
        ultimaAccion = "";
    }

    public Numero Antiguedad
    {
        get { return antiguedad; }
    }
    
    public string UltimaAccion
    {
        get { return ultimaAccion; }
    }

    public void HablarALaClase()
    {
        Console.WriteLine("Hablando de algún tema");
        ultimaAccion = "hablar";
        Notificar();
    }

    public void EscribirEnElPizarron()
    {
        Console.WriteLine("Escribiendo en el pizarrón");
        ultimaAccion = "escribir";
        Notificar();
    }

    public override bool SosIgual(IComparable comparable)
    {
        Profesor otro = (Profesor)comparable;
        return this.antiguedad.SosIgual(otro.antiguedad);
    }

    public override bool SosMenor(IComparable comparable)
    {
        Profesor otro = (Profesor)comparable;
        return this.antiguedad.SosMenor(otro.antiguedad);
    }

    public override bool SosMayor(IComparable comparable)
    {
        Profesor otro = (Profesor)comparable;
        return this.antiguedad.SosMayor(otro.antiguedad);
    }

    public override string ToString()
    {
        return $"{nombre} (DNI: {dni}, Antigüedad: {antiguedad} años)";
    }
    
    // IObservado
    public void AgregarObservador(IObservador observador)
    {
        observadores.Add(observador);
    }

    public void QuitarObservador(IObservador observador)
    {
        observadores.Remove(observador);
    }

    public void Notificar()
    {
        foreach (IObservador observador in observadores)
        {
            observador.Actualizar(this);
        }
    }
    
}