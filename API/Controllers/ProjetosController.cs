using API.Models;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProjetosController : ApiController
    {
        private readonly ProjetoRepositorio _projetoRepositorio;
        public ProjetosController() { _projetoRepositorio = new ProjetoRepositorio(); }
       [HttpGet] public IEnumerable<Projeto> Get()
        {
            return _projetoRepositorio.GetAll(); 
        }

        // GET: api/Projetos/5[
       [HttpGet] public Projeto GetProjeto(int id)
        {
            return _projetoRepositorio.GetById(id);
        }

        // POST: api/Projetos
        [HttpPost]public void Post([FromBody]Projeto p)
        {
        }

        // PUT: api/Projetos/5
        [HttpPut] public int Put(int id, [FromBody]Projeto p)
        {
            return _projetoRepositorio.Update(p);
        }

        // DELETE: api/Projetos/5
        [HttpDelete] public int Delete(int id)
        {
            return _projetoRepositorio.Delete(id);
        }
    }
}
