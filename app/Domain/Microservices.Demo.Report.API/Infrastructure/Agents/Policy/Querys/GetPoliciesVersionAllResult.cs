namespace Microservices.Demo.Report.API.Infrastructure.Agents.Policy.Querys
{
    public class GetPoliciesVersionAllResult
    {
        public int VersionNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyHolder { get; set; }
        public decimal TotalPremium { get; set; }
        public string ProductCode { get; set; }
    }
}
