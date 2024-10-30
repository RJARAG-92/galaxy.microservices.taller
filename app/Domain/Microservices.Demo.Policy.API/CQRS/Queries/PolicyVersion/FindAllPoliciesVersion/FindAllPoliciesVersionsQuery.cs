using MediatR;
using Microservices.Demo.Policy.API.CQRS.Queries.Infrastructure.Dtos.PolicyVersion;

namespace Microservices.Demo.Policy.API.CQRS.Queries.PolicyVersion.FindAllPoliciesVersion
{
    public class FindAllPoliciesVersionsQuery : IRequest<IEnumerable<PolicyVersionDto>>
    {

    }
}
