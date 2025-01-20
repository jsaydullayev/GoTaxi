using GoTaxi.Entities;

namespace GoTaxi.Data.Contracts;
public interface ICarInfoRepository : IRepository<CarInfo>
{
    Task<List<CarInfo>> GetSeatCounts();
}
