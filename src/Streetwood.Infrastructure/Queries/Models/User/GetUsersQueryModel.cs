using System.Collections.Generic;
using MediatR;
using Streetwood.Core.Dto;
using Streetwood.Infrastructure.Dto;

namespace Streetwood.Infrastructure.Queries.Models.User
{
    public class GetUsersQueryModel : IRequest<IList<UserDto>>
    {
        public GenericListWithPagingRequestModel Req { get; set; }

        public GetUsersQueryModel(GenericListWithPagingRequestModel req)
        {
            Req = req;
        }
    }
}
