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
   public class CategoryBL
    {
        public int AddCategory(Category category)
        {
            return new CategoryDAL().AddCategory(category);       //invoking the method written in DAL
        }
        public int EditCategory(Category category)
        {
            return new CategoryDAL().EditCategory(category);
        }
        public int DeleteCategory(Category category)
        {
            return new CategoryDAL().DeleteCategory(category);
        }
        public DataSet SearchCategoryById(Category category)
        {
            return new CategoryDAL().SearchCategoryById(category);
        }
    }
}
