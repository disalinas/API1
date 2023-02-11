using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Modelos
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string CodigoTipoVehiculo { get; set; }
        public decimal PrecioMinuto { get; set; }
        public List<Estancia> Estancias { get; set; }
    }
}
