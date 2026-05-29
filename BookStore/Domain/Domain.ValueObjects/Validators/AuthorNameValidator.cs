using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class AuthorNameValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Author name cannot be empty.");

        if (value.Length > 100)
            throw new ArgumentException(
                "Author name cannot exceed 100 characters.");
    }
}