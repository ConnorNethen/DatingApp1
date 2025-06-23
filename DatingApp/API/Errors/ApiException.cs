using Microsoft.AspNetCore.Mvc;

namespace API.Errors
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiException(int statusCode, string message, string? details)
    {
        public int StatusCode { get; set; } = statusCode;
        public string Message { get; set; } = message;
        public string? Details { get; set; } = details;
    }
}
