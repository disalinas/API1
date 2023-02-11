using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Estancia
{
    public class ExisteEntrada
    {
        /// <summary>
        /// Comprueba si el vehículo indicado mediante su matrícula ya dispone de una estancia abierta.
        /// </summary>
        /// <param name="pMatricula"></param>
        /// <returns></returns>
        public bool Comprobar(string pMatricula)
        {
            using (var context = new ParkingContext())
            {
                return context.estancia
                    .Where(e => e.vehiculo.matricula == pMatricula && null == e.fecha_entrada)
                    .Any();
            }
        }
    }
}
