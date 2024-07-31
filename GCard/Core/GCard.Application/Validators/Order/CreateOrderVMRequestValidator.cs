using FluentValidation;
using GCard.Application.VMs;

namespace GCard.Application.Validators.Order
{
    public class CreateOrderVMRequestValidator : AbstractValidator<CreateOrderVM>
    {
        public CreateOrderVMRequestValidator()
        { 
        }
    }
}
