using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Estancia
{
    public class ExisteSalidaPendiente
    {
        /// <summary>
        /// Comprueba si para un vehiculo dado mediante su matrícula, existe una estancia pendiente de cerrar.
        /// </summary>
        /// <param name="pMatricula"></param>
        /// <returns></returns>
        public bool Comprobar(string pMatricula)
        {
            using (var context = new ParkingContext())
            {
                return context.estancia
                    .Where(e => e.vehiculo.matricula == pMatricula && null == e.fecha_salida)
                    .Any();
            }
        }
    }
}
