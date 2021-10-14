using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDb.Data.Models
{
    class Employee
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Town { get; set; }
        public decimal Salary { get; set; }
        public  int DepartmentName { get; set; }
    }
}
