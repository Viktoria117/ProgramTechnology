using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class Username : ValueObject<string>
{
    public Username(string value)
        : base(new UsernameValidator(), value.Trim())
    {
    }

    public static implicit operator string(Username username)
        => username.Value;
}