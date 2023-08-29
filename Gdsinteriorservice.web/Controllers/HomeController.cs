
using Gdsinteriorservice.web.DataDb;
using Gdsinteriorservice.web.Models;
using Gdsinteriorservice.web.Models.Viewmodel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Gdsinteriorservice.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly GDSContext gDSContext;

        public HomeController (GDSContext GDSContext)
        {
            gDSContext = GDSContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Saveuserdata(Userdetails UserRequest) 
        {
            var userdetails = new Userdata
            {
                FirstName = UserRequest.FirstName,
                LastName = UserRequest.LastName,
                EmailID = UserRequest.EmailID,
                PhoneNo = UserRequest.PhoneNo,
                Address = UserRequest.Address,
                Flattype = UserRequest.Flattype,
            };
            gDSContext.UsersData.Add(userdetails);
            gDSContext.SaveChanges();
            return Json(true);
        }
     
    }
}