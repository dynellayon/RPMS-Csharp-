using MediatR;
using RPMS.Application.DTOs.Users;
using RPMS.Application.ViewModel.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Requests.Queries
{
    public class GetUserListRequest : IRequest<IQueryable<UserDto>>
    {
    }
}
