using RecuPOO2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Datos
{
    public interface IArchivo
    {
        List<Moneda> GetMonedas();

        void GuardarMonedas(List<Moneda> lista);



    }
}
