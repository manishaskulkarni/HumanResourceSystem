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
    public class UserContoller
    {
        public int LogIn(User user)
        {
            return new UserBL().LogIn(user);
        }
    }
}
