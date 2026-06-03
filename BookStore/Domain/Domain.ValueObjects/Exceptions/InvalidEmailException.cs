namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidEmailException(string email)
    : DomainException($"Invalid email: {email}");