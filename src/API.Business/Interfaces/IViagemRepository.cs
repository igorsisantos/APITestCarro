using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API.Business.Models;

namespace API.Business.Interfaces
{
    public interface IViagemRepository : IRepository<Viagem>
    {
        Task<Viagem> CalcularViagem(Viagem viagem);
    }
}
