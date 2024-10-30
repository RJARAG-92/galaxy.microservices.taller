namespace Microservices.Demo.Policy.API.Infrastructure.Data.Repository
{
    using Microservices.Demo.Policy.API.Infrastructure.Data.Entities;
    public interface IPolicyVersionRepository
    {
        Task<List<PolicyVersion>> FindAll();
    }
}
