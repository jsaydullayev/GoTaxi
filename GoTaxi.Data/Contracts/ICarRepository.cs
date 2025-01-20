using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace GoTaxi.Data.Contracts;
public interface ICarRepository : IRepository<Car>
{
    Task<List<Car>> GetAllCars();
    Task<Car> GetCarById(Guid Id);
    Task<List<Car>> GetCarByOwnerId(Guid Id);
    Task<List<Car>> GetCarByOwnerUsername(string username);
}
