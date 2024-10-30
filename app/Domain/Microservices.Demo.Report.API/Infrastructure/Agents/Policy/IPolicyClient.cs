
using Microservices.Demo.Report.API.Infrastructure.Agents.Policy.Querys;
using RestEase;

namespace Microservices.Demo.Report.API.Infrastructure.Agents.Policy
{
    public interface IPolicyClient
    {
        [Get]
        Task<IEnumerable<GetPoliciesVersionAllResult>> GetPoliciesVersionAll();
    }
}
