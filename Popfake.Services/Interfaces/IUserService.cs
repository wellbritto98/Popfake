using PopFake.Data.Dtos.Auth;
using PopFake.Models.ApiResponse;
using System.Threading.Tasks;

namespace PopFake.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApiResponse> RegisterUser(RegisterUserDto dto);
        Task<ApiResponse> LoginUser(LoginUserDto dto);
        Task<ApiResponse> RefreshToken();
    }
}
