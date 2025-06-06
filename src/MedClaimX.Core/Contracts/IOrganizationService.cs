using MedClaimX.Core.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Contracts
{
    public interface IOrganizationService
    {
        Task<List<Organization>> GetAllOrganizationsAsync();
        Task<Organization> GetOrganizationByIdAsync(int organizationId);
        Task<Organization> CreateOrganizationAsync(Organization organization);
        Task<Organization> UpdateOrganizationAsync(Organization organization);
        Task DeleteOrganizationAsync(int organizationId);
    }
}
