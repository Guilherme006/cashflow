using Cash_Flow.Communication.Requests;

namespace Cash_Flow.Application.UseCases.Expenses.Update;

public interface IUpdateExpenseUseCase
{
    Task Execute(long id, RequestExpenseJson request);
}
