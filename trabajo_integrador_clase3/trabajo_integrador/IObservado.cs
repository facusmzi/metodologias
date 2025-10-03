namespace trabajo_integrador;

public interface IObservado
{
    void AgregarObservador(IObservador observador);
    void QuitarObservador(IObservador observador);
    void Notificar();
}