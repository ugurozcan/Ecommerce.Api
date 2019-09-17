using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Streetwood.Core.Domain.Entities;
using Streetwood.Core.Dto;
using Streetwood.Infrastructure.Dto;

namespace Streetwood.Infrastructure.Services.Abstract.Queries
{
    public interface IUserQueryService
    {
        Task<GenericListWithPagingResponseModel<UserDto>> GetAsync(GenericListWithPagingRequestModel req);

        Task<UserDto> GetByIdAsync(Guid id);

        Task<User> GetRawByIdAsync(Guid id);

        Task<TokenModel> GetTokenAsync(string email, string password);

        Task<TokenModel> RefreshTokenAsync(string jwtToken, string refreshToken);

        Task<User> CreateChangePasswordTokenAsync(string email);
    }
}
