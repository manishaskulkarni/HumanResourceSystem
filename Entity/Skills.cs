using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Skill
    {
        public int SkillId { get; set; }
        public String SkillName { get; set; }
        public String SkillDescription { get; set; }
        public int CategoryID { get; set; }
        public String CatName { get; set; }
        public String CreatedBy { get; set; }
    }
}
