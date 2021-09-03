using First_Store.Application.Interfaces.Context;
using First_Store.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace First_Store.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        public List<GetUsersDto> Execute(RequestGetUserDto requestGetUserDto)
        {
            var users = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(requestGetUserDto.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(requestGetUserDto.SearchKey) && p.Email.Contains(requestGetUserDto.SearchKey));
            }

            int rowsCount = 0;
            return users.ToPaged(requestGetUserDto.Page, 20, out rowsCount).Select(p => new GetUsersDto { Email = p.Email, FullName = p.FullName, Id = p.Id }).ToList();
        }
    }
}
