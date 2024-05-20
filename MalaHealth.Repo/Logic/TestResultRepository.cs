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
    public class TestResultRepository : GenericRepository<TestResult>, ITestResultRepository
    {
        private readonly ApplicationDBContext dbContext;

        public TestResultRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(TestResult testResult)
        {
            var tr = dbContext.TestResults.FirstAsync(a => a.Id == testResult.Id).GetAwaiter().GetResult();

            if (tr != null)
            {
                tr.ResultDetails = testResult.ResultDetails;
                tr.TestDate = testResult.TestDate;
            }
        }
    }
}
