using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Data.Repositories;
public class UserCarOrderRepository : IUserCarOrdersRepository
{
    private readonly TaxiDbContext _context;
    public UserCarOrderRepository(TaxiDbContext context)
    {
        _context = context;
    }
    public async Task<UserCarOrders> Add(UserCarOrders entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<UserCarOrders> Delete(UserCarOrders entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<UserCarOrders>> GetAllOrders()
    {
        var orders = await _context.UserCarOrders.AsNoTracking().ToListAsync();
        return orders;
    }

    public async Task<List<UserCarOrders>> GetAllPrice(string price)
    {
        var order = await _context.UserCarOrders.Where(u => u.Price == price).ToListAsync();
        return order;
    }

    public async Task<List<UserCarOrders>> GetByFromLocation(string fromLocation)
    {
        var order = await _context.UserCarOrders.Where(u => u.FromLocation == fromLocation).ToListAsync();
        return order!;
    }

    public async Task<UserCarOrders> GetById(int id)
    {
        var order = await _context.UserCarOrders.FirstOrDefaultAsync(u => u.Id == id);
        return order!;
    }

    public async Task<List<UserCarOrders>> GetByToLocation(string toLocation)
    {
        var order = await _context.UserCarOrders.Where(u => u.ToLocation == toLocation).ToListAsync();
        return order!;
    }

    public async Task<UserCarOrders> Update(UserCarOrders entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
