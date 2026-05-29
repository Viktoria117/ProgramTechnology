namespace Domain.ValueObjects.Exceptions;

public sealed class BookOutOfStockException(string title)
    : DomainException(
        $"Book '{title}' is out of stock.");