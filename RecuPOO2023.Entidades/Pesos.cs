using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public class Pesos:Moneda
    {
        private decimal cantidad;

        private static decimal cotizacionRespectoDolar;

        public override decimal Cantidad 
        { get=>cantidad;

            set
            {
                if (value > 0 )
                {
                    cantidad = value;
                }
            }

        } 






        public override decimal CalcularValorEnDolares()
        {
            return Cantidad * cotizacionRespectoDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad;
        }

        public decimal CotizacionRespectoDolar()
        {
            return cotizacionRespectoDolar;
        }


        static Pesos()
        {
            cotizacionRespectoDolar = 1.07m;
        }

        public Pesos(decimal cantidad) : base(cantidad)
        {
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}- Valor en Dolares: {CalcularValorEnDolares()}";
        }
    












    }
}
