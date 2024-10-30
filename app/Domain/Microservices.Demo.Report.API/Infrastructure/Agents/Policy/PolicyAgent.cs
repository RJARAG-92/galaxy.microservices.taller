using Microservices.Demo.Report.API.Domain.Entities;

namespace Microservices.Demo.Report.API.Infrastructure.Agents.Policy
{
    public class PolicyAgent : IPolicyAgent
    {
        private readonly IPolicyClient policyClient;

        public PolicyAgent(IPolicyClient policyClient)
        {
            this.policyClient = policyClient;
        }

        public async Task<IEnumerable<PolicyVersion>> GetPoliciesVersionAll()
        {
            var result = await policyClient.GetPoliciesVersionAll();

            return result.Select(x=>new PolicyVersion { 
                PolicyHolder=x.PolicyHolder,
                PolicyNumber=x.PolicyNumber,
                ProductCode=x.ProductCode,
                TotalPremium=x.TotalPremium,
                VersionNumber=x.VersionNumber,
            });
        }
    }
}
