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
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MessageRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Message message)
        {
            var m = dbContext.Messages.FirstAsync(a => a.Id == message.Id).GetAwaiter().GetResult();

            if (m != null)
            {
                m.Purpose = message.Purpose;
                m.Status = message.Status;
                m.AppointmentTime = message.AppointmentTime;
                m.AppointmentDate = message.AppointmentDate;
            }
        }
    }
}
