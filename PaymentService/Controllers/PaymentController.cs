using Microsoft.AspNetCore.Mvc;
using PaymentService.Repositories;

namespace PaymentService.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly PaymentRepository _repository;

        public PaymentController (ILogger logger, IConfiguration configuration, PaymentRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
        }
    }
}
