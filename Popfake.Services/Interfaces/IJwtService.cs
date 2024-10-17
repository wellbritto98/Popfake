using PopFake.Data.Dtos.Auth;

namespace PopFake.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(JwtDto dto);
        bool VerifyJwt(string token);
    }
}
