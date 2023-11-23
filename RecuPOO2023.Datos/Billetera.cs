using RecuPOO2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Datos
{
    public class Billetera
    {
        private List<Moneda> monedas;


        public Billetera()
        {
            
        }
        //public override bool Equals(object? obj)
        //{
        //    if (obj is Moneda m)
        //    {
        //        return this.GetType() == m.GetType();
        //    }
        //    return false;
        //}

        public string ExtraerDinero(Moneda moneda)
        {

        }


        //public override int GetHashCode()
        //{
        //    return GetType().GetHashCode();
        //}


        public static bool operator ==(Billetera b, Moneda m)
        {
            if (b is null || m is null)
            {
                return false;
            }
            foreach (var item in b.monedas)
            {
                if (item==m)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Billetera b, Moneda m)
        {
            return !(b == m);
        }

        public static string operator -(Billetera b, Moneda m)
        {
            if (b == m)
            {
                b.monedas.Remove(m);

                foreach (var monedaEnBilletera in b.monedas)
                {
                    if (monedaEnBilletera == m)
                    {
                        monedaEnBilletera.Cantidad -= m.Cantidad;

                        return $"Se retiraron {m.Cantidad} {m.GetType().Name}";
                    }
                }
            }
            return $"No tiene {m.GetType().Name} para retirar";
        }

        public static bool operator +(Billetera b, Moneda m)
        {
            if (b != m)
            {
                b.monedas.Add(m);
                return true;
            }
            else
            {
                foreach (var monedaEnBilletera in b.monedas)
                {
                    if (monedaEnBilletera == m)
                    {
                        monedaEnBilletera.Cantidad += m.Cantidad;
                        return true;
                    }
                }
            }
            return false;
        }

        public static implicit operator string(Billetera b)
        {

            foreach (var item in b.monedas)
            {
                if (item is Pesos p)
                {
                    return p.MostrarInfo();
                }
                if (item is Dolar d)
                {
                    return d.MostrarInfo();
                }
                if (item is Euro e)
                {
                    return e.MostrarInfo();
                }

             }
            return "No tengo dinero";
        }
        public string IngresarDinero(Moneda moneda)
        {
        }









    }
}
