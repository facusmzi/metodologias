namespace trabajo_integrador;

public class AlumnoMuyEstudioso : Alumno
{
    public AlumnoMuyEstudioso(string n, Numero d, Numero l, Numero p) : base(n, d, l, p)
    {
    }
    
    public override int responderPregunta(int pregunta)
    {
        return pregunta % 3; 
    }
}