namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidMoneyException(decimal value)
    : DomainException(
        $"Money cannot be negative. Actual value: {value}");