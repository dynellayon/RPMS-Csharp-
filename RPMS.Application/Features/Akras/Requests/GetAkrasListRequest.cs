using MediatR;
using RPMS.Application.DTOs.Akras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Akras.Requests
{
    public class GetAkrasListRequest:IRequest<IEnumerable<AkrasDto>>
    {

    }
}
