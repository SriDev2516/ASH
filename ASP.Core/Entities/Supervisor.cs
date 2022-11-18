using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASP.Core.Entities
{
    public class Supervisor: IWorker
    {
        
            [Key]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public decimal AnnualSalary { get; set; }
        
    }
}
