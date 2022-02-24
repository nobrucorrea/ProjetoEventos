using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEentos.API.Model;


namespace ProEentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {      

        
        public EventoController()
        {
            
        }
    
        [HttpGet]
        public Evento Get()
        {
            return new Evento(){

                    EventoId = 1,
                    Tema = "Angular 11 ",
                    Local ="Petropolis",
                    DataEvento = "12-12-2022",
                    QtdPessoas = 1


            };
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }
    }
}
