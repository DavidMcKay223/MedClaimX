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

        public Address? PrimaryAddress { get; set; }
        public Address? SecondaryAddress { get; set; }
    }
}
