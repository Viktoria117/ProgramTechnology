namespace Domain.ValueObjects.Exceptions;

public sealed class InvalidBookTitleException()
    : DomainException(
        "Book title cannot be empty.");