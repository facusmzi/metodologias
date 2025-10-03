namespace trabajo_integrador;

public interface IEstrategiaComparacion
{
    bool SosIgual(IComparable a, IComparable b);
    bool SosMenor(IComparable a, IComparable b);
    bool SosMayor(IComparable a, IComparable b);
}