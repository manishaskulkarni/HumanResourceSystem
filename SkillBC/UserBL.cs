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
   public class UserBL
    {
        public int LogIn(User user)
        {
            return new UserDAL().LogIn(user);
        }
    }
}
