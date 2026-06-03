using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public sealed class QuantityValidator : IValidator<int>
{
    public void Validate(int value)
    {
        if (value <= 0)
            throw new InvalidQuantityException(value);
    }
}