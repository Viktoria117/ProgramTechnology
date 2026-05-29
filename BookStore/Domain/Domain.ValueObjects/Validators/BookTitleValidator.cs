using Domain.ValueObjects.Base;

namespace Domain.ValueObjects.Validators;

public sealed class BookTitleValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Book title cannot be empty.");

        if (value.Length > 200)
            throw new ArgumentException(
                "Book title cannot exceed 200 characters.");
    }
}