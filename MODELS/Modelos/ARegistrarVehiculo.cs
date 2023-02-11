using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Modelos
{
    public abstract class ARegistrarVehiculo
    {
        public string Matricula { get; set; }
        public string CodigoTipoVehiculo { get; set; }

        public ARegistrarVehiculo(string pMatricula, string pTipoVehiculo)
        {
            this.Matricula = pMatricula;
            this.CodigoTipoVehiculo = pTipoVehiculo;
        }
    }
}
