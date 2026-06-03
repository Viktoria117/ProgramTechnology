using Domain.Entities;

namespace Domain.Repositories;

public interface ISellerRepository
{
    Task<Seller?> GetByIdAsync(Guid id);

    Task<IEnumerable<Seller>> GetAllAsync();

    Task AddAsync(Seller seller);

    Task UpdateAsync(Seller seller);

    Task DeleteAsync(Guid id);
}