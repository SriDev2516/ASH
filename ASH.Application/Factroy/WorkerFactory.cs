using ASP.Core.Entities;
using ASP.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASH.Application.Factroy
{
    public class WorkerFactory
    {
       
        public static IWorker GetWroker(WorkerType workerType)
        {
            switch (workerType)
            {
                case WorkerType.Employee:
                    return new Employee();
                    
                case WorkerType.Supervisor:
                    return new Supervisor();

                case WorkerType.Manager:
                    return new Manager();

                default:
                    return null;
            }
        }
    }
}
