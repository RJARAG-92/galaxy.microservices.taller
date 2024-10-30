using Microservices.Demo.Report.API.Domain.Entities;

namespace Microservices.Demo.Report.API.Infrastructure.Agents.Product
{
    public class ProductAgent : IProductAgent
    {
        private readonly IProductClient productClient;

        public ProductAgent(IProductClient productClient)
        {
            this.productClient = productClient;
        }

        public async Task<IEnumerable<Domain.Entities.Product>> GetProductsAll()
        {
            var result = await productClient.GetProductsAll();

            return result.Select(x => new Domain.Entities.Product { 
                Code = x.Code,
                Description=x.Description
            });
        }
         
    }
}
