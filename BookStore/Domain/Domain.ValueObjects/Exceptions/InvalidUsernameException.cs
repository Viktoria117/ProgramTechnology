namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidUsernameException()
    : DomainException(
        "Username length must be between 2 and 50 characters.");