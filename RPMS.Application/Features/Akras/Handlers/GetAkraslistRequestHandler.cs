using AutoMapper;
using MediatR;
using RPMS.Application.DTOs.Akras;
using RPMS.Application.Features.Akras.Requests;
using RPMS.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Akras.Handlers
{
    public class GetAkraslistRequestHandler : IRequestHandler<GetAkrasListRequest, IEnumerable<AkrasDto>>
    {
        private readonly IKrasRepository _repository;
        private readonly IMapper _mapper;
        public GetAkraslistRequestHandler(IKrasRepository repository,IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<AkrasDto>> Handle(GetAkrasListRequest request, CancellationToken cancellationToken)
        {
            var kras = await  _repository.GetAll();
            return _mapper.Map<IEnumerable<AkrasDto>>(kras);
        }
    }
}
