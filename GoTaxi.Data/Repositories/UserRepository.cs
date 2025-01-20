using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private TaxiDbContext _context { get; set; }
        public UserRepository(TaxiDbContext context)
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
            return user!;
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
            return user;
        }

        public async Task<List<User>> GetAllUserRoles(string role)
        {
            var users = await _context.Users.Where(u => u.Role == role).ToListAsync();
            return users;
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

        public async Task<User> GetPhoneNumber(string phonenumber)
        {
            var number = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == phonenumber);
            return number!;
        }
    }
}
