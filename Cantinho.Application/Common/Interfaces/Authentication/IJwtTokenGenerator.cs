using Cantinho.Domain.Entities;

namespace Cantinho.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator{
    string GenerateToken(User user);
}