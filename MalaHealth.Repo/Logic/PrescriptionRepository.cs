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
    public class PrescriptionRepository : GenericRepository<Prescription>, IPrescriptionRepository
    {
        private readonly ApplicationDBContext dbContext;

        public PrescriptionRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Prescription prescription)
        {
            var p = dbContext.Prescriptions.FirstAsync(a => a.Id == prescription.Id).GetAwaiter().GetResult();

            if (p != null)
            {
                p.Instructions = prescription.Instructions;
                p.Medication = prescription.Medication;
                p.PrescriptionDate = prescription.PrescriptionDate;
            }
        }
    }
}
