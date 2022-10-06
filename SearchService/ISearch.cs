using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SearchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISearch" in both code and config file together.
    [ServiceContract]
    public interface ISearch
    {
        [OperationContract]
        DataSet SearchEmpByName(String FirstName, String LastName);
    }
}
