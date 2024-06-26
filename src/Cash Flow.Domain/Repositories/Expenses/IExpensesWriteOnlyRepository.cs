﻿using Cash_Flow.Domain.Entities;

namespace Cash_Flow.Domain.Repositories.Expenses;

public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    /// <summary>
    /// This function returns TRUE if the deletion was successful otherwise returns FALSE
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> Delete(long id);
}
