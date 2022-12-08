using Moq;
using MoqApi.Entities;
using MoqApi.Repositories;
using Newtonsoft.Json;

namespace MoqTest;

public class UserServiceTest
{
    public Mock<IUsersRepository> UsersRepositoryMock { get; set; }
    public IUsersRepository UsersRepository { get; set; }

    public UserServiceTest()
    {
        UsersRepositoryMock = new Mock<IUsersRepository>();
        UsersRepository = UsersRepositoryMock.Object;
    }

    [Fact]
    public void GetUserTest()
    {
        UsersRepositoryMock.Setup(u => u.GetUser(2)).Returns(new UserEntity(){Id = 2, Name = "user2"});

        var user2Test1 = new UserEntity() { Id = 2, Name = "user2" };
        var user2Test2 = new UserEntity() { Id = 2, Name = "userName2" };

        Assert.Null(UsersRepository.GetUser(1));
        Assert.NotEqual(JsonConvert.SerializeObject(user2Test2) , JsonConvert.SerializeObject(UsersRepository.GetUser(2)));
        Assert.Equal(JsonConvert.SerializeObject(user2Test1) , JsonConvert.SerializeObject(UsersRepository.GetUser(2)));
    }

    [Fact]
    public void GetNameTest()
    {
        UsersRepositoryMock.Setup(u => u.GetName()).Returns("name");

        Assert.NotNull(UsersRepository.GetName());
        Assert.Equal("name", UsersRepository.GetName());
    }

    [Fact]
    public void AddUserTest()
    {
        UsersRepository.AddUser(new UserEntity());
    }
}