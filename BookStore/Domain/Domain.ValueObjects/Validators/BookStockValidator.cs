using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class BookStockValidator : IValidator<int>
{
    public void Validate(int value)
    {
        if (value < 0)
            throw new ArgumentException(
                "Stock cannot be negative.");
    }
}