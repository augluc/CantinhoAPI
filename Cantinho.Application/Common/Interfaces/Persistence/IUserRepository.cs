using Cantinho.Domain.Entities;

namespace Cantinho.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void AddUser(User user);

}