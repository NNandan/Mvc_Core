using FinanceApp.Models;

namespace FinanceApp.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();

        Task Add(Expense expense);
        //Task Update(Expense expense);
        //Task Delete(Expense expense);
        //Task<Expense> GetById(int id);
        public IQueryable GetChartData();
        
    }
}
