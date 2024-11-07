using GoTaxi.Entities;

namespace GoTaxi.Api.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetAllCLients(Guid id);
        Task<User> GetAllOwners(Guid id);
        Task<User> GetUserById(Guid Id);
        Task<User?> GetUserByUsername(string username);

    }
}
