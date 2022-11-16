using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor = Data.Models.Monitor;

namespace BusinessLogic
{
    public class MonitorService : IMonitorService
    {
        private readonly ShopDbContext context;
        private readonly IMapper mapper;
        public MonitorService(ShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<MonitorDto> GetAll()
        {
            var monitors = context.Monitors.Include(x => x.Matrix).ToList();
            return mapper.Map<IEnumerable<MonitorDto>>(monitors);
        }
        public MonitorDto? GetById(int id)
        {
            var monitor = context.Monitors.Find(id);
            if (monitor == null) return null;
            return mapper.Map<MonitorDto>(monitor);
        }
        public async Task Create(MonitorDto monitor)
        {
            context.Monitors.Add(mapper.Map<Monitor>(monitor)); 
            await context.SaveChangesAsync();
        }
        public async Task Edit(MonitorDto monitor)
        {
            var data = context.Monitors.AsNoTracking().FirstOrDefault(l => l.Id == monitor.Id);
            if (data == null) return;
            context.Monitors.Update(mapper.Map<Monitor>(monitor));
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var laptop = context.Monitors.Find(id);

            if (laptop == null) return;

            context.Monitors.Remove(laptop);
            await context.SaveChangesAsync();
        }


        

    }
}
