using ASP.Core.Dto;
using ASP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASH.Application.Interfaces
{
    public interface IWorkerService
    {
        public Task<List<WorkerDto>> GetAllWorkers();
        public void AddWorker(IWorker worker);
    }
}
