using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.AbstractFactory
{
    public class UIController
    {
        public void RunUIController()
        { 
            IUIFactory WFactory = new WindowsFactory();
            IUIButton windowButton = WFactory.GetButton();
            windowButton.RenderButton();
            IUICheckBox windowCheckBox = WFactory.GetCheckBox();    
            windowCheckBox.RenderCheckBox();

            IUIFactory mFactory = new MacOsFactory();

            IUIButton macButton = mFactory.GetButton();
            macButton.RenderButton();
            IUICheckBox macCheckBox = mFactory.GetCheckBox();
            macCheckBox.RenderCheckBox();
        }
    }
}


/*
 

The Abstract Factory design pattern consists of the following components:

Abstract Factory: This is the interface or abstract class that declares the factory methods for creating related objects. It provides an interface for creating families of objects, but it does not specify the concrete classes.

Concrete Factories: These are the classes that implement the Abstract Factory interface or derive from the Abstract Factory abstract class. Each concrete factory represents a specific family of related objects. Each factory method in the concrete factories is responsible for creating a specific type of object within that family.

Abstract Products: These are the interfaces or abstract classes that define the common methods that the products (objects) within a family must implement.

Concrete Products: These are the classes that implement the Abstract Product interfaces or derive from the Abstract Product abstract classes. Each concrete product represents a specific object within a family of related objects



 In the above example, we have the IUIFactory interface, which declares the factory methods for creating UI controls (CreateButton() and CreateCheckbox()). The IButton and ICheckbox interfaces define the common methods that the UI controls within each family must implement.

The Windows and macOS concrete factories (WindowsUIFactory and MacOSUIFactory) implement the IUIFactory interface and provide the specific implementations for creating Windows-specific and macOS-specific UI controls. Each factory method in the concrete factories returns a specific type of UI control within the respective family.

The Windows and macOS concrete product classes (WindowsButton, WindowsCheckbox, MacOSButton, and MacOSCheckbox) implement the IButton and ICheckbox interfaces, representing the specific UI controls for each operating system.

In the client code, we create instances of the concrete factories (WindowsUIFactory and MacOSUIFactory) and use them to create UI controls (IButton and ICheckbox) without directly instantiating the concrete product classes. The client code can create different UI controls for different operating systems by using the appropriate concrete factory.

By using the Abstract Factory design pattern, the client code is decoupled from the specific implementations of the UI controls and operating systems. It relies on the abstract factory interface (IUIFactory) to create families of related UI controls, allowing for easier maintenance, extensibility, and flexibility in supporting different operating systems and UI control variations.
 */