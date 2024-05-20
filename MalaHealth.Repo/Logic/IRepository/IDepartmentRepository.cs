using DataInterface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaHealth.Application.Repository.IRepository
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        void Update(Department department);
    }
}
