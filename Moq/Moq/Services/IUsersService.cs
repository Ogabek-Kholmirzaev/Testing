using MoqApi.Dto;

namespace MoqApi.Services;

public interface IUsersService
{
    public UserDto? GetUser(int id);
    public void AddUser(UserDto userDto);
    public int Sum(int a, int b) => a + b;
}