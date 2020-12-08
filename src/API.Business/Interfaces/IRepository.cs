using System;
using System.Collections.Generic;
using System.Text;
using API.Business.Models;

namespace API.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {

    }
}
