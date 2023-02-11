using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;

namespace BLL.Estancia
{
    public class AbrirEstancia
    {
        /// <summary>
        /// Abre una nueva estancia para un vehículo mediante su matrícula
        /// </summary>
        /// <param name="pEntrada"></param>
        /// <returns></returns>
        public Modelos.Resultado Guardar(Modelos.RegistrarFecha pEntrada)
        {
            var resultado = new Modelos.Resultado();

            if (new DAL.Vehiculo.ExisteVehiculo().Comprobar(pEntrada.Matricula))
            { 
                if (!new DAL.Estancia.ExisteSalidaPendiente().Comprobar(pEntrada.Matricula))
                {
                    resultado = new DAL.Estancia.RegistrarEntrada().Guardar(pEntrada);
                }
                else
                {
                    resultado.mensaje = string.Format("El vehículo con matrícula {0}, ya tiene una estancia pendiente de cerrar.",
                        pEntrada.Matricula);
                    resultado.Estado = false;
                }
            }
            else
            {
                resultado.mensaje = string.Format("La matrícula {0} introducida no existe. Cree primero el vehículo.",
                    pEntrada.Matricula);
                resultado.Estado = false;
            }

            return resultado;
        }
    }
}
