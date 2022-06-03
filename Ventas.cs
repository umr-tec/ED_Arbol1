using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Diccionarios_
{
   
    class Ventas : ICalculaIVA
    {
        //Miembro de tipo campo
        byte cantidadArticulos;
        double precioArticulo;

        public double calcular(double iva)
        {
            return 0;
        }

        // double CalcularIVA(double iva);
        public double CalcularIVA(double iva)
        {
            throw new NotImplementedException();
        }

        public double Venta() {

            return cantidadArticulos * precioArticulo;
        }
    }
}
