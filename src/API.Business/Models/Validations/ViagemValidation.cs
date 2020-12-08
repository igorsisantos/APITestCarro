using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace API.Business.Models.Validations
{
    public class ViagemValidation : AbstractValidator<Viagem>
    {
        public ViagemValidation()
        {
            RuleFor(c => c.AutonomiaKmL)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");

            RuleFor(c => c.TempoGastoHora)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");

            RuleFor(c => c.VelocidadeMedia)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
