namespace Domain.ValueObjects.Exceptions;

public sealed class OrderCannotBeCancelledException(Guid orderId)
    : DomainException(
        $"Order '{orderId}' cannot be cancelled.");