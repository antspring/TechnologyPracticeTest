namespace TechnologyPracticeTestWeb.Middlewares;

public class ConcurrencyLimitMiddleware
{
    private readonly RequestDelegate _next;
    private readonly SemaphoreSlim _semaphore;

    public ConcurrencyLimitMiddleware(RequestDelegate next, int maxConcurrentRequests)
    {
        _next = next;
        _semaphore = new SemaphoreSlim(maxConcurrentRequests);
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!await _semaphore.WaitAsync(0))
        {
            context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;
            await context.Response.WriteAsync("Service unavailable");

            return;
        }

        try
        {
            await _next(context);
        }
        finally
        {
            _semaphore.Release();
        }
    }
}