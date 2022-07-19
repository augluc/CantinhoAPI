using Cantinho.Domain.Entities;

namespace Cantinho.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);