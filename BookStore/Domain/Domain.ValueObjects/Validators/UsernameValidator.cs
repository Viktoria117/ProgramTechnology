using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public sealed class UsernameValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidUsernameException();

        if (value.Length < 2 || value.Length > 50)
            throw new InvalidUsernameException();
    }
}