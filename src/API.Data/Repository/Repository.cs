using System;
using System.Collections.Generic;
using System.Text;
using API.Business.Interfaces;
using API.Business.Models;

namespace API.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        public void Dispose()
        {
            //dispose dbcontext
        }
    }
}
