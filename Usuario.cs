using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciotemplateMethod
{
    public class Usuario
    {
        static void Main(string[] args)
        {
            Pedido  pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.setImporteSinIVA(1234.45);
            pedidoEspaña.calculaPrecioConIva();
            pedidoEspaña.visualiza();

            Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
            pedidoEspaña.setImporteSinIVA(1234.45);
            pedidoEspaña.calculaPrecioConIva();
            pedidoEspaña.visualiza();
        }
    }
}
