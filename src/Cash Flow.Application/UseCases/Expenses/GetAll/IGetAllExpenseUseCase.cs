using Cash_Flow.Communication.Responses;

namespace Cash_Flow.Application.UseCases.Expenses.GetAll;

public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
