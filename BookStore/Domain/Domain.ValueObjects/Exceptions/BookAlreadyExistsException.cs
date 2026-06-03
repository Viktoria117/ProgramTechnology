namespace Domain.ValueObjects.Exceptions;

public sealed class BookAlreadyExistsException(string title)
    : DomainException(
        $"Book '{title}' already exists.");