using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class AuthorName : ValueObject<string>
{
    public AuthorName(string value)
        : base(new AuthorNameValidator(), value.Trim())
    {
    }

    public static implicit operator string(AuthorName author)
        => author.Value;
}