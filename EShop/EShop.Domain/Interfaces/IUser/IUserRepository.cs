using EShop.Domain.Entities;

namespace EShop.Domain.Interfaces.IUser
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User?> GetByIdAsync(Guid Id);
    }
}
