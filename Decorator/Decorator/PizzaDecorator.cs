using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }

        public virtual string Opcionais()
        {
            var pizza = _pizza.Opcionais();
            return pizza;
        }
    }
}
