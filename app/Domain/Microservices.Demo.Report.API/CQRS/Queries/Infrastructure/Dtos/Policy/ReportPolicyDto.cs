namespace Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy
{
    public class ReportPolicyDto
    {
        public int VersionNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyHolder { get; set; }
        public decimal TotalPremium { get; set; }
        public string ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public string AgentLogin { get; set; }
    }
}
