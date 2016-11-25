using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataModel;

namespace DataRequest
{
    public class CategoryRequests
    {
        public static List<CategoryDetail> ReqGetCategoryByName(string name)
        {
            using (var context = new ContosoContext())
            {
                var categories = context.Categories.Where(c => c.CategoryName == name);
                return categories.Select(c => new CategoryDetail
                {
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    CategoryId = c.CategoryID,
                    Picture = c.Picture
                }).ToList();
            }
        }

        public static bool ReqDelCategory(long id)
        {
            using (var context = new ContosoContext())
            {
                var category = context.Categories.Single(c => c.CategoryID == id);
                context.Categories.Remove(category);
                context.SaveChanges();
                return !context.Categories.Any(c => c.CategoryID == id);
            }
        }

        public static bool ReqUpdateCategory(CategoryDetail cd)
        {
            using (var context = new ContosoContext())
            {
                var category = context.Categories.Single(s => s.CategoryID == cd.CategoryId);
                category.CategoryName = cd.CategoryName;
                category.Description = cd.Description;
                category.Picture = cd.Picture;
                context.SaveChanges();
                return true;
            }
        }

        public static bool ReqAddCategory(CategoryDetail cd)
        {
            using (var context = new ContosoContext())
            {
                var category = new Categories
                {
                    CategoryID = cd.CategoryId,
                    CategoryName = cd.CategoryName,
                    Description = cd.Description,
                    Picture = cd.Picture
                };
                context.Categories.Add(category);
                context.SaveChanges();
                return true;
            }
                
        }
    }
}
