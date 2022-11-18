using ASH.Infrastructure.Interfaces;
using ASP.Core.Dto;
using ASP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.Infrastructure.Repository
{
    public class WorkerRepositry: IWorkerRepository
    {
        private readonly WorkerDBContext workerDBContext;

        public WorkerRepositry(WorkerDBContext workerDBContext)
        {
            this.workerDBContext = workerDBContext;
        }

        public void AddWorker(IWorker worker)
        {
            workerDBContext.SaveChanges();
        }

        public async Task<List<WorkerDto>> GetAllWorkers()
        {
            List<WorkerDto> workerDtos = new List<WorkerDto>();
            var employeesdto = workerDBContext.Employees.Select(x => new WorkerDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Id = x.Id,
                Payperhour = x.Payperhour
            });
            var supervisorDto = workerDBContext.Supervisors.Select(x => new WorkerDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Id = x.Id,
                AnnualSalary = x.AnnualSalary
            });
            var managerDto = workerDBContext.Managers.Select(x => new WorkerDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Id = x.Id,
                AnnualSalary = x.AnnualSalary,
                MaxExpenseAccount = x.MaxExpenseAccount
            });
            workerDtos.AddRange(employeesdto);
            workerDtos.AddRange(supervisorDto);
            workerDtos.AddRange(managerDto);

            return workerDtos;



        }
    }
}
