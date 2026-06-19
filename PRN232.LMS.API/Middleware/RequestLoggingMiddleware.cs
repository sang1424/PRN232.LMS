namespace PRN232.LMS.API.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(
            RequestDelegate next,
            ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var start = DateTime.UtcNow;

            await _next(context);

            var elapsed = (DateTime.UtcNow - start).TotalMilliseconds;
            var method = context.Request.Method;
            var path = context.Request.Path;
            var statusCode = context.Response.StatusCode;

            _logger.LogInformation(
                "[{Method}] {Path} → {StatusCode} ({Elapsed:0.0}ms)",
                method, path, statusCode, elapsed);
        }
    }
}
