using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClaimX.Core.Contracts;
using MedClaimX.Core.Management;
using MedClaimX.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MedClaimX.Infrastructure.Repositories
{
    public class ClaimService : IClaimService
    {
        private readonly AppDbContext _db;
        public ClaimService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Claim> CreateClaimAsync(string userId, Claim claim)
        {
            _db.Claims.Add(claim);
            await _db.SaveChangesAsync();
            return claim;
        }

        public async Task DeleteClaimAsync(int claimId)
        {
            var claim = await _db.Claims.FindAsync(claimId);
            if (claim != null)
            {
                _db.Claims.Remove(claim);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<List<Claim>> GetAllClaimsAsync(string userId)
        {
            // TODO: Need Organization Tied to Claim and UserId will be Tied to Organizations
            return await _db.Claims.ToListAsync();
        }

        public async Task<Claim> GetClaimByIdAsync(int claimId)
        {
            return await _db.Claims.FirstAsync(c => c.Id == claimId);
        }

        public async Task<Claim> UpdateClaimAsync(string userId, Claim claim)
        {
            var existing = await _db.Claims.FindAsync(claim.Id);
            if (existing == null) return null!;

            _db.Entry(existing).CurrentValues.SetValues(claim);
            await _db.SaveChangesAsync();
            return existing;
        }
    }
}
