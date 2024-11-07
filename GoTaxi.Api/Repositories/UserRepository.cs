using GoTaxi.Api.Contracts;
using GoTaxi.Data.Constants;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private GoTaxiDbContext _context { get; set; }
        public UserRepository(GoTaxiDbContext context)
        {
            _context = context; 
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.AsNoTracking().ToListAsync();
            return users;
        }

        public async Task<User> GetUserById(Guid Id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == Id);
            if (user is null)
            {
                throw new NotImplementedException("User not found");
            }
            return user;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
            if (user is null)
            {
                throw new NotImplementedException("Username not found");
            }
            return user;
        }

        public async Task<User> GetAllCLients(Guid id)
        {
            var users = await _context.Users.SingleOrDefaultAsync(u => u.Id == id && u.Role == Role.ClientRole);
            if (users is null)
            {
                throw new NotImplementedException("Client not found");
            }
            return users;
        }

        public async Task<User> GetAllOwners(Guid id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == id && u.Role == Role.OwnerRole);
            if (user is null)
            {
                throw new NotImplementedException("Owner not found");
            }
            return user;
        }

        public async Task<User> Update(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> Delete(User entity)
        {
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> Add(User entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
