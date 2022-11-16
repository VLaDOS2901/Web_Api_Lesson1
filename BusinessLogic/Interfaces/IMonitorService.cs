using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface IMonitorService
    {
        IEnumerable<MonitorDto> GetAll();
        MonitorDto GetById(int id);
        Task Create(MonitorDto monitor);
        Task Edit(MonitorDto monitor);
        Task Delete(int id);
    }
}
