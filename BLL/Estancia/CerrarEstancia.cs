using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;

namespace BLL.Estancia
{
    public class CerrarEstancia
    {
        /// <summary>
        /// Registra la salida del vehículo indicado mediante su matrícula.
        /// </summary>
        /// <param name="pSalida"></param>
        /// <returns></returns>
        public Modelos.Resultado Guardar(Modelos.RegistrarFecha pSalida)
        {
            var resultado = new Modelos.Resultado();

            if (new DAL.Vehiculo.ExisteVehiculo().Comprobar(pSalida.Matricula))
            {
                if (new DAL.Estancia.ExisteSalidaPendiente().Comprobar(pSalida.Matricula))
                {
                    resultado = new DAL.Estancia.RegistrarSalida().Guardar(pSalida);
                }
                else
                {
                    resultado.mensaje = string.Format("El vehículo con matrícula {0}, no tiene una estancia pendiente de cerrar.",
                        pSalida.Matricula);
                    resultado.Estado = false;
                }
            }
            else
            {
                resultado.mensaje = string.Format("La matrícula {0} introducida no existe. Cree primero el vehículo.",
                    pSalida.Matricula);
                resultado.Estado = false;
            }

            return resultado;
        }
    }
}
