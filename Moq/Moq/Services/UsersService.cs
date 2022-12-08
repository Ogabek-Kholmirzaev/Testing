using MoqApi.Dto;
using MoqApi.Entities;
using MoqApi.Repositories;

namespace MoqApi.Services;

public class UsersService:IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository, IProductRepository productRepository)
    {
        _usersRepository = usersRepository;
    }

    public UserDto? GetUser(int id)
    {
        var user = _usersRepository.GetUser(id);
        if (user is null)
            return null;

        return new UserDto()
        {
            Name = user.Name,
        };
    }

    public void AddUser(UserDto userDto)
    {
        var user = new UserEntity()
        {
            Name = userDto.Name
        };

        _usersRepository.AddUser(user);
    }

    public int Sum(int a, int b) => a + b;
}