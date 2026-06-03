using Domain.ValueObjects;

namespace Domain.Entities;

public class OrderItem
{
    public Guid Id { get; }

    public Guid BookId { get; }

    public Quantity Quantity { get; private set; }

    public Money PriceAtPurchase { get; private set; }

    public OrderItem(
        Guid id,
        Guid bookId,
        Quantity quantity,
        Money priceAtPurchase)
    {
        Id = id;
        BookId = bookId;
        Quantity = quantity;
        PriceAtPurchase = priceAtPurchase;
    }

    public void ChangeQuantity(Quantity quantity)
    {
        Quantity = quantity;
    }
}