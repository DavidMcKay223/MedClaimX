using MedClaimX.Core.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Contracts
{
    public interface IClaimService
    {
        Task<List<Claim>> GetAllClaimsAsync(string userId);
        Task<Claim> GetClaimByIdAsync(int claimId);
        Task<Claim> CreateClaimAsync(string userId, Claim claim);
        Task<Claim> UpdateClaimAsync(string userId, Claim claim);
        Task DeleteClaimAsync(int claimId);
    }
}
