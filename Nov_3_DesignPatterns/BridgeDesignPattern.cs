using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign
{
    class Abstraction
    {
        protected Implementation _implementation;
        public Abstraction(Implementation implementation)
        {
            this._implementation = implementation;
        }
        public virtual string Operation()
        {
            return "Abstract:Base operation with:\n" +_implementation.OperationImplementation;
        }
    }
    class ExtendedAbstraction:Abstraction
    {
        public ExtendedAbstraction(Implementation implementation):base(implementation)
        {

        }
        public override string Operation()
        {
            return "ExtendedAbstraction:Extended operation with:\n" + base._implementation.OperationImplementation();
        }
    }
    public interface Implementation
    {
        string OperationImplementation();
    }
    class ConcreteImplementationA:Implementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementation: The result in platform A.\n";
        }
    }
    class ConcreteImplementationB : Implementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementation: The result in platform B.\n";
        }
    }
    class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Abstraction abstraction;
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
