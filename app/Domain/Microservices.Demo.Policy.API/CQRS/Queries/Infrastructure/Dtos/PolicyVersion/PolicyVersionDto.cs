namespace Microservices.Demo.Policy.API.CQRS.Queries.Infrastructure.Dtos.PolicyVersion
{
    public class PolicyVersionDto
    {
        public int VersionNumber { get; set; }
        public string PolicyNumber { get; set; } 
        public string PolicyHolder { get; set; }
        public decimal TotalPremium { get; set; }
        public string ProductCode { get; set; } 
    }
}
