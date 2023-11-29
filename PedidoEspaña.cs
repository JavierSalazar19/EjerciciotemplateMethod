using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciotemplateMethod
{
    public class PedidoEspaña : Pedido
    {
        protected override void calculaIVA()
        {
            importeIVA = importeSinIVA * 0.20;
        }
    }
}
