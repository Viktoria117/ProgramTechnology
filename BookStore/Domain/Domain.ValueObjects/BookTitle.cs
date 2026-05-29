using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public sealed class BookTitle : ValueObject<string>
{
    public BookTitle(string value)
        : base(new BookTitleValidator(), value.Trim())
    {
    }

    public static implicit operator string(BookTitle title)
        => title.Value;
}