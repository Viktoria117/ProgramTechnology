using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class Email : ValueObject<string>
{
    public Email(string value)
        : base(
            new EmailValidator(),
            value.Trim().ToLowerInvariant())
    {
    }

    public static implicit operator string(Email email)
        => email.Value;
}