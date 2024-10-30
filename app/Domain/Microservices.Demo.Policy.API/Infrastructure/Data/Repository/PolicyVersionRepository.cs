
namespace Microservices.Demo.Policy.API.Infrastructure.Data.Repository
{
    using Microservices.Demo.Policy.API.Infrastructure.Data.Context;
    using Microservices.Demo.Policy.API.Infrastructure.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PolicyVersionRepository: IPolicyVersionRepository
    {
        private readonly PolicyDbContext _policyDbContext;
        public PolicyVersionRepository(PolicyDbContext policyDbContext)
        {
            _policyDbContext = policyDbContext;
        }

        public async Task<List<PolicyVersion>> FindAll()
        {
            return await _policyDbContext
                            .PolicyVersions
                            .Include(p => p.Policy)
                            .Include(p => p.PolicyHolder)
                            .ToListAsync();
        }
    }
}
