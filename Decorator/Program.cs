using Decorator.Component;
using Decorator.ComponentDecorator;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preço R$ {pizza.Preco()}\n");
            Console.WriteLine("Digite algo para aplicar o decorator");
            Console.ReadKey();

            Console.WriteLine("-------------Aplicando o Decorator------------------");

            // Aplicando o decorator

            IPizza pizza2 = new Pizza();
            IPizza baconDecorator = new BaconDecorator(pizza2);
            IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

            Console.WriteLine(bordaDecorator.Opcionais());
            Console.WriteLine($"Preço Total R$: {bordaDecorator.Preco()}");
            Console.ReadKey();
        }
    }
}
