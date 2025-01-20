using GoTaxi.Data.Contracts;
using GoTaxi.Data.GoTaxiDbContext;
using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Data.Repositories;
public class PaymentRepository : IPaymentRepository
{
    private readonly TaxiDbContext _context;
    public PaymentRepository(TaxiDbContext context)
    {
        _context = context;
    }

    public async Task<Payment> Add(Payment entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Payment> Delete(Payment entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<Payment>> GetAllPayments()
    {
        var payments = await _context.Payments.AsNoTracking().ToListAsync();
        return payments;
    }

    public async Task<Payment> GetAmountById(int Id, string amount)
    {
        var payment = await _context.Payments.SingleOrDefaultAsync(u => u.Id == Id && u.Amount == amount);
        return payment!;
    }

    public async Task<List<Payment>> GetAmounts(string amount)
    {
        var payments = await _context.Payments.Where(u => u.Amount == amount).ToListAsync();
        return payments;
    }

    public async Task<Payment> GetPaymentById(int Id)
    {
        var payments = await _context.Payments.SingleOrDefaultAsync(u => u.Id == Id);
        return payments!;
    }

    public async Task<Payment> GetStatusById(int Id, string status)
    {
        var payment = await _context.Payments.SingleOrDefaultAsync(u => u.Id == Id && u.Status == status);
        return payment!;
    }

    public async Task<List<Payment>> GetStatuses(string status)
    {
        var payments = await _context.Payments.Where(u => u.Status == status).ToListAsync();
        return payments;
    }

    public async Task<Payment> Update(Payment entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
