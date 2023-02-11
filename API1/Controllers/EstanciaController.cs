using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Modelos = MODELS.Modelos;

namespace API1.Controllers
{
    public class EstanciaController : ApiController
    {
        public Modelos.Resultado RegistrarEntrada(string matricula)
        {
            Modelos.Resultado resultado = new BLL.Estancia.AbrirEstancia().Guardar(new Modelos.RegistrarFecha()
            {
                Matricula = matricula,
                Fecha = DateTime.Now
            });

            return resultado;
        }

        public Modelos.Resultado RegistrarSalida(string matricula)
        {
            Modelos.Resultado resultado = new BLL.Estancia.CerrarEstancia().Guardar(new Modelos.RegistrarFecha()
            {
                Matricula = matricula,
                Fecha = DateTime.Now
            });

            return resultado;
        }
    }
}
