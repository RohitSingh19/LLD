namespace LLD.DesignPatterns.Prototype
{
    public class Cirlce : IShape
    {
        private int _radius;
        public Cirlce(int radius)
        {
            _radius = radius;
        }
        public IShape Clone()
        {
            return new Cirlce(this._radius);
        }

        public void Draw()
        {
            Console.WriteLine($"Circle drawn with radius {this._radius}");
        }
    }
}
