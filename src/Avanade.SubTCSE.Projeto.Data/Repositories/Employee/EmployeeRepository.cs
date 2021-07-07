using Avanade.SubTCSE.Projeto.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {
    }
}
