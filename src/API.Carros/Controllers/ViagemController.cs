using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Interfaces;
using API.Business.Models;
using API.Carros.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Carros.Controllers
{
    [Route("api/viagem")]
    public class ViagemController : MainController
    {
        private readonly IViagemRepository _viagemRepository;
        private readonly IViagemService _viagemService;
        private readonly IMapper _mapper;

        public ViagemController(INotificador notificador,
            IViagemRepository viagemRepository,
            IViagemService viagemService,
            IMapper mapper) : base(notificador)
        {
            _viagemRepository = viagemRepository;
            _viagemService = viagemService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<ViagemViewModel>> CalcularViagem(ViagemViewModel viagem)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var viagemCalculada = await _viagemService.CalcularViagem(_mapper.Map<Viagem>(viagem));

            return CustomResponse(viagemCalculada);
        }
    }
}