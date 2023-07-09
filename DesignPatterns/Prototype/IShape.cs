namespace LLD.DesignPatterns.Prototype
{
    public interface IShape
    {
        void Draw();
        IShape Clone();
    }
}
