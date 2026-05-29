using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class Money : ValueObject<decimal>
{
    public Money(decimal value)
        : base(new MoneyValidator(), value)
    {
    }

    public static Money operator +(Money left, Money right)
        => new(left.Value + right.Value);

    public static Money operator -(Money left, Money right)
        => new(left.Value - right.Value);

    public static bool operator >(Money left, Money right)
        => left.Value > right.Value;

    public static bool operator <(Money left, Money right)
        => left.Value < right.Value;

    public static bool operator >=(Money left, Money right)
        => left.Value >= right.Value;

    public static bool operator <=(Money left, Money right)
        => left.Value <= right.Value;
}