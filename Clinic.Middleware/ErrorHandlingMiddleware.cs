
using Microsoft.EntityFrameworkCore;
using mvc_practice.Clinic.DAL;

namespace mvc_practice.Clinic.Middleware
{
    public class ErrorHandlingMiddleware
    {
     private readonly RequestDelegate _next;
     private readonly ILogger<ErrorHandlingMiddleware> _logger;

     private readonly IHostEnvironment _env;

     public ErrorHandlingMiddleware( RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger){
        _next = next;
        _logger = logger;
     }   

     public async Task Invoke( HttpContext context ){
        try
        {
            await _next(context );
        }
        catch( DatabaseException dbEx ){
           _logger.LogError( dbEx, "Unhandled exception ocurred");
           await HandleExceptionAsync(context, dbEx);
        }
        catch (Exception ex)
        {
           _logger.LogError( ex, "Unhandled exception ocurred");
           await HandleExceptionAsync( context, ex);
        }
     }

     private async Task HandleExceptionAsync( HttpContext context, Exception ex){

     }
    }
}