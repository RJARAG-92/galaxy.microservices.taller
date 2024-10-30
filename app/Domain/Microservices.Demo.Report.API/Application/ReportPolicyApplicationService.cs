using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using Microservices.Demo.Report.API.CQRS.Queries.ReportPolicy.FindReportPolicy;

namespace Microservices.Demo.Report.API.Application
{
    public class ReportPolicyApplicationService
    {
        private readonly IMediator _mediator;
        public ReportPolicyApplicationService(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        public async Task<IEnumerable<ReportPolicyDto>> GetAllAsync(string agentLogin)
        {
            var reporPolicy = await _mediator.Send(new FindReportPolicyQuery(agentLogin));
            return reporPolicy;
        }
    }
}
