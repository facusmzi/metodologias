namespace trabajo_integrador;

public class OrdenInicio : IOrdenEnAula1
{
    private Aula aula;
        
    public OrdenInicio(Aula a)
    {
        aula = a;
    }
        
    public void ejecutar()
    {
        aula.comenzar();
    }
}
