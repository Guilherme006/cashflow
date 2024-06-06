namespace Cash_Flow.Domain.Repositories;

public interface IUnitOfWork
{
    Task Commit();
}
