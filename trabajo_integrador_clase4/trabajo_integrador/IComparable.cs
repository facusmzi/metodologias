namespace trabajo_integrador
{
    public interface IComparable
    {
        bool sosIgual(IComparable otro);
        bool sosMenor(IComparable otro);
        bool sosMayor(IComparable otro);
    }
}