using IATCINDIA.DOMAIN.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IATCINDIA.API.Controller
{
    [ApiController]
    [Route("[controller]")]
    public abstract class MyMDBController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IEFCoreRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyMDBController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();


        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            if (await repository.Get(id) == null)
            {
                return NotFound();
            }
            return await repository.Get(id);
        }






    }
}