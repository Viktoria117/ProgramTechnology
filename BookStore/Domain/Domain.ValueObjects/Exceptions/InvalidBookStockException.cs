namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidBookStockException(int value)
    : DomainException(
        $"Stock cannot be negative. Actual value: {value}");