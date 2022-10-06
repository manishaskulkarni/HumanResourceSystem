using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using DAL;
using System.Configuration;
using System.Data.SqlClient;


namespace SearchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Search" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Search.svc or Search.svc.cs at the Solution Explorer and start debugging.
    public class Search : ISearch
    {
        public DataSet SearchEmpByName(String FirstName, String LastName)
        {
            return new EmployeeDAL().SearchEmpByName(FirstName, LastName);

        }
    }
}
