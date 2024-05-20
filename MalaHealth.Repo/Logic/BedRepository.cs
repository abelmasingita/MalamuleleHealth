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
    public class BedRepository : GenericRepository<Bed>, IBedRepository
    {
        private readonly ApplicationDBContext dbContext;

        public BedRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Bed bed)
        {
            var bedDb = dbContext.Beds.FirstAsync(a => a.Id == bed.Id).GetAwaiter().GetResult();

            if (bedDb != null)
            {
                bedDb.Availability = bed.Availability;
                bedDb.Number = bed.Number;
            }
        }
    }
}
