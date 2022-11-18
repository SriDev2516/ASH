using ASH.Application.Factroy;
using ASH.Application.Interfaces;
using ASP.Core.Dto;
using ASP.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService workerService;

        public WorkerController(IWorkerService workerService)
        {
            this.workerService = workerService;
        }

       
        [HttpGet]
        public async Task<List<WorkerDto>> Get()
        {
            return await workerService.GetAllWorkers();
        }


        [HttpPost(Name ="SaveWorker")]
        public async Task<IActionResult> Post([FromBody] PostWorkerDTO postWorkerDTO)
        {
            if (postWorkerDTO == null)
            {
                ModelState.AddModelError("Incorrect Worker Type", "Please provide correct worker details to save a record");
                return BadRequest();
            }
            
            var worker = WorkerFactory.GetWroker(postWorkerDTO.WrokerType);

            workerService.AddWorker(worker);

            return Ok();
        }

    }
}
