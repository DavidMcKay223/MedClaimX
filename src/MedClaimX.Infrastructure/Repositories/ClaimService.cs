using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClaimX.Core.Contracts;
using MedClaimX.Core.Management;
using MedClaimX.Infrastructure.Persistence;

namespace MedClaimX.Infrastructure.Repositories
{
    public class ClaimService : IClaimService
    {
        private readonly AppDbContext _db;
        public ClaimService(AppDbContext db)
        {
            _db = db;
        }

        public Task<Claim> CreateClaimAsync(Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClaimAsync(int claimId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Claim>> GetAllClaimsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Claim> GetClaimByIdAsync(int claimId)
        {
            throw new NotImplementedException();
        }

        public Task<Claim> UpdateClaimAsync(Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
