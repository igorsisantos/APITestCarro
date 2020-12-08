using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API.Business.Interfaces;
using API.Business.Models;
using API.Business.Models.Validations;

namespace API.Business.Services
{
    public class ViagemService : BaseService, IViagemService
    {
        private readonly IViagemRepository _viagemRepository;

        public ViagemService(IViagemRepository viagemRepository,
            INotificador notificador) : base(notificador)
        {
            _viagemRepository = viagemRepository;
        }

        public async Task<Viagem> CalcularViagem(Viagem viagem)
        {
            if (!ExecutarValidacao(new ViagemValidation(), viagem)) return null;

            return await _viagemRepository.CalcularViagem(viagem);
        }

        public void Dispose()
        {
            _viagemRepository?.Dispose();
        }
    }
}
