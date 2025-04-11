using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Common
{
    public class DocumentObject
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public int ObjectId { get; set; }

        public ObjectType ObjectType { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
