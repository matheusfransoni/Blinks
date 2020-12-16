using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Blinks.Dominio;
using Blinks.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Bliks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly PlanilhaContexto _contexto;
        public ValuesController(PlanilhaContexto context)
        {
            _contexto = context;
        }

        [HttpGet("{dataInicio}/{dataFim}")]
        public ActionResult Get(string dataInicio, string dataFim)
        {
            dataInicio = dataInicio.Replace(" ", "/");
            dataFim = dataFim.Replace(" ", "/");
            var listPllanilha = _contexto.Planilhas
                .Where(p => p.date.Date >= Convert.ToDateTime(dataInicio) && p.date.Date <= Convert.ToDateTime(dataFim))
                .ToList();
            return Ok(listPllanilha);
        }

        [HttpGet]
        public ActionResult GetDoc()
        {


            using (var client = new WebClient())
            {

                client.DownloadFile("https://drive.google.com/file/d/1ZYTzbCdP2Y1Ho713wkN1kWdj1aOKWXkT/view?usp=sharing", "database.xlsx");

                return Ok("Arquivo baixado com sucesso");
            }
        }

        [HttpPost]
        public ActionResult Post(Planilha planilha)
        {

            try
            {
                
                var ObjPlanilha = new Planilha { };

                ObjPlanilha = planilha;

                _contexto.Planilhas.Add(ObjPlanilha);
                _contexto.SaveChanges();

                return Ok("Adicionado com sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

    }
}