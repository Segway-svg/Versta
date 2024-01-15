using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrderController : Controller
    {
        private readonly APIGateway apiGateway;

        public OrderController(APIGateway ApiGateway)
        {
            this.apiGateway = ApiGateway;

        }

        public IActionResult Index()
        {
            List<Order> orders;

            orders = apiGateway.ListOrders();
            return View(orders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Order order = new Order();
            return View(order);
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Order order = new Order();
            return View();
        }
    }
}
