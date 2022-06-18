

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;

namespace EsinavUygulamasi.Controllers
{

    public class AdminBaseController : Controller
    {
        Models.UserVM usersession = null;

        public AdminBaseController()
        {
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                usersession = JsonConvert.DeserializeObject<Models.UserVM>(HttpContext.Session.GetString("SessionUser"));
            }
            catch { }

            if (usersession == null)
            {
                context.Result = RedirectToAction("Login", "Login", new {area= "default"});
                base.OnActionExecuting(context);
            }
            else if (usersession.Role.Select(a => a.Name).FirstOrDefault() == "Admin")
            {
                base.OnActionExecuting(context);

            }
            else
            {
                context.Result = RedirectToAction("Index", "Home", new { area = "Student" });
                base.OnActionExecuting(context);
            }

        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            //ViewBag.UserId = usersession.Id;
            //ViewBag.UserName = usersession.Name + usersession.UserName;
            //ViewBag.Surname = usersession.SurName;
        }
    }

}
