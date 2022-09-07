using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public interface IPizza
    {   
        //Adiciona Opcionais ao objeto
        string Opcionais();

        //Recalcula o preço
        decimal Preco();
    }
}
