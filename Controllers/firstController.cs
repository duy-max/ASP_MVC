using System.Linq;
using App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    public class firstController : Controller
        {
           private readonly ILogger <firstController> _logger;
           private readonly ProductService _productService;

           public firstController(ILogger<firstController> logger, ProductService productService){
                 _logger = logger;
                 _productService = productService;
           }
           
         public string index(){
             return " toi la con cua firstController";
         }

        public object anything() => new int[] {1,2,3};
         public IActionResult viewProduct(int? id){
              var product = _productService.Where(p => p.ID == id).FirstOrDefault();
              if(product == null)
             
                  {
                      TempData ["StatusMessage"] ="Sản phẩm bạn yêu cầu không có"; //Nếu sản phẩm k có thì quay về trang chủ
                            return Redirect(Url.Action("Index","Home"));           
                                        }
                  //Truyền qua model
             //return View(product);

             //Truyền qua viewdata
             this.ViewData["product"]=product;
             return View("ViewProduct2");
         }

         public IActionResult Readme(){
             var content =@" xin chào các ban
              tôi là Trường Duy
              đang học lập trình asp.net
             
             ";
             return Content(content,"text/plain");
         }
        }
    
}

