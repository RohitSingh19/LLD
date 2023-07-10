using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Factory
{
    public class FactoryRunner
    {
        public void FactoryRunnerMethod()
        { 
            ShapeFactory factory = new ShapeFactory();
            IShape shapeC = factory.GetShape("circle");
            shapeC.Draw();

            Console.WriteLine();

            IShape shapeR = factory.GetShape("rectangle");
            shapeR.Draw();

            IShape shape = factory.GetShape("typo");
            shape.Draw();
        }
    }
}
/*
 In this example, we have the IShape interface that defines the common Draw() method for all shapes.
The Circle and Rectangle classes implement the IShape interface, representing concrete products.

The ShapeFactory class acts as the factory and provides the CreateShape() method, which takes a shapeType parameter and returns an instance of the corresponding concrete product.
The factory method hides the creation logic from the client and returns the appropriate shape based on the input.

In the client code, we create an instance of the ShapeFactory. 
We then use the factory's CreateShape() method to create shapes without directly instantiating the concrete product classes.
The client can create different shapes by passing the desired shapeType to the factory method.

By using the Factory design pattern, the client code is decoupled from the concrete product classes. 
It relies on the factory interface to create objects, allowing for easier maintenance, extensibility, and flexibility in adding new shapes in the future without modifying the client code.*/