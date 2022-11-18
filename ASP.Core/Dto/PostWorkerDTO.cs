using ASP.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.Core.Dto
{
    public class PostWorkerDTO
    {
        public WorkerDto WorkerDto { get; set; }

        public WorkerType WrokerType { get; set; }
    }
}
