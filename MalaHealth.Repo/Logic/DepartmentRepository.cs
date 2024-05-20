﻿using DataInterface.Domain;
using MalaHealth.Application.Repository.IRepository;
using MalaHealth.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaHealth.Application.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDBContext dbContext;

        public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Department department)
        {
            var dp = dbContext.Departments.FirstAsync(d => d.Id == department.Id).GetAwaiter().GetResult();

            if (dp != null)
            {
                dp.Name = department.Name;
                dp.Description = department.Description;    
            }
        }
    }
}
