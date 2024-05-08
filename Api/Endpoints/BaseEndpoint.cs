namespace Api.Endpoints
{
    public class BaseEndpoint
    {
        public IResult Ok(string? text = null, object? obj = null)
        {
            return Results.Ok(new
            {
                Success = true,
                Message = text,
                Data = obj
            });
        }
        public IResult Fail(string? text = null)
        {
            return Results.Ok(new
            {
                Success = false,
                Message = text
            });
        }
    }
}
