using Microservices.Demo.Report.API.Infrastructure.Agents.Policy.Querys;
using Microservices.Demo.Report.API.Infrastructure.Agents.Product.Query;
using RestEase;

namespace Microservices.Demo.Report.API.Infrastructure.Agents.Product
{
    public interface IProductClient
    {
        [Get]
        Task<IEnumerable<GetProductsAllResult>> GetProductsAll();
    }
}
