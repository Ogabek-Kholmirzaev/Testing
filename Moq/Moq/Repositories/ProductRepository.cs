using MoqApi.Data;

namespace MoqApi.Repositories;

public class ProductRepository:IProductRepository
{
    public ProductRepository(AppDbContext context)
    {

    }
}