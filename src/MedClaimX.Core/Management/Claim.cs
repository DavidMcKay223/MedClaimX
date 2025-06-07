using MedClaimX.Core.OwnedTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Management
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }

        public string? ClaimNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public required Address PrimaryAddress { get; set; }
        public required Address SecondaryAddress { get; set; }
    }
}
