using GoTaxi.Entities;

namespace GoTaxi.Data.Contracts;
public interface IPaymentRepository : IRepository<Payment>
{
    Task<List<Payment>> GetAllPayments();
    Task<Payment> GetPaymentById(int Id);
    Task<List<Payment>> GetAmounts(string amount);
    Task<Payment> GetAmountById(int Id, string amount);
    Task<List<Payment>> GetStatuses(string status);
    Task<Payment> GetStatusById(int Id, string status);
}
