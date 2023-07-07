using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.OOP
{
    public class AggregationExample
    {
        public void RunAggregationExample()
        {
            Employee employee1 = new Employee("A");
            Employee employee2 = new Employee("B");

            Department dpt = new Department();
            dpt.AddEmployee(employee1);
            dpt.AddEmployee(employee2);
        }
        
    }


    public class Department
    {
        private List<Employee> _employees;
        public Department()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        { 
            _employees.Add(employee);
        }


    }
    public class Employee
    { 
        private string _name;
        public Employee(string name)
        {
            this._name = name;
        }

    }
}
