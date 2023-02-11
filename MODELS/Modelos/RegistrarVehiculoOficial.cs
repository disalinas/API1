using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Modelos
{
    public class RegistrarVehiculoOficial : ARegistrarVehiculo
    {
        public RegistrarVehiculoOficial(string pMatricula) 
            : base(pMatricula, Shared.Constantes.TipoVehiculo.Oficial)
        {

        }
    }
}
