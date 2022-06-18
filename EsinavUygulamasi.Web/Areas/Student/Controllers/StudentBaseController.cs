using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;

namespace EsinavUygulamasi.Areas.Student.Controllers
{
    public class StudentBaseController : Controller
    {
        Models.UserVM usersession=null;

        public StudentBaseController()
        {
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                usersession = JsonConvert.DeserializeObject<Models.UserVM>(HttpContext.Session.GetString("SessionUser"));
            }
            catch{ }
            if (usersession == null)
            {
                context.Result = RedirectToAction("Login", "Login", new { area = "default"});
                base.OnActionExecuting(context);
            }

            else if (usersession.Role.Select(a => a.Name).FirstOrDefault() == "öğrenci")
            {
                base.OnActionExecuting(context);
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
