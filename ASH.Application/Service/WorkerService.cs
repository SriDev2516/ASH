using ASH.Application.Interfaces;
using ASH.Infrastructure.Interfaces;
using ASH.Infrastructure.Repository;
using ASP.Core.Dto;
using ASP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.Application.Service
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository workerRepository;

        public WorkerService(IWorkerRepository workerRepository)
        {
            this.workerRepository = workerRepository;
        }
        public void AddWorker(IWorker worker)
        {
            workerRepository.AddWorker(worker);
        }

        public Task<List<WorkerDto>> GetAllWorkers()
        {
            return workerRepository.GetAllWorkers();
        }
    }
}
