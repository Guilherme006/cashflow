using Cash_Flow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cash_Flow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{

    public CashFlowDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Expense> Expenses { get; set; }
}
