using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace First_Store.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        List<GetUsersDto> Execute(RequestGetUserDto requestGetUserDto);
    }
}
