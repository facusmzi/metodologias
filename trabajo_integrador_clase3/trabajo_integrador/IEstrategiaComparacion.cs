namespace trabajo_integrador;

public interface IEstrategiaComparacion
{
    bool sosIgual(IComparable a, IComparable b);
    bool sosMenor(IComparable a, IComparable b);
    bool sosMayor(IComparable a, IComparable b);
}