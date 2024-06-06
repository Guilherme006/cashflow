using Cash_Flow.Communication.Responses;

namespace Cash_Flow.Application.UseCases.Expenses.GetById;

public interface IGetExpenseByIdUseCase
{
    Task<ResponseExpenseJson> Execute(long id);
}
