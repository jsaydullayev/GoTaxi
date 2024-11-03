using GoTaxi.Entities;
using GoTaxi.GoTaxiDbContext;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private TaxiDbContext _context {  get; set; }
        public UserRepository(TaxiDbContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.AsNoTracking().ToListAsync();
            return users;
        }

        public async Task<User> GetUserById(Guid Id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == Id);
            if(user is null)
            {
                throw new NotImplementedException("User not found");
            }
            return user;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
            if(user is null)
            {
                throw new NotImplementedException("Username not found");
            }
            return user;
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
