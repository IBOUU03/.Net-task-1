using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController:Controller
    {
        //public ContentResult Detail() { 
        //ContentResult result = new ContentResult();

        //result.Content = "Product detial";

        //return result;
        //}

        //public JsonResult Detail()
        //{
        //    JsonResult result = new JsonResult(new { Name = "qwer", Price = 23 });
        //    return result;
        //}

        public ContentResult Detail(int id)
        {
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "Detail";
        //    return result;
            return Content(id.ToString());
        }


        public ViewResult Index()
        {
            //ViewResult result = new ViewResult();
            //result.ViewName = "Index";

            var result = View();

            return result;
        }


    }
}
