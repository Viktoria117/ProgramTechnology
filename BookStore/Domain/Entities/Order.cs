using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Order
{
    private readonly List<OrderItem> _items = new();

    public Guid Id { get; }

    public Guid CustomerId { get; }

    public DateTime OrderDate { get; }

    public OrderStatus Status { get; private set; }

    public IReadOnlyCollection<OrderItem> Items =>
        _items.AsReadOnly();

    public Order(
        Guid id,
        Guid customerId)
    {
        Id = id;
        CustomerId = customerId;
        OrderDate = DateTime.UtcNow;
        Status = OrderStatus.Pending;
    }

    public void AddItem(OrderItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Guid itemId)
    {
        var item = _items.FirstOrDefault(i => i.Id == itemId);

        if (item != null)
            _items.Remove(item);
    }

    public void ChangeStatus(OrderStatus status)
    {
        Status = status;
    }
}