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

        string[] indexador = { };
        public Billetera()
        {
            monedas = new List<Moneda>();
        }

        public List<Moneda> GetMonedas()
        {
            return monedas;
        }
        public static bool operator ==(Billetera b, Moneda m)
        {
        //     public static bool operator ==(Billetera billetera, Type tipoMoneda)
        //{
            //foreach (Moneda moneda in billetera.monedas)
            //{
            //    if (moneda.GetType() == tipoMoneda)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            if (b is null || m is null)
            {
                return false;
            }
            foreach (var item in b.monedas)
            {
                if (item.GetHashCode()==m.GetHashCode())
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
        //     public static string operator -(Billetera billetera, Moneda moneda)
        //{
        //    foreach (Moneda m in billetera.monedas)
        //    {
        //        if (m.GetType() == moneda.GetType())
        //        {
        //            if (m.Cantidad < moneda.Cantidad)
        //            {
        //                return "Fondos insuficientes!!!";
        //            }
        //            m.Cantidad -= moneda.Cantidad;

        //            if (m.Cantidad == 0)
        //            {
        //                billetera.monedas.Remove(m);
        //            }
        //            return $"Se retiraron {moneda.Cantidad} {moneda.GetType().Name}";
        //        }
        //    }
        //    return $"No tiene {moneda.GetType().Name} para retirar";
        //}


            foreach (var moneda in b.monedas)
            {
                if (moneda.GetType()==m.GetType())
                {
                    if (moneda.Cantidad < m.Cantidad)
                    {
                        return "Fondos Insuficientes";
                    }
                        moneda.Cantidad -= m.Cantidad;

                    if (moneda.Cantidad==0)
                    {
                        b.monedas.Remove(m);
                    }
                    return $"Se retiraron {m.Cantidad} {m.GetType().Name}";

                }
                //if (m is Pesos p)
                //{
                //    if (b == p)
                //    {
                //        if (moneda.Cantidad > m.Cantidad)
                //        {
                //            b.monedas.Remove(m);
                //            return $"Se retiraron {m.Cantidad} {m.GetType().Name}";
                //        }
                //    }
                //}

                //    if (m is Euro e)
                //    {
                //        if (b == e)
                //        {
                //            if (moneda.Cantidad >= m.Cantidad)
                //            {
                //                b.monedas.Remove(m);
                //                return $"Se retiraron {m.Cantidad} {m.GetType().Name}";
                //            }
                //        }
                //    }
                //    if (m is Dolar d)
                //    {
                //        if (b == d)
                //        {
                //            if (moneda.Cantidad >= m.Cantidad)
                //            {
                //                b.monedas.Remove(m);
                //                return $"Se retiraron {m.Cantidad} {m.GetType().Name}";
                //            }
                //        }
                //    }

                //}

                //return $"No tiene {m.Cantidad} {m.GetType().Name}  para retirar";







                //if (b == m)
                //{
                //    b.monedas.Remove(m);

                //    foreach (var monedaEnBilletera in b.monedas)
                //    {
                //        if (monedaEnBilletera == m)
                //        {
                //            monedaEnBilletera.Cantidad -= m.Cantidad;

                //            return $"Se retiraron {m.Cantidad} {m.GetType().Name}";
                //        }
                    }
            //}
            return $"No tiene {m.GetType().Name} para retirar";
        }

        public static bool operator +(Billetera b, Moneda m)
        {
        //         public static bool operator +(Billetera billetera, Moneda moneda)
        //{
        //    foreach (Moneda m in billetera.monedas)
        //    {
        //        if (m.GetType() == moneda.GetType())
        //        {
        //            m.Cantidad += moneda.Cantidad;
        //            return true;
        //        }
        //    }
        //    billetera.monedas.Add(moneda);
        //    return true;
        //}



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

            if (b.monedas.Count==0)
            {
                return "No tengo dinero";
            }

            string info = "";

            foreach (var item in b.monedas)
            {
                info += $"{item.Cantidad} {item.GetType().Name}\n ";

                //if (item is Pesos p)
                //{
                //    return p.MostrarInfo();
                //}
                //if (item is Dolar d)
                //{
                //    return d.MostrarInfo();
                //}
                //if (item is Euro e)
                //{
                //    return e.MostrarInfo();
                //}

             }
            return info;
        }
        //public static implicit operator string(Billetera billetera)
        //{
        //    if (billetera.monedas.Count == 0)
        //        return "No tengo dinero!!!";

        //    string info = "";

        //    foreach (var moneda in billetera.monedas)
        //    {
        //        info += $"{moneda.GetType().Name}: Cantidad - {moneda.Cantidad}\n";
        //    }
        //    return info;
        //}


        public string IngresarDinero(Moneda moneda)
        {
            if (this + moneda)
            {
                if (moneda is Pesos p)
                {
                    return $"Se han ingresado {moneda.Cantidad} Pesos ";
                }
                if (moneda is Dolar d)
                {
                    return $"Se han ingresado {d.Cantidad} Dolares ";
                }
                if (moneda is Euro e)
                {
                    return $"Se han ingresado {e.Cantidad} Euros ";
                }

            }
            return "Operacion Invalida";



            

            //if (moneda is Pesos p)
            //{
            //    return $"Se han ingresado {moneda.Cantidad} Pesos ";
            //}
            //if (moneda is Dolar d)
            //{
            //    return $"Se han ingresado {d.Cantidad} Dolares ";
            //}
            //if (moneda is Euro e)
            //{
            //    return $"Se han ingresado {e.Cantidad} Euros ";
            //}
            //return $"Operacion Invalida";

        }

        public string ExtraerDinero(Moneda moneda)
        {

            return this - moneda;


            //Billetera b = new Billetera();

            //if (moneda is not null)
            //{
            //    return b - moneda;
            //}


            //var ingresarDinero = b - moneda;

            //if (moneda is Pesos p)
            //{
            //    return $"Se han debitado {moneda.Cantidad} Pesos ";
            //}
            //if (moneda is Dolar d)
            //{
            //    return $"Se han debitado {d.Cantidad} Dolares ";
            //}
            //if (moneda is Euro e)
            //{
            //    return $"Se han debitado {e.Cantidad} Euros ";
            //}
           

        }

        public Moneda this[int index]
        {
            get
            {
                if (index >= 0 && index < monedas.Count)
                {
                    return monedas[index];
                }
                throw new IndexOutOfRangeException("Índice fuera de rango");
            }
        }

        public override int GetHashCode()
        {
            if (monedas.Count == 0)
                return 17;

            int hash = 0;

            foreach (var moneda in monedas)
            {
                hash += moneda.GetHashCode();
            }
            return hash;
        }

        public List<string> ObtenerDatosMonedas()
        {
            List<string> datosMonedas = new List<string>();

            foreach (var moneda in monedas)
            {
                string info = $"{moneda.GetType().Name}- Cantidad :{moneda.Cantidad}";

                datosMonedas.Add(info);
            }
            return datosMonedas;
        }






    }
}
