namespace Domain.ValueObjects.Exceptions;

public sealed class OrderCannotBeModifiedException(Guid orderId)
    : DomainException(
        $"Order '{orderId}' cannot be modified.");