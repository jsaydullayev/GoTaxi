using GoTaxi.Entities;

namespace GoTaxi.Api.Contracts;
public interface ICarInfoRepository : IRepository<CarInfo>
{
    Task<List<CarInfo>> GetSeatCounts();
}
