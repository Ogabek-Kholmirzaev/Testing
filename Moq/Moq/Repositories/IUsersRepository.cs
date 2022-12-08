using System.Diagnostics.Contracts;
using MoqApi.Entities;

namespace MoqApi.Repositories;

public interface IUsersRepository
{
    public UserEntity? GetUser(int id);

    public void AddUser(UserEntity userEntity);

    public string? GetName();
}