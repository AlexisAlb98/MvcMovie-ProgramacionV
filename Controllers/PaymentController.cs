using Microsoft.AspNetCore.Mvc;
using MvcMovie.Services;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    public class PaymentController : Controller
    {
        private readonly MercadoPagoService _mercadoPagoService;

        public PaymentController(MercadoPagoService mercadoPagoService)
        {
            _mercadoPagoService = mercadoPagoService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment(decimal amount, string token, string description, string email)
        {
            if (string.IsNullOrEmpty(token))
            {
                // Manejar el caso en el que el token es nulo o vacío
                return View("Error");
            }

            var payment = await _mercadoPagoService.CreatePayment(amount, token, description, email);
            if (payment.Status == "approved")
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
