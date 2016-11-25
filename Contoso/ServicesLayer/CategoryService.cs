using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
using DataRequest;

namespace ServicesLayer
{
    public class CategoryService : ICategoryService
    {
        public List<CategoryDetail> GetCategoryByName(string name)
        {
            return CategoryRequests.ReqGetCategoryByName(name);
        }

        public void DelCategory(long id)
        {
            CategoryRequests.ReqDelCategory(id);
        }

        public bool UpdateCategory(CategoryDetail cd)
        {
            return CategoryRequests.ReqUpdateCategory(cd);
        }

        public bool AddCategory(CategoryDetail cd)
        {
            return CategoryRequests.ReqAddCategory(cd);
        }
    }
}