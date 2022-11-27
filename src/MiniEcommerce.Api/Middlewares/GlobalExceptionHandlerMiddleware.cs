using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;

namespace MiniEcommerce.Api.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            try
            {
                await _next(context);

            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex);
                

                ProblemDetails problem = new()
                {
                    Instance = context.Request.HttpContext.Request.Path,
                    Title = "Server error",
                    Detail = ex.Message
                };

                if (ex is BadHttpRequestException badHttpRequestException)
                {
                    problem.Title = "The request is invalid";
                    problem.Status = StatusCodes.Status400BadRequest;
                    problem.Detail = badHttpRequestException.Message;
                }
                else
                {

                    problem.Title = ex.Message;
                    problem.Status = StatusCodes.Status500InternalServerError;
                    problem.Detail = ex.ToString();
                }

                context.Response.StatusCode = problem.Status.Value;

                string jsonException = JsonSerializer.Serialize(problem);
                
                context.Response.ContentType = "applicaiton/problem+json";

                await context.Response.WriteAsync(jsonException);

            }


        }

    }
}
