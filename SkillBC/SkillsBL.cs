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
   public class SkillsBL
    {
        public int AddSkill(Skill skill)
        {
            return new SkillsDAL().AddSkill(skill);
        }
        public int EditSkill(Skill skill)
        {
            return new SkillsDAL().EditSkill(skill);
        }
        public int DeleteSkill(Skill skl1)
        {
            return new SkillsDAL().DeleteSkill(skl1);
        }
        public DataSet SearchSkillById(Skill skill)
        {
            return new SkillsDAL().SearchSkillById(skill);
        }
        public DataSet SelectCat()
        {
            return new SkillsDAL().SelectCat();
        }
    }
}
