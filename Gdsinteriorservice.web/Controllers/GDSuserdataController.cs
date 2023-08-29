using Gdsinteriorservice.web.DataDb;
using Microsoft.AspNetCore.Mvc;

namespace Gdsinteriorservice.web.Controllers
{
    public class GDSuserdataController : Controller
    {
        private readonly GDSContext context;
        public GDSuserdataController(GDSContext context)
        {
            this.context = context; 
        }
        public IActionResult Index(string UserRequest)
        {
            var result =context.UsersData.ToList();
            return View(result);
        }
    }
}
