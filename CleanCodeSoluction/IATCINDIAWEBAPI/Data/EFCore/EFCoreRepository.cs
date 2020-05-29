using IATCINDIAWEBAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IATCINDIAWEBAPI.Data.EFCore
{
    public abstract class EFCoreRepository<TEntity, TContext> : IRepository<TEntity>
         where TEntity : class, IEntity
         where TContext : DbContext
    {
        public readonly TContext context;

        public EFCoreRepository(TContext context)
        {
            this.context = context;
        }

        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetSpValue()
        {
            var blogs = await context.Set<TEntity>()
                    .FromSqlRaw("EXECUTE test")
                    .ToListAsync();

            return blogs;
        }
    }
}
