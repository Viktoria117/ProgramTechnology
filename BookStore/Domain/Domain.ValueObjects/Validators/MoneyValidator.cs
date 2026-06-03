using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public sealed class MoneyValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value < 0)
            throw new InvalidMoneyException(value);
    }
}