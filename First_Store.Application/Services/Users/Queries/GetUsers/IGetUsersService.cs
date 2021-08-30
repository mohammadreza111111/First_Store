using First_Store.Application.Interfaces.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Store.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        List<GetUsersDto> Execute(string SearchKey, int page = 1);
    }

  public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        public List<GetUsersDto> Execute(string SearchKey, int page = 1)
        {
            throw new NotImplementedException();
        }
    }

    public class GetUsersDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
