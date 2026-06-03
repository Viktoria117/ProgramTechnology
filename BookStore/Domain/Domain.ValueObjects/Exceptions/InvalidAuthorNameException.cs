namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidAuthorNameException()
    : DomainException(
        "Author name cannot be empty.");