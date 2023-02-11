using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos = MODELS.Modelos;
using DAL.Entities;

namespace DAL.Vehiculo
{
    public class CrearVehiculo
    {
        public Modelos.Resultado Guardar(Modelos.ARegistrarVehiculo pVehiculo)
        {
            Modelos.Resultado resultado = new Modelos.Resultado();

            try
            {
                using (var context = new ParkingContext())
                {
                    var aux = context.tipo_vehiculo.ToList();
                    context.vehiculo.Add(new vehiculo()
                    {
                        matricula = pVehiculo.Matricula,
                        tipo_vehiculo = context.tipo_vehiculo
                            .Where(tv => tv.codigo == pVehiculo.CodigoTipoVehiculo)
                            .First()
                    });
                    context.SaveChanges();
                    resultado.Estado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                resultado.Estado = false;
                resultado.mensaje = ex.ToString();

                return resultado;
            }
        }
    }
}
