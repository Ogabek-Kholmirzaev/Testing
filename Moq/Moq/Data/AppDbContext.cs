using Microsoft.EntityFrameworkCore;
using MoqApi.Entities;

namespace MoqApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base()
    {
    }

    public DbSet<UserEntity> Users { get; set; }
}