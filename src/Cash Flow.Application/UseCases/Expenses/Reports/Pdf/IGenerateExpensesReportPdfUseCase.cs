namespace Cash_Flow.Application.UseCases.Expenses.Reports.Pdf;

public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
