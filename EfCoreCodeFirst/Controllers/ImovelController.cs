using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreCodeFirst.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreCodeFirst.Controllers
{
    [Route("api/imovel")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private SqlContext _sqlContext { get; set; }
        
        public ImovelController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        public IEnumerable<Imovel> Get()
        {
            var listaImoveis = _sqlContext.Imoveis.ToList();
            return listaImoveis;
        }
        
        [HttpPost]
        public void Post([FromBody]Imovel imovel)
        {
            _sqlContext.Imoveis.Add(imovel);
            _sqlContext.SaveChanges();
        }
        

    }
}
