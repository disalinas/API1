using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;
using DAL.Entities;

namespace DAL.Estancia
{
    public class RegistrarSalida
    {
        /// <summary>
        /// Añade la fecha de salida a la única estancia sin cerrar del vehículo indicado mediante su matrícula.
        /// Condiciones: el vehículo existe y tine sólo una estancia sin cerrar.
        /// </summary>
        /// <param name="pVehiculo"></param>
        /// <returns></returns>
        public MODELS.Modelos.Resultado Guardar(Modelos.RegistrarFecha pSalida)
        {
            MODELS.Modelos.Resultado resultado = new MODELS.Modelos.Resultado();

            try
            {
                resultado.Estado = false;

                using (var context = new ParkingContext())
                {
                    var vehiculo = context.vehiculo
                        .Where(v => v.matricula == pSalida.Matricula)
                        .First();
                    var estancia = vehiculo.estancia
                            .Where(e => null == e.fecha_salida)
                            .First();
                    estancia.fecha_salida = pSalida.Fecha;

                    context.SaveChanges();
                    resultado.Estado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                resultado.mensaje = ex.ToString();
                resultado.Estado = false;
                return resultado;
            }
        }
    }
}
