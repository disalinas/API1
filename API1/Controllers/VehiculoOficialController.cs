using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Modelos = MODELS.Modelos;

namespace API1.Controllers
{
    public class VehiculoOficialController : ApiController
    {
        // GET: api/VehiculoOficial
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VehiculoOficial/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VehiculoOficial
        //public void Post([FromBody]string value)
        public Modelos.Resultado Post(string matricula)
        {
            var nuevoVehiculo = new Modelos.RegistrarVehiculoOficial(matricula);
            Modelos.Resultado resultado = new BLL.Vehiculo.CrearVehiculo().Guardar(nuevoVehiculo);

            return resultado;
        }

        // PUT: api/VehiculoOficial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VehiculoOficial/5
        public void Delete(int id)
        {
        }
    }
}
