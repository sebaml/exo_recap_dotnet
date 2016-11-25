using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.ServiceReference1;
using Contoso.ServiceReference2;

namespace Contoso.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(String name)
        {
            var categoryName = name;
            var categoryServiceClient = new ServiceReference2.CategoryServiceClient();

            List<CategoryDetailModel> response = new List<CategoryDetailModel>();

            var listCategories = categoryServiceClient.GetCategoryByName(name);

            if (listCategories == null)
            {
                Session["CategoryFound"] = 0;
                return View("Index");
            }
            else
            {
                foreach (var c in listCategories)
                {
                    CategoryDetailModel cTemp = new CategoryDetailModel()
                    {
                        CategoryId = c.CategoryId,
                        CategoryName = c.CategoryName,
                        Description = c.Description,
                        Picture = c.Picture
                    };
                    response.Add(cTemp);

                }
                Session["CategoryFound"] = 1;
                return View("Index", response);
            }
        }

        /************************************ Adding Category ****************************************
       **************************************************************************************************************/
        public ActionResult AddCategory()
        {
            var category = new CategoryDetailModel();
            return View(category);
        }


        [HttpPost]
        public ActionResult AddCategory(CategoryDetailModel category)
        {
            var categoryServiceClient = new ServiceReference2.CategoryServiceClient();
            CategoryDetail newCategory= new CategoryDetail
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                Picture = category.Picture,
            };
            if (categoryServiceClient.AddCategory(newCategory))
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        /************************************ Editing Category ****************************************
* ************************************************************************************************************/

        public ActionResult Edit(long id)
        {
            Session["CategoryModified"] = id;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(CategoryDetailModel category)
        {
            var categoryServiceClient = new ServiceReference2.CategoryServiceClient();
            CategoryDetail newCategory = new CategoryDetail()
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                Picture = category.Picture,

            };
            newCategory.CategoryId = (long)Session["CategoryModified"];

            categoryServiceClient.UpdateCategory(newCategory);
            Session["CategoryModified"] = -1;
            return RedirectToAction("Index");
        }

    }
}