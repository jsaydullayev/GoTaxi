using GoTaxi.Entities;

namespace GoTaxi.Data.Contracts;
public interface IDestinationRepository : IRepository<Destination>
{
    Task<List<Destination>> GetAllDestination();
    Task<List<Destination>> GetFromWhere(string fromWhere);
    Task<List<Destination>> GetToWhere(string toWhere);
}
