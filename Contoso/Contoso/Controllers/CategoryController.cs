using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;

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
            var categoryServiceClient = new CategoryServices.CategoryServiceClient();

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

       /* public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}