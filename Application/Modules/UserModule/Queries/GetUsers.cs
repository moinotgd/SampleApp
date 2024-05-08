using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Modules.UserModule
{
    public record GetUsers(Expression<Func<User, bool>>? predicates = null) : IRequest<List<User>?>;
    public class GetUsersHandler : IRequestHandler<GetUsers, List<User>?>
    {
        //private readonly DbContext _db; // your ORM dbcontext
        //public GetUsersHandler(DbContext db)
        //{
        //    _db = db;
        //}
        public async Task<List<User>?> Handle(GetUsers request, CancellationToken token)
        {
            return new List<User>()
            {
                new User() { Id = 1, Name = "User 1" },
                new User() { Id = 2, Name = "User 2" },
                new User() { Id = 3, Name = "User 3" }
            };
        }
    }
}
