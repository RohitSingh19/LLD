namespace LLD.DesignPatterns.Prototype
{
    public class PrototypeRunner
    {
        public void protoTypeRunnerMethod()
        {
            ShapeDrawingApp drawingApp = new ShapeDrawingApp();

            IShape shapeC = drawingApp.GetShape("Circle");
            shapeC.Draw();

            IShape shapeR = drawingApp.GetShape("Rectangle");
            shapeR.Draw();
        }
    }
}

/*
 
In this example, we have an interface IShape that defines the Clone() method and Draw() method. 
The concrete classes Circle and Rectangle implement the IShape interface. 
Each concrete class overrides the Clone() method to create a new instance of itself and implements the Draw() method to display information about the shape.

The ShapeDrawingApp class acts as the client and maintains a dictionary of prototype shapes (Circle and Rectangle) in a shape cache.
The InitializeShapes() method populates the cache with initial instances of the shapes.
The GetShape() method retrieves a shape from the cache based on the shape type and returns a clone of the shape using the Clone() method.

In the Main() method, we create an instance of the ShapeDrawingApp and retrieve shapes from the cache using the GetShape() method.
We then call the Draw() method on each shape to demonstrate that they are separate instances and can be used independently.
 
*/


/*if the same program hasn't been implemnted using prototype design pattern then I would like */

/*
 // Without using Prototype design pattern

// Concrete shape classes
class Circle
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {radius}");
    }
}

class Rectangle
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
    }
}

// Client class
class ShapeDrawingApp
{
    public Circle GetCircle(int radius)
    {
        return new Circle(radius);
    }

    public Rectangle GetRectangle(int width, int height)
    {
        return new Rectangle(width, height);
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        ShapeDrawingApp app = new ShapeDrawingApp();

        // Create a circle and draw it
        Circle circle = app.GetCircle(5);
        circle.Draw();

        // Create a rectangle and draw it
        Rectangle rectangle = app.GetRectangle(10, 20);
        rectangle.Draw();

        Console.ReadKey();
    }
}

 */
