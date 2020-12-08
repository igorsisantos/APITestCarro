using API.Business.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API.Business.Interfaces;

namespace API.Data.Repository
{
    public class ViagemRepository : Repository<Viagem>, IViagemRepository
    {
        public async Task<Viagem> CalcularViagem(Viagem viagem)
        {
            viagem.AutonomiaKmL = viagem.AutonomiaKmL;

            viagem.VelocidadeMedia = viagem.VelocidadeMedia;

            viagem.QtdLitroViagem = viagem.TempoGastoHora;

            viagem.DistanciaPercorridaKm = viagem.TempoGastoHora * viagem.VelocidadeMedia;

            viagem.QtdLitroViagem = viagem.DistanciaPercorridaKm / viagem.AutonomiaKmL;

            return viagem;
        }
    }
}
