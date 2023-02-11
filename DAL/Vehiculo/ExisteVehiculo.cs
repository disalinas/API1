using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Vehiculo
{
    public class ExisteVehiculo
    {
        public bool Comprobar(string pMatricula)
        {
            using(var context = new ParkingContext())
            {
                return context.vehiculo
                    .Where(v => v.matricula == pMatricula)
                    .Any();
            }
        }
    }
}
