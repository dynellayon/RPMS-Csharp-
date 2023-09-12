﻿using MediatR;
using RPMS.Application.DTOs.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Position.Requests.Queries
{
    public class GetPositionListRequest :IRequest<IEnumerable<PositionDto>>
    {
    }
}
