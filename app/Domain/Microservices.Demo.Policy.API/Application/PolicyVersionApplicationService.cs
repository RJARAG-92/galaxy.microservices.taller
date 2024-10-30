using MediatR;
using Microservices.Demo.Policy.API.CQRS.Queries.Infrastructure.Dtos.PolicyVersion;
using Microservices.Demo.Policy.API.CQRS.Queries.PolicyVersion.FindAllPoliciesVersion;

namespace Microservices.Demo.Policy.API.Application
{
    public class PolicyVersionApplicationService
    {
        private readonly IMediator _mediator;
        public PolicyVersionApplicationService(IMediator mediator)
        {
            _mediator = mediator;
        } 
        public async Task<IEnumerable<PolicyVersionDto>> GetAllAsync()
        {
            var policiesVersions = await _mediator.Send(new FindAllPoliciesVersionsQuery());
            return policiesVersions;
        } 
    }
}
