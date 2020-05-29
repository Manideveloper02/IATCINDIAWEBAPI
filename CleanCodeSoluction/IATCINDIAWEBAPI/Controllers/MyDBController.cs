using IATCINDIAWEBAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IATCINDIAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyDBController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyDBController(TRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var member = await repository.Get(id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                return member;
            }

        }

        [HttpGet("get")]
        public async Task<List<TEntity>> GetSpvalue()
        {
            var member = await repository.GetSpValue();
            return member;

        }

    }
}