namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidQuantityException(int value)
    : DomainException(
        $"Quantity must be greater than zero. Actual value: {value}");