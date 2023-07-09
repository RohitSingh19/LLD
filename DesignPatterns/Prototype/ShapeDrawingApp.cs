
namespace LLD.DesignPatterns.Prototype
{
    public class ShapeDrawingApp
    {
        private Dictionary<string, IShape> _shapesCache;
        public ShapeDrawingApp()
        {
            _shapesCache = new Dictionary<string, IShape>();
            InitializeShapes();
        }

        private void InitializeShapes()
        {
            Cirlce cirlce = new Cirlce(5);
            Rectangle rectangle = new Rectangle(10, 20);
            _shapesCache.Add("Circle", cirlce);
            _shapesCache.Add("Rectangle", rectangle);
        }

        public IShape GetShape(string shapeType)
        {
            if (_shapesCache.ContainsKey(shapeType))
            { 
                IShape shape = _shapesCache[shapeType];
                return shape.Clone();
            }
            return null;
        }
    }
}
