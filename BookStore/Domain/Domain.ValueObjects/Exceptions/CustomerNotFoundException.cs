namespace Domain.ValueObjects.Exceptions;

public sealed class CustomerNotFoundException(Guid customerId)
    : DomainException(
        $"Customer '{customerId}' was not found.");