using MedClaimX.Core.Contracts;
using MedClaimX.Core.Management;
using MedClaimX.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Infrastructure.Repositories
{
    public class OrganizationService : IOrganizationService
    {
        private readonly AppDbContext _db;
        public OrganizationService(AppDbContext db)
        {
            _db = db;
        }

        public Task<Organization> CreateOrganizationAsync(Organization organization)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrganizationAsync(int organizationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Organization>> GetAllOrganizationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Organization> GetOrganizationByIdAsync(int organizationId)
        {
            throw new NotImplementedException();
        }

        public Task<Organization> UpdateOrganizationAsync(Organization organization)
        {
            throw new NotImplementedException();
        }
    }
}
