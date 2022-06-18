using EsinavUygulamasi.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Controllers
{
    public class RoleController : Controller
    {
        readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            var roleList = _roleService.GetListWithUser();

            return View(roleList);
        }
    }
}
