using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Api.Repositories;
public class CarRepository : ICarRepository
{
    private readonly TaxiDbContext _context;
    public CarRepository(TaxiDbContext context)
    {
        _context = context;
    }
    public async Task<Car> Add(Car entity)
    {
        _context.Cars.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Car> Delete(Car entity)
    {
        _context.Cars.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<Car>> GetAllCars()
    {
        var cars = await _context.Cars.AsNoTracking().ToListAsync();
        return cars;
    }

    public async Task<Car> GetCarById(Guid Id)
    {
        var car = await _context.Cars.FirstOrDefaultAsync(u => u.Id == Id);
        return car!;
    }

    public async Task<List<Car>> GetCarByOwnerId(Guid Id)
    {
        var car = await _context.Cars.Where(x => x.UserId == Id).ToListAsync();
        return car;
    }

    public async Task<List<Car>> GetCarByOwnerUsername(string username)
    {
        var car = await _context.Cars.Where(x => x.User!.Username == username).ToListAsync();
        return car;
    }

    public async Task<Car> Update(Car entity)
    {
        _context.Cars.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
