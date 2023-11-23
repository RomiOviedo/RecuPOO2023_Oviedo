using RecuPOO2023.Entidades;
using System.Xml.Serialization;

namespace RecuPOO2023.Datos
{
    public class ManejadorArchivoXml : IArchivo
    {
        private string _archivo = "Billetera.xml";
        private string _ruta = Environment.CurrentDirectory;
        private string _rutaArchivo;


        public ManejadorArchivoXml()
        {
            _rutaArchivo = Path.Combine(_ruta, _archivo);

        }

        public List<Moneda> GetMonedas()            //desserializacion
        {
            List<Moneda> monedas = new List<Moneda>();
            try
            {
                if (File.Exists(_rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));


                    using (StreamReader reader = new StreamReader(_rutaArchivo))
                    {
                        monedas = (List<Moneda>)xmlSerializer.Deserialize(reader);
                    }
                }
                else
                {
                    Console.WriteLine("El archivo XML no existe. No se pueden cargar datos de monedas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los datos de las monedas: " + ex.Message);
            }
            return monedas;
        }




        public void GuardarMonedas(List<Moneda> lista)  // serializacion
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));

            using (StreamWriter writer = new StreamWriter(_rutaArchivo, true))  // al poner true, le digo q agregue texto nuevo, no sobreescriba
            {
                xmlSerializer.Serialize(writer, lista);
            }

        }













    }
}
