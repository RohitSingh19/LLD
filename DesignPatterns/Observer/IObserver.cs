namespace LLD.DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(string stockType, decimal amount);
    }
}