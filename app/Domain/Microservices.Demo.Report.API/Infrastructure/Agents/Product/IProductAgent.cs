namespace Microservices.Demo.Report.API.Infrastructure.Agents.Product
{
    using Microservices.Demo.Report.API.Domain.Entities;

    public interface IProductAgent
    {
        Task<IEnumerable<Product>> GetProductsAll();
    }
}
