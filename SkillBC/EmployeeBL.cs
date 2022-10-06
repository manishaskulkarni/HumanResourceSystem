using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;


namespace HRS.BL
{
   public class EmployeeBL
    {
        public int AddEmployee(Employee employee)
        {
            return new EmployeeDAL().AddEmployee(employee);
        }
        public int EditEmployee(Employee employee)
        {
            return new EmployeeDAL().EditEmployee(employee);
        }
        public int DeleteEmployee(Employee employee)
        {
            return new EmployeeDAL().DeleteEmployee(employee);
        }
        public DataSet SearchEmpById(Employee employee)
        {
            return new EmployeeDAL().SearchEmpById(employee);
        }
    }
}
