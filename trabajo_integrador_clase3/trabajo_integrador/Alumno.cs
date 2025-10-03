namespace trabajo_integrador;

public class Alumno : Persona, IObservador
{
    private Numero legajo;
    private Numero promedio;
    private IEstrategiaComparacion estrategia;
    private string ultimaAccionDelProfesor;

    public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
    {
        legajo = l;
        promedio = p;
        estrategia = new ComparacionPorLegajo();
        ultimaAccionDelProfesor = "";
    }

    public string UltimaAccionDelProfesor
    {
        get { return ultimaAccionDelProfesor; }
        set { ultimaAccionDelProfesor = value; }
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
    
    
    public void PrestarAtencion()
    {
        Console.WriteLine($"  {nombre}: Prestando atención");
    }
    
    
    
    public void Distraerse()
    {
        Random random = new Random();
        string[] distracciones = {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };
        
        int indice = random.Next(distracciones.Length);
        Console.WriteLine($"  {nombre}: {distracciones[indice]}");
    }
    
    // Implementación de IObservador
    public void Actualizar(IObservado observado)
    {
        //Profesor profesor = (Profesor)observado;
        
        if (ultimaAccionDelProfesor == "hablar")
        {
            PrestarAtencion();
        }
        else if (ultimaAccionDelProfesor == "escribir")
        {
            Distraerse();
        }
    }
    

}
