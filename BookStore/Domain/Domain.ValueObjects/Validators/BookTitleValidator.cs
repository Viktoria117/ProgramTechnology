using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public sealed class BookTitleValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidBookTitleException();

        if (value.Length > 200)
            throw new InvalidBookTitleException();
    }
}