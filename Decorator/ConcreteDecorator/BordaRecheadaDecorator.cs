using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza)
            : base(pizza)
        { }

        public override string Opcionais()
        {
            string pizza = base.Opcionais();
            pizza += "\r \n com borda recheada";
            return pizza;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 6.00M;
            return preco;
        }
    }
}