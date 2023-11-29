using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciotemplateMethod
{
    public abstract class Pedido
    {
        protected double importeSinIVA;
        protected double importeIVA;
        protected double importeConIVA;

        protected abstract void calculaIVA();

        public void calculaPrecioConIva()
        {
            this.calculaIVA();
            importeConIVA = importeSinIVA + importeIVA;
        }

        public void setImporteSinIVA(double importeSinIVA)
        {
            this.importeSinIVA = importeSinIVA;
        }
        public void visualiza()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine("Importe sin IVA "+ importeSinIVA);
            Console.WriteLine("Importe con IVA" + importeConIVA);
        }
    }
}
