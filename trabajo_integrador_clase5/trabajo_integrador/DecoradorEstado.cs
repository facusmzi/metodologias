namespace trabajo_integrador;

public class DecoradorEstado : AlumnoDecorator
{
    public DecoradorEstado(IAlumno alumno) : base(alumno)
    {
    }

    public override string mostrarCalificacion()
    {
        string resultado = base.mostrarCalificacion();
        int calificacion = alumnoAdicional.getCalificacion();
        string estado = obtenerEstado(calificacion);
        
        return $"{resultado} ({estado})";
    }

    private string obtenerEstado(int calificacion)
    {
        if (calificacion >= 7)
            return "PROMOCIÓN";
        else if (calificacion >= 4)
            return "APROBADO";
        else
            return "DESAPROBADO";
    }
}