using System;
using System.Collections.Generic;
using System.Text;

namespace ASP.Core.Dto
{
    public class WorkerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public decimal Payperhour { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAccount { get; set; }
    }
}
