namespace trabajo_integrador;

public interface IIterador
{
    void Primero();
    void Siguiente();
    bool Fin();
    IComparable Actual();
}