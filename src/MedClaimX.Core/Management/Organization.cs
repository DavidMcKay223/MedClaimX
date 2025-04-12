using MedClaimX.Core.OwnedTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Management
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public OrganizationType OrgType { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(50)]
        public string? Tin { get; set; }

        public required Address PrimaryAddress { get; set; }
        public required Address SecondaryAddress { get; set; }
    }
}
