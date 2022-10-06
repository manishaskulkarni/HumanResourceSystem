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
    public class CategoryController
    {
        /// <summary>
        /// method to add category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public int AddCategory(Category category)
        {
            return new CategoryBL().AddCategory(category);
        }
        public int EditCategory(Category category)
        {
            return new CategoryBL().EditCategory(category);
        }
        public int DeleteCategory(Category category)
        {
            return new CategoryBL().DeleteCategory(category);
        }
        //public DataSet SearchCategoryByName(String CatName)
        //{
        ////    //return new  CategoryController.ServiceReference.ServiceClient().SearchCategoryByName(CatName);
        
        //}
        public DataSet SearchCategoryById(Category category)
        {
            return new CategoryBL().SearchCategoryById(category);
        }
    }
}
