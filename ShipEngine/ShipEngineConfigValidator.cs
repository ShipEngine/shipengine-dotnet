using System;

using FluentValidation;

namespace ShipEngine
{

    sealed public class ShipEngineConfigValidator : AbstractValidator<ShipEngineConfig>
    {
        public static readonly Uri DefaultBaseUri = new Uri("https://api.shipengine.com");

        public ShipEngineConfigValidator()
        {
            RuleFor(c => c.ApiKey).NotEmpty();
            RuleFor(c => c.BaseUri).NotEmpty();
        }
    }
}