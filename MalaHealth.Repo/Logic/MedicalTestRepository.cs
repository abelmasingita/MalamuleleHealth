using DataInterface.Domain;
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
    public class MedicalTestRepository : GenericRepository<MedicalTest>, IMedicalTestRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MedicalTestRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(MedicalTest medicalTest)
        {
            var mt = dbContext.MedicalTests.FirstAsync(a => a.Id == medicalTest.Id).GetAwaiter().GetResult();

            if (mt != null)
            {
                mt.Cost = medicalTest.Cost;
                mt.TestName = medicalTest.TestName;
            }
        }
    }
}
