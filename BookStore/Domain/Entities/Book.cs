using Domain.ValueObjects;

namespace Domain.Entities;

public class Book
{
    public Guid Id { get; }

    public Guid SellerId { get; }

    public BookTitle Title { get; private set; }

    public AuthorName Author { get; private set; }

    public Money Price { get; private set; }

    public BookStock Stock { get; private set; }

    public Book(
        Guid id,
        Guid sellerId,
        BookTitle title,
        AuthorName author,
        Money price,
        BookStock stock)
    {
        Id = id;
        SellerId = sellerId;
        Title = title;
        Author = author;
        Price = price;
        Stock = stock;
    }

    public void ChangePrice(Money price)
    {
        Price = price;
    }

    public void IncreaseStock(BookStock amount)
    {
        Stock += amount;
    }

    public void DecreaseStock(BookStock amount)
    {
        Stock -= amount;
    }
}