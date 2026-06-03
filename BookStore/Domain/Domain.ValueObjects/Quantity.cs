using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class Quantity : ValueObject<int>
{
    public Quantity(int value)
        : base(new QuantityValidator(), value)
    {
    }

    public static Quantity operator +(Quantity left, Quantity right)
        => new(left.Value + right.Value);

    public static Quantity operator -(Quantity left, Quantity right)
        => new(left.Value - right.Value);

    public static bool operator >(Quantity left, Quantity right)
        => left.Value > right.Value;

    public static bool operator <(Quantity left, Quantity right)
        => left.Value < right.Value;

    public static bool operator >=(Quantity left, Quantity right)
        => left.Value >= right.Value;

    public static bool operator <=(Quantity left, Quantity right)
        => left.Value <= right.Value;

    public static implicit operator int(Quantity quantity)
        => quantity.Value;
}