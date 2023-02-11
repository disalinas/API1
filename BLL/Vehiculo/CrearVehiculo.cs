using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;

namespace BLL.Vehiculo
{
    public class CrearVehiculo
    {
        public Modelos.Resultado Guardar(Modelos.ARegistrarVehiculo pVehiculo)
        {
            Modelos.Resultado resultado = new Modelos.Resultado();

            if (!new DAL.Vehiculo.ExisteVehiculo().Comprobar(pVehiculo.Matricula))
            {
                resultado = new DAL.Vehiculo.CrearVehiculo().Guardar(pVehiculo);
            }
            else
            {
                resultado.mensaje = string.Format("El vehículo con matrícula {0} ya exist.",
                    pVehiculo.Matricula);
                resultado.Estado = false;
            }

            return resultado;
        }
    }
}
