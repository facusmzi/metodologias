namespace trabajo_integrador;

public class DecoradorRecuadro : AlumnoDecorator
{
    public DecoradorRecuadro(IAlumno alumno) : base(alumno)
    {
    }

    public override string mostrarCalificacion()
    {
        string resultado = base.mostrarCalificacion();
        int longitudTexto = resultado.Length;
        int anchoRecuadro = longitudTexto + 4; // 2 espacios + 2 asteriscos
        
        string lineaHorizontal = new string('*', anchoRecuadro);
        string lineaConTexto = $"* {resultado} *";
        
        return $"{lineaHorizontal}\n{lineaConTexto}\n{lineaHorizontal}";
    }
}