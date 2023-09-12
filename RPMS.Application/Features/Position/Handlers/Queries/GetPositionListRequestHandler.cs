using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Server.IIS.Core;
using RPMS.Application.DTOs.Position;
using RPMS.Application.Features.Position.Requests.Queries;
using RPMS.Application.Persistence.Contracts;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Position.Handlers.Queries
{
    public class GetPositionListRequestHandler : IRequestHandler<GetPositionListRequest, IEnumerable<PositionDto>>
    {
       private readonly IPositionRepository _repository;
       private readonly IMapper _mapper;
        public GetPositionListRequestHandler(IPositionRepository repository, IMapper mapper) 
        {
            _repository= repository;
            _mapper= mapper;
        }
        public async Task<IEnumerable<PositionDto>> Handle(GetPositionListRequest request, CancellationToken cancellationToken)
        {
           
               var positions = await _repository.GetAll();
               return _mapper.Map<IEnumerable<PositionDto>>(positions);
        }
    }
}
