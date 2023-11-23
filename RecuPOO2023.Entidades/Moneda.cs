using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RecuPOO2023.Entidades
{

    [XmlInclude(typeof (Dolar))]
    [XmlInclude(typeof(Euro))]
    [XmlInclude(typeof(Pesos))]
    public abstract class Moneda
    {
        protected decimal cantidad;

        public virtual decimal Cantidad
        {
            get => cantidad;
            set
            {
                if (value > 0 && value < 200)
                {
                    cantidad = value;
                }
                else if (value > 200)
                {
                     cantidad = 200;
                }
                else
                {
                    value = 0;
                }
                
            }

        }

        //public decimal CalcularCantidad(decimal cantidad)
        //{
        //    if (cantidad > 0 && cantidad < 200)
        //    {
        //        return cantidad;
        //    }
        //    if (cantidad >200)
        //    {
        //        return cantidad = 200;
        //    }
        //    return cantidad = 0;

        //}


        public abstract decimal CalcularValorEnDolares();
        public abstract decimal CalcularValorEnPesos();



        public override bool Equals(object? obj)
        {
            if (obj is Moneda m)
            {
                return this.GetType() == m.GetType();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return GetType().GetHashCode();
        }


        //Moneda()
        //{

        //}
        public Moneda(decimal cantidad)
        {
            this.cantidad = cantidad;
        }


        public virtual string MostrarInfo()
        {
            return $"Moneda:{GetType().Name}- Cantidad:{Cantidad}";
        }

        public static bool operator == (Moneda m1, Moneda m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(Moneda m1, Moneda m2)
        {
            return !(m1==m2);
        }






    }
}
