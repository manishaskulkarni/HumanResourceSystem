using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using HRS.BL;
using System.Data;

namespace HRS.Controller
{
    public class ProjectController
    {
        public int AddProject(Project project)
        {
            return new ProjectBL().AddProject(project);
        }
        public int EditProject(Project project)

        {
            return new ProjectBL().EditProject(project);
        }
        //public DataSet SearchProjectByName(String projectName)
        //{
        //    return new HrsController.SearchServiceReference.HrsSearchServicesClient().SearchProjectByName(projectName);

        //}

        public int DeleteProject(Project pjt)

        {
            return new ProjectBL().DeleteProject(pjt);
        }
        public DataSet SearchProjectById(Project project)

        {
            return new ProjectBL().SearchProjectById(project);
        }
    }
}
