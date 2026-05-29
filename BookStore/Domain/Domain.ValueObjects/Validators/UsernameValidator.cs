using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class UsernameValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Username cannot be empty.");

        if (value.Length < 2 || value.Length > 50)
            throw new ArgumentException(
                "Username length must be between 2 and 50 characters.");
    }
}