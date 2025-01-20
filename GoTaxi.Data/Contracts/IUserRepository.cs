using GoTaxi.Entities;

namespace GoTaxi.Data.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<List<User>> GetAllUserRoles(string role);
        Task<User> GetUserById(Guid id);
        Task<User?> GetUserByUsername(string username);

    }
}
