using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Modelos
{
    public class RegistrarVehiculoResidente : ARegistrarVehiculo
    {
        public RegistrarVehiculoResidente(string pMatricula) 
            : base(pMatricula, Shared.Constantes.TipoVehiculo.Residente)
        {

        }
    }
}
