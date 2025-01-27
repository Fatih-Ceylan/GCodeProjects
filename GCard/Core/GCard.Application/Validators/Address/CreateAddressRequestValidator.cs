﻿using FluentValidation;
using GCard.Application.Features.Commands.Definitions.Address.Create;

namespace GCard.Application.Validators.Address
{
    public class CreateAddressRequestValidator : AbstractValidator<CreateAddressRequest>
    {
        public CreateAddressRequestValidator()
        {
            RuleFor(c => c.AddressLine)
              .NotEmpty()
              .WithMessage("AddressLine cannot be empty.")
              .MaximumLength(250)
              .MinimumLength(1)
              .WithMessage("AddressLine length must be between 1 and 250.");  
        }
    }
}
