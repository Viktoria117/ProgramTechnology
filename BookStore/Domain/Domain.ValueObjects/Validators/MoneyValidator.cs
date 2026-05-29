using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class MoneyValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value < 0)
            throw new ArgumentException(
                "Money value cannot be negative.");
    }
}