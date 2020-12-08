using System;
using System.Collections.Generic;
using System.Text;

namespace API.Business.Models
{
    public class Viagem : Entity
    {
        public decimal VelocidadeMedia { get; set; }

        public decimal TempoGastoHora { get; set; }

        public decimal DistanciaPercorridaKm { get; set; }

        public decimal QtdLitroViagem { get; set; }

        public decimal AutonomiaKmL { get; set; }
    }
}
