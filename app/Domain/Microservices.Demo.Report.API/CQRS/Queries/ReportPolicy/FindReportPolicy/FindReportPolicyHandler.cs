using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using Microservices.Demo.Report.API.Infrastructure.Agents.Policy;
using Microservices.Demo.Report.API.Infrastructure.Agents.Product;

namespace Microservices.Demo.Report.API.CQRS.Queries.ReportPolicy.FindReportPolicy
{
    public class FindReportPolicyHandler : IRequestHandler<FindReportPolicyQuery, IEnumerable<ReportPolicyDto>>
    {
        private readonly IPolicyAgent _policyAgent;
        private readonly IProductAgent _productAgent;
        public FindReportPolicyHandler(IPolicyAgent policyAgent, IProductAgent productAgent)
        {
            _policyAgent = policyAgent ?? throw new ArgumentNullException(nameof(policyAgent));
            _productAgent = productAgent ?? throw new ArgumentNullException(nameof(productAgent));
        }

        public async Task<IEnumerable<ReportPolicyDto>> Handle(FindReportPolicyQuery request, CancellationToken cancellationToken)
        {
            var listProducts = await _productAgent.GetProductsAll();

            var listPolicies = await _policyAgent.GetPoliciesVersionAll();

            return listPolicies.Select(x=>new ReportPolicyDto
            {
                VersionNumber = x.VersionNumber,
                PolicyNumber=x.PolicyNumber,
                PolicyHolder = x.PolicyHolder,
                TotalPremium=x.TotalPremium,
                ProductCode = x.ProductCode,
                ProductDescription = listProducts.FirstOrDefault(y => y.Code == x.ProductCode)?.Description ?? string.Empty,
                AgentLogin= request.AgentLogin
            }).ToList();
        }
    }
}
