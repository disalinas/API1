using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;
using DAL.Entities;

namespace DAL.Estancia
{
    public class RegistrarEntrada
    {
        /// <summary>
        /// Añade una nueva estancia al vehículo indicado mediante su matrícula.
        /// Condiciones: el vehículo existe y no tiene ninguna otra entrada pendiente de salida en su lista de estancias.
        /// </summary>
        /// <param name="pVehiculo"></param>
        /// <returns></returns>
        public MODELS.Modelos.Resultado Guardar(Modelos.RegistrarFecha pEntrada)
        {
            MODELS.Modelos.Resultado resultado = new MODELS.Modelos.Resultado();

            try
            {
                resultado.Estado = false;

                using (var context = new ParkingContext())
                {
                    var vehiculo = context.vehiculo.Where(v => v.matricula == pEntrada.Matricula).First();                    
                    vehiculo.estancia.Add(new estancia()
                    {
                        fecha_entrada = pEntrada.Fecha
                    });

                    context.SaveChanges();
                    resultado.Estado = true;
                }

                return resultado;
            } 
            catch(Exception ex)
            {
                resultado.mensaje = ex.ToString();
                resultado.Estado = false;

                return resultado;
            }
        }

        
    }
}
