using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public String ProjectName { get; set; }
        public String ClientName { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }
        public Double Budget { get; set; }
        public String CreatedBy { get; set; }
    }
}
