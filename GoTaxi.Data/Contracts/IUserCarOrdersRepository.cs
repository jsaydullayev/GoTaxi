using GoTaxi.Entities;

namespace GoTaxi.Data.Contracts;
public interface IUserCarOrdersRepository : IRepository<UserCarOrders>
{
    Task<List<UserCarOrders>> GetAllOrders();
    Task<UserCarOrders> GetById(int id);
    Task<List<UserCarOrders>> GetByFromLocation(string fromLocation);
    Task<List<UserCarOrders>> GetByToLocation(string toLocation);
    Task<List<UserCarOrders>> GetAllPrice(string price);
}
