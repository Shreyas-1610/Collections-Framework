using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPrac
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Dept { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "ABC",Salary = 30, Dept = "IT"},
                new Employee{ Id = 2, Name = "DEF",Salary = 40, Dept = "IT"},
                new Employee{ Id = 3, Name = "GHI",Salary = 10, Dept = "Sales"},
                new Employee{ Id = 4, Name = "JKL",Salary = 20, Dept = "Marketing"},
                new Employee{ Id = 5, Name = "MNO",Salary = 25, Dept = "Marketing"},
                new Employee{ Id = 6, Name = "PQR",Salary = 35, Dept = "Sales"},
                new Employee{ Id = 7, Name = "STU",Salary = 23, Dept = "Sales"},
                new Employee{ Id = 8, Name = "VWX",Salary = 37, Dept = "IT"},
                new Employee{ Id = 9, Name = "YZA",Salary = 22, Dept = "Marketing"},
                new Employee{ Id = 10, Name = "BCD",Salary = 55, Dept = "HR"}
            };
            return list;
        }
    }
}
