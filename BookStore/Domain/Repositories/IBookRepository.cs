using Domain.Entities;

namespace Domain.Repositories;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(Guid id);

    Task<IEnumerable<Book>> GetAllAsync();

    Task AddAsync(Book book);

    Task UpdateAsync(Book book);

    Task DeleteAsync(Guid id);
}