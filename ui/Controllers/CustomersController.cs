using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ui.Models;

namespace ui.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> customers;
        private APIClient client;
        
        [Authorize]
        public async Task<IActionResult> Index()
        { 
            if (User.Identity.IsAuthenticated)
            {
                string accessToken = await HttpContext.GetTokenAsync("access_token");
                client = new APIClient();
                customers = client.GetRequest("/customers", accessToken);
            }
            return View(customers);
        }
    }
}
