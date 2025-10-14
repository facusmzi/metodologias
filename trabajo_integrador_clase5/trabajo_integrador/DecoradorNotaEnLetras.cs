namespace trabajo_integrador;

public class DecoradorNotaEnLetras : AlumnoDecorator
{
    public DecoradorNotaEnLetras(IAlumno alumno) : base(alumno)
    {
    }

    public override string mostrarCalificacion()
    {
        string resultado = base.mostrarCalificacion();
        int calificacion = alumnoAdicional.getCalificacion();
        string notaEnLetras = convertirNotaALetras(calificacion);
        
        return $"{resultado} ({notaEnLetras})";
    }

    private string convertirNotaALetras(int nota)
    {
        string[] letras = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", 
            "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
        
        if (nota >= 0 && nota <= 10)
            return letras[nota];
        
        return "DESCONOCIDO";
    }
}