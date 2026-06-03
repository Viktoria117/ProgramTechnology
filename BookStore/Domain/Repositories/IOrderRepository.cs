using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(Guid id);

    Task<IEnumerable<Order>> GetAllAsync();

    Task<IEnumerable<Order>> GetByCustomerIdAsync(Guid customerId);

    Task AddAsync(Order order);

    Task UpdateAsync(Order order);

    Task DeleteAsync(Guid id);
}