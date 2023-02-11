using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Modelos
{
    public class RegistrarVehiculoNoResidente : ARegistrarVehiculo
    {
        public RegistrarVehiculoNoResidente(string pMatricula) 
            : base(pMatricula, Shared.Constantes.TipoVehiculo.NoResidente)
        {

        }
    }
}
