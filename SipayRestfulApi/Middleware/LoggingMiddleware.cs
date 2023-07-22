using SipayRestfulApi.Service;

namespace SipayRestfulApi.Middleware
{
    public class LoggingMiddleware : IMiddleware
    {
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(ILogger<LoggingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // İstek öncesi loglama
            Console.WriteLine($"[{DateTime.Now}] İstek alındı: {context.Request.Path}");

            await next(context);

            // Cevap sonrası loglama
            Console.WriteLine($"[{DateTime.Now}] Cevap gönderildi: {context.Request.Path}, Status Code: {context.Response.StatusCode}");
        }
    }
}
