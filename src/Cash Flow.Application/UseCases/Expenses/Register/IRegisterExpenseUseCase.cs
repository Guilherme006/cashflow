using Cash_Flow.Communication.Requests;
using Cash_Flow.Communication.Responses;

namespace Cash_Flow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    Task<ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);
}
