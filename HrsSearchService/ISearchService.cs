using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace HrsSearchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISearchService" in both code and config file together.
    [ServiceContract]
    public interface ISearchService
    {

        [OperationContract]
        DataSet SearchEmpByName(String FirstName, String LastName);
        [OperationContract]
        DataSet SearchCategoryByName(String CatName);
        [OperationContract]
        DataSet SearchSkillByName(String SkillName);
        [OperationContract]
        DataSet SearchProjectByName(String ProjectName);
    }
}
