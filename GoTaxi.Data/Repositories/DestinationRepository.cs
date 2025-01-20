using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql.Replication;

namespace GoTaxi.Api.Repositories;
public class DestinationRepository : IDestinationRepository
{
    private readonly TaxiDbContext _context;
    public DestinationRepository(TaxiDbContext context)
    {
        _context = context;
    }
    public async Task<Destination> Add(Destination entity)
    {
        _context.Destinations.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Destination> Delete(Destination entity)
    {
        _context.Destinations.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<Destination>> GetAllDestination()
    {
        var destinations = await _context.Destinations.AsNoTracking().ToListAsync();
        return destinations;
    }

    public async Task<List<Destination>> GetFromWhere(string fromWhere)
    {
        var getFrom = await _context.Destinations.Where(u => u.FromWhere == fromWhere).ToListAsync();
        return getFrom;
    }

    public async Task<List<Destination>> GetToWhere(string toWhere)
    {
        var getToWhere = await _context.Destinations.Where(u => u.ToWhere == toWhere).ToListAsync();
        return getToWhere;
    }

    public async Task<Destination> Update(Destination entity)
    {
        _context.Destinations.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
