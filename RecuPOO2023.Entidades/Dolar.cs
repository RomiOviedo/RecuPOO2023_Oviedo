using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public class Dolar : Moneda
    {

        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;



        public override decimal CalcularValorEnDolares()
        {
            return Cantidad;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad * CotizacionCompra();
        }

        public decimal CotizacionCompra()
        {
            return cotizacionCompra;
        }

        public decimal CotizacionVenta()
        {
            return cotizacionVenta;
        }

        static Dolar()
        {
            cotizacionCompra = 348.50m;
            cotizacionVenta = 368.50m;
        }

        public Dolar(decimal cantidad) : base(cantidad)
        {
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}- Valor en Pesos: {CalcularValorEnPesos()}";
        }

    }
}
