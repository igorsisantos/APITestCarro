using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Carros.ViewModels
{
    public class ViagemViewModel
    {
        public decimal VelocidadeMedia { get; set; }

        public decimal TempoGastoHora { get; set; }

        public decimal DistanciaPercorridaKm { get; set; }

        public decimal QtdLitroViagem { get; set; }

        public decimal AutonomiaKmL { get; set; }
    }
}
