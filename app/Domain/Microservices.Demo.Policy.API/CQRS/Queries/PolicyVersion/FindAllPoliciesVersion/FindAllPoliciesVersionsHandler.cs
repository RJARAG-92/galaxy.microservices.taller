namespace Microservices.Demo.Policy.API.CQRS.Queries.PolicyVersion.FindAllPoliciesVersion
{
    using MediatR;
    using Microservices.Demo.Policy.API.CQRS.Queries.Infrastructure.Dtos.PolicyVersion;
    using Microservices.Demo.Policy.API.Infrastructure.Data.Repository;

    public class FindAllPoliciesVersionsHandler : IRequestHandler<FindAllPoliciesVersionsQuery, IEnumerable<PolicyVersionDto>>
    {
        private readonly IPolicyVersionRepository _policyVersionRepository;

        public FindAllPoliciesVersionsHandler(IPolicyVersionRepository policyVersionRepository)
        {
            _policyVersionRepository = policyVersionRepository ?? throw new ArgumentNullException(nameof(policyVersionRepository));
        }

        public async Task<IEnumerable<PolicyVersionDto>> Handle(FindAllPoliciesVersionsQuery request, CancellationToken cancellationToken)
        {
            var result = await _policyVersionRepository.FindAll();

            return result.Select(p => new PolicyVersionDto
            {
                VersionNumber = p.VersionNumber,
                PolicyHolder = $"{p.PolicyHolder.FirstName} {p.PolicyHolder.LastName}" ,
                TotalPremium = p.TotalPremiumAmount,
                PolicyNumber = p.Policy.Number,
                ProductCode = p.Policy.ProductCode,
            }).ToList();
        }
    }
}
