namespace trabajo_integrador;

public class DecoradorLegajo : AlumnoDecorator
{
    public DecoradorLegajo(IAlumno alumno) : base(alumno)
    {
    }

    public override string mostrarCalificacion()
    {
        string nombre = alumnoAdicional.getNombre();
        int legajo = alumnoAdicional.getLegajo().getValor();
        int calificacion = alumnoAdicional.getCalificacion();
    
        return $"{nombre} ({legajo}/{calificacion}) {calificacion}";
    }
}