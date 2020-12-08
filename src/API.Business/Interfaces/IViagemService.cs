using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API.Business.Models;

namespace API.Business.Interfaces
{
    public interface IViagemService : IDisposable
    {
        Task<Viagem> CalcularViagem(Viagem viagem);
    }
}
