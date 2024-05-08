using Application.Modules.UserModule;

namespace Api.Endpoints.UserPortal
{
    public class HomeEndpoint : BaseEndpoint, ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/UserPortal/Home");
            group.MapGet("/", GetUsers);
        }
        public async Task<IResult> GetUsers(IMediator mediator)
        {
            var response = await mediator.Send(new GetUsers());
            return Ok(obj: response);
        }
    }
}