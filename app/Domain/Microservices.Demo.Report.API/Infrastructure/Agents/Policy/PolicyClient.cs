namespace Microservices.Demo.Report.API.Infrastructure.Agents.Policy
{
    using Microservices.Demo.Report.API.Infrastructure.Agents.Policy.Querys;
    using Microservices.Demo.Report.API.Infrastructure.Configuration;
    using Microsoft.Extensions.Options;
    using Polly;
    using RestEase;
    using Steeltoe.Common.Discovery;
    using Steeltoe.Discovery;

    public class PolicyClient : IPolicyClient
    {
        private readonly IPolicyClient client;
        public readonly ServicesUrl _servicesUrl;

        private static IAsyncPolicy retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(retryCount: 3, sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(3));

        public PolicyClient(IOptions<ServicesUrl> servicesUrl, IDiscoveryClient discoveryClient)
        {
            _servicesUrl = servicesUrl.Value;
            var handler = new DiscoveryHttpClientHandler(discoveryClient);
            //Certificado no valido
            handler.ServerCertificateCustomValidationCallback = delegate { return true; };
            var httpClient = new HttpClient(handler, false)
            {
                BaseAddress = new Uri(_servicesUrl.PolicyApiUrl)
            };
            client = RestClient.For<IPolicyClient>(httpClient);
        }
        public Task<IEnumerable<GetPoliciesVersionAllResult>> GetPoliciesVersionAll()
        {
            try
            {
                return retryPolicy.ExecuteAsync(async () => await client.GetPoliciesVersionAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
