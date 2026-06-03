using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public sealed class BookStockValidator : IValidator<int>
{
    public void Validate(int value)
    {
        if (value < 0)
            throw new InvalidBookStockException(value);
    }
}