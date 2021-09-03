using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TL2_TP2.Models
{
    public static class EmployeeCreator
    {
        public static Employee CreateEmployee()
        {
            return new Employee(1,"Perez", "Juan", "12345678", DateTime.Now, "Tu casa", DateTime.Now, 20000);
        }
    }
}
