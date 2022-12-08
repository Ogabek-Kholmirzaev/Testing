using MoqApi.Data;
using MoqApi.Entities;

namespace MoqApi.Repositories;

public class UsersRepository
{
    private readonly AppDbContext _context;

    public UsersRepository(AppDbContext context) => _context = context;

    public UserEntity GetUser(int id)
    {
        return _context.Users.First(u => u.Id == id);
    }

    public void AddUser(UserEntity userEntity)
    {
        _context.Users.Add(userEntity);
        _context.SaveChanges();
    }
}