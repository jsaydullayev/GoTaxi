using GoTaxi.Entities;

namespace GoTaxi.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(Guid Id);
        Task<User?> GetUserByUsername(string username);
        Task UpdateUser(User user);
        Task AddUser(User user);
        Task DeleteUser(User user);
    }
}
