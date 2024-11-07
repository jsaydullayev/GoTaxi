using GoTaxi.Entities;

namespace GoTaxi.Api.Contracts;
public interface ICarRepository : IRepository<Cars>
{
    Task<List<Cars>> GetAllCars();
    Task<Cars> GetCarById(Cars cars);
    Task<Cars> GetCarsOwner(Cars cars);
}
