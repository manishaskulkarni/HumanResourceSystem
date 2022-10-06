using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using HRS.BL;
using System.Data;
using System.Web.UI;

namespace HRS.Controller
{
     public class EmployeeController
    {
        public int AddEmployee(Employee employee)
        {
            return new EmployeeBL().AddEmployee(employee);
        }
        public int EditEmployee(Employee employee)
        {
            return new EmployeeBL().EditEmployee(employee);
        }
        public int DeleteEmployee(Employee emp)
        {
            return new EmployeeBL().DeleteEmployee(emp);
        }
        //public DataSet SearchEmpByName(String empfname, String emplname)
        //{
        //    return new ServiceReference.
        //    //return new ServiceReference.HrsSearviceClient
        //}

        public DataSet SearchEmpById(Employee EmpId)
        {
            return new EmployeeBL().SearchEmpById(EmpId);
        }
    }
}
