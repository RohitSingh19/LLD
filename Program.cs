
using LLD.DesignPatterns.AbstractFactory;
using LLD.DesignPatterns.Adapter;
using LLD.DesignPatterns.Builder;
using LLD.DesignPatterns.Composite;
using LLD.DesignPatterns.Decorator;
using LLD.DesignPatterns.Facade;
using LLD.DesignPatterns.Factory;
using LLD.DesignPatterns.Observer;
using LLD.DesignPatterns.Prototype;
using LLD.DesignPatterns.Singleton;
using LLD.DesignPatterns.State;
using LLD.DesignPatterns.Strategy;
using LLD.DesignPatterns.Template;
using LLD.OOP;

public class Program
{
    public static void Main(string[] args)
    {
        //EncapsulationExample eg = new EncapsulationExample();
        //eg.Run();

        //InheritanceExample example = new InheritanceExample();
        //example.Run();
        //inhertiance inhertiance = new inhertiance();
        //inhertiance.Function();

        //AssociationExample example = new AssociationExample();
        //example.RunAssociationExample();


        //DocumentEngine documentEngine = new DocumentEngine();
        //documentEngine.RunDocumentEngine();

        //DocumentGeneratorClient documentGeneratorClient = new DocumentGeneratorClient();
        //documentGeneratorClient.RunDocumentEngine();

        //PrototypeRunner runner = new PrototypeRunner();
        //runner.protoTypeRunnerMethod();

        //FactoryRunner factoryRunner = new FactoryRunner();
        //factoryRunner.FactoryRunnerMethod();

        //UIController controller = new UIController();
        //controller.RunUIController();

        //StateRunner runner = new StateRunner();

        //FacadeRunner facadeRunner = new FacadeRunner(); 

        //SingletonRunner singletonRunner = new SingletonRunner();

        //DecoratorRunner decoratorRunner = new DecoratorRunner();

        //CompositeRunner compositeRunner = new CompositeRunner();    


        //Third third = new Third();
        //third.Runner();

        //AdapterRunner adapterRunner = new AdapterRunner();

        //StaticExample staticExample = new StaticExample();
        //pub pub = new pub();

        //StrategyClient client1 = new StrategyClient("UPI", 250);
        //StrategyClient client2 = new StrategyClient("NEFT", 250);
        //StrategyClient client3 = new StrategyClient("N", 250);
        RunObserver runObserver = new RunObserver();

    }
}



public class Test
{
    Thread t = new Thread(testFunction)
    {
        Name = "Test",
    };
    static void testFunction()
    {
        Console.WriteLine("Hi I'm a test function");
    }
}

public class pub
{
    dynamic a;
    private string name;
    public string n;
   public pub(int a) 
   {
   
   }

   public string Name 
   { 
        get
        {
             return name;
        }
        set
        { 
            name = value;
        }
   }
   public pub() 
   {
        AddDelegate add = new AddDelegate(Add);
        int a = add(10, 20);
   }

    public delegate int AddDelegate(int a, int b);
    public int Add(int a, int b)
    {
        return a + b;
    }
   
}
public class sub : pub
{

    public void aa()
    {
        sub s = new sub();
        sub sb = s;
        
    }
}