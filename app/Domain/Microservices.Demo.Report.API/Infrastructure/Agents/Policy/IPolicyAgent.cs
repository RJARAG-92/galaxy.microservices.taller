using Microservices.Demo.Report.API.Domain.Entities;

namespace Microservices.Demo.Report.API.Infrastructure.Agents.Policy
{
    public interface IPolicyAgent
    {
        Task<IEnumerable<PolicyVersion>> GetPoliciesVersionAll();
    }
}
