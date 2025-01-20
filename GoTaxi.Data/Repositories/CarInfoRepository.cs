using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Api.Repositories;
public class CarInfoRepository : ICarInfoRepository
{
    private readonly TaxiDbContext _context;
    public CarInfoRepository(TaxiDbContext context)
    {
        _context = context;
    }
    public async Task<CarInfo> Add(CarInfo entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<CarInfo> Delete(CarInfo entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<CarInfo>> GetSeatCounts()
    {
        var count = await _context.CarInfos.AsNoTracking().ToListAsync();
        return count;
    }

    public async Task<CarInfo> Update(CarInfo entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
