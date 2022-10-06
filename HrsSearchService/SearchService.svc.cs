using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using HRS.Controller;
using DAL;
namespace HrsSearchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SearchService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SearchService.svc or SearchService.svc.cs at the Solution Explorer and start debugging.
    public class SearchService : ISearchService
    {
        public DataSet SearchEmpByName(String FirstName, String LastName)
        {
            return new EmployeeDAL().SearchEmpByName(FirstName, LastName);

        }
        public DataSet SearchCategoryByName(String CatName)
        {
            return new CategoryDAL().SearchCategoryByName(CatName);

        }
        public DataSet SearchSkillByName(String CatName)
        {
            return new SkillsDAL().SearchSkillByName(CatName);

        }
        public DataSet SearchProjectByName(String ProjectName)
        {
            return new ProjectDAL().SearchProjectByName(ProjectName);

        }
    }
}
