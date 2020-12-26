using LoanCar.Data;

namespace LoanCar.Services
{
    public class LoanService : BaseService<Loan>,ILoanService
    {
        public LoanService(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext) { }
    }
}
