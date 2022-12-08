using Moq;
using MoqApi.Entities;
using MoqApi.Repositories;

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
        UsersRepositoryMock.Setup(u => u.GetUser(2)).Returns(new UserEntity(){Id = 1, Name = "user1"});

        var user = new UserEntity()
        {
            Id = 1,
            Name = "userName1"
        };

        Assert.Equal(user, UsersRepository.GetUser(1)); // False
    }

    [Fact]
    public void GetNameTest()
    {
        UsersRepositoryMock.Setup(u => u.GetName()).Returns("name");

        Assert.NotNull(UsersRepository.GetName()); // True
        Assert.Equal("name", UsersRepository.GetName()); // True
        
    }
}