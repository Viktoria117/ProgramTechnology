namespace Domain.ValueObjects.Exceptions;

public sealed class OrderAlreadyCancelledException(Guid orderId)
    : DomainException(
        $"Order '{orderId}' is already cancelled.");