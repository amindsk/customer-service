using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ui.Models;

//Controller to display list of customers with status Hot
namespace ui.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> customers;
        private APIClient client;
        
        //User must be authorized through Auth0 to access this route
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //If user authenticated
            if (User.Identity.IsAuthenticated)
            {
                //Getting access token to provide in request header while calling backend API
                string accessToken = await HttpContext.GetTokenAsync("access_token");
                client = new APIClient();
                //Sneding GET request to backend API to fetch list of customers with status Hot
                customers = client.GetRequest("/customers", accessToken);
            }
            //Passing list of customers to UI
            return View(customers);
        }
    }
}
