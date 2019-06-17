using DecoratorPattern.Logged;
using System;

namespace DecoratorPattern
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA();
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB();

            // Link decorators
            decorator1.SetComponent(component);
            decorator2.SetComponent(decorator1);

            decorator2.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}