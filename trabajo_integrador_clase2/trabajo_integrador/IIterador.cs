namespace trabajo_integrador;

public interface IIterador
{
    void primero();
    void siguiente();
    bool fin();
    IComparable actual();
}