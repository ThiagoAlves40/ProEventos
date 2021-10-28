using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {

        }

        [HttpGet]
        public List<Evento> Get()
        {
            return new List<Evento>()
            {   
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Encontro Turma",
                    Local = "Rincão",
                    QtdPessoas = 20,
                    Lote = "Primeiro Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                },

                new Evento()
                {
                    EventoId = 2,
                    Tema = "Segundo Encontro Turma",
                    Local = "São Paulo",
                    QtdPessoas = 20,
                    Lote = "Segundo Lote",
                    DataEvento = DateTime.Now.AddDays(10).ToString()
                }
            };
        }

        [HttpPost]
        public string Post()
        {
            return "metodo post";
        }

        [HttpDelete ("{id}")]
        public string Delete(int id)
        {
            return $"metodo delete com o id = {id}";
        }

    }
}
