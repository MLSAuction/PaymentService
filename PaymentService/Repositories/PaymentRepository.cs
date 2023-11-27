namespace PaymentService.Repositories
{
    public class PaymentRepository
    {
        private readonly ILogger<PaymentRepository> _logger;
        private readonly IConfiguration _configuration;

        public PaymentRepository (ILogger<PaymentRepository> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
    }
}
