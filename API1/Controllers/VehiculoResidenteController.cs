using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Modelos = MODELS.Modelos;

namespace API1.Controllers
{
    public class VehiculoResidenteController : ApiController
    {
        // POST: api/VehiculoResidente
        //public void Post([FromBody]string value)
        public Modelos.Resultado Post(string matricula)
        {
            var nuevoVehiculo = new Modelos.RegistrarVehiculoResidente(matricula);
            Modelos.Resultado resultado = new BLL.Vehiculo.CrearVehiculo().Guardar(nuevoVehiculo);

            return resultado;
        }
    }
}
