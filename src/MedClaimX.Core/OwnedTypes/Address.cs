using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.OwnedTypes
{
    [Owned]
    public class Address
    {
        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? State { get; set; }

        [MaxLength(20)]
        public string? ZipCode { get; set; }

        public GeoLocation? GeoLocation { get; set; }
    }
}
