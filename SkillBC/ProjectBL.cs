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
    public class ProjectBL
    {
        public int AddProject(Project project)
        {
            return new ProjectDAL().AddProject(project);
        }
        public int EditProject(Project project)
        {
            return new ProjectDAL().EditProject(project);
        }
        public int DeleteProject(Project pjt)
        {
            return new ProjectDAL().DeleteProject(pjt);
        }
        public DataSet SearchProjectById(Project project)
        {
            return new ProjectDAL().SearchProjectById(project);
        }
    }
}
