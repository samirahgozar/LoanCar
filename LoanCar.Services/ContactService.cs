using LoanCar.Data;

namespace LoanCar.Services
{
    public class ContactService : BaseService<Contact>, IContactService
    {
        public ContactService(CrudApiDbContext crudApiDbContext) : base(crudApiDbContext) { }
    }
}
