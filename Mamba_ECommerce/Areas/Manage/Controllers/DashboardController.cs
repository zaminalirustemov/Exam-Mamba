using Microsoft.AspNetCore.Mvc;

namespace Mamba_ECommerce.Areas.Manage.Controllers;
[Area("Manage")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}