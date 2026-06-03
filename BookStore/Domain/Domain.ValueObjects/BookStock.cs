using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class BookStock : ValueObject<int>
{
    public BookStock(int value)
        : base(new BookStockValidator(), value)
    {
    }

    public static BookStock operator +(BookStock left, BookStock right)
        => new(left.Value + right.Value);

    public static BookStock operator -(BookStock left, BookStock right)
        => new(left.Value - right.Value);

    public static bool operator >(BookStock left, BookStock right)
        => left.Value > right.Value;

    public static bool operator <(BookStock left, BookStock right)
        => left.Value < right.Value;

    public static bool operator >=(BookStock left, BookStock right)
        => left.Value >= right.Value;

    public static bool operator <=(BookStock left, BookStock right)
        => left.Value <= right.Value;

    public static implicit operator int(BookStock stock)
        => stock.Value;
}