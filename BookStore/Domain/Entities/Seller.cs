using Domain.ValueObjects;

namespace Domain.Entities;

public class Seller
{
    public Guid Id { get; }

    public Username Username { get; private set; }

    public Email Email { get; private set; }

    public Seller(
        Guid id,
        Username username,
        Email email)
    {
        Id = id;
        Username = username;
        Email = email;
    }

    public void ChangeUsername(Username username)
    {
        Username = username;
    }

    public void ChangeEmail(Email email)
    {
        Email = email;
    }
}