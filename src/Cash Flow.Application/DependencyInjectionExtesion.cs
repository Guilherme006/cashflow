using Cash_Flow.Application.AutoMapper;
using Cash_Flow.Application.UseCases.Expenses.Delete;
using Cash_Flow.Application.UseCases.Expenses.GetAll;
using Cash_Flow.Application.UseCases.Expenses.GetById;
using Cash_Flow.Application.UseCases.Expenses.Register;
using Cash_Flow.Application.UseCases.Expenses.Reports.Excel;
using Cash_Flow.Application.UseCases.Expenses.Reports.Pdf;
using Cash_Flow.Application.UseCases.Expenses.Update;
using CashFlow.Application.UseCases.Expenses.Register;
using Microsoft.Extensions.DependencyInjection;

namespace Cash_Flow.Application;

public static class DependencyInjectionExtesion
{
    public static void AddAplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
    }
}
