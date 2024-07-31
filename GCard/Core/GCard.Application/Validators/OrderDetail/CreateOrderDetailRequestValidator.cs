using FluentValidation;
using GCard.Application.Features.Commands.Definitions.OrderDetail.Create;
using GCard.Application.Validators.Order;

namespace GCard.Application.Validators.OrderDetail
{
    public class CreateOrderDetailRequestValidator : AbstractValidator<CreateOrderDetailRequest>
    {
        public CreateOrderDetailRequestValidator()
        {
            RuleForEach(x => x.OrderDetails)
                .SetValidator(new CreateOrderDetailVMValidator());

            RuleFor(x => x.Order)
                .SetValidator(new CreateOrderVMRequestValidator());
        }
    }
}
