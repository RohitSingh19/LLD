
namespace LLD.DesignPatterns.Prototype
{
    public class Rectangle : IShape
    {
        private int _height;
        private int _width;
        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public IShape Clone()
        {
            return new Rectangle(_height, _width);
        }

        public void Draw()
        {
            Console.WriteLine($"Rectange drawn with {_height} and {_width}");
        }
    }
}
