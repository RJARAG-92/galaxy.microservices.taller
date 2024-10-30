using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;

namespace Microservices.Demo.Report.API.CQRS.Queries.ReportPolicy.FindReportPolicy
{
    public class FindReportPolicyQuery : IRequest<IEnumerable<ReportPolicyDto>>
    {
        public FindReportPolicyQuery(string agentLogin)
        {
            AgentLogin = agentLogin;
        }

        public string AgentLogin { get; set; }

    }
}
