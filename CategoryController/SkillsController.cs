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
    public class SkillsController
    {
        public int AddSkill(Skill skill)
        {
            return new SkillsBL().AddSkill(skill);
        }
        public int EditSkill(Skill Skill)

        {
            return new SkillsBL().EditSkill(Skill);
        }
        //public DataSet SearchSkillByName(String skillName)
        //{
        //    return new HrsController.ServiceReference.ISearchService().SearchSkillByName(skillName);

        //}
        public int DeleteSkill(Skill skl)

        {
            return new SkillsBL().DeleteSkill(skl);
        }
        public DataSet SearchSkillById(Skill skill)
        {
            return new SkillsBL().SearchSkillById(skill);
        }
        public DataSet SelectCat()
        {
            return new SkillsBL().SelectCat();
        }
    }
}
