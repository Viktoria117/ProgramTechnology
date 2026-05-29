using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class QuantityValidator : IValidator<int>
{
    public void Validate(int value)
    {
        if (value <= 0)
            throw new ArgumentException(
                "Quantity must be greater than zero.");
    }
}