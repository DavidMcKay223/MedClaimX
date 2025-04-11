using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Common
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string FileName { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string FileExtension { get; set; } = string.Empty;

        [Required]
        public byte[] Content { get; set; } = [];

        [Required]
        [MaxLength(128)]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [MaxLength(128)]
        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        private static readonly Dictionary<string, string> MimeTypes = new()
        {
            { ".pdf", "application/pdf" },
            { ".jpg", "image/jpeg" },
            { ".jpeg", "image/jpeg" },
            { ".png", "image/png" },
            { ".gif", "image/gif" },
            { ".txt", "text/plain" },
        };

        private static readonly HashSet<string> AllowedExtensions = new()
        {
            ".pdf",
            ".jpg",
            ".jpeg",
            ".png"
        };

        public string MimeType => MimeTypes.ContainsKey(FileExtension.ToLowerInvariant())
            ? MimeTypes[FileExtension.ToLowerInvariant()]
            : string.Empty;

        public bool IsValidExtension() => AllowedExtensions.Contains(FileExtension.ToLowerInvariant());

        public bool IsValidMimeType() => !string.IsNullOrEmpty(MimeType);

        public bool IsValid() => IsValidExtension() && IsValidMimeType();

        public static bool IsMimeTypeAllowed(string mimeType) =>
            MimeTypes.ContainsValue(mimeType.ToLowerInvariant());

        public static bool IsExtensionAllowed(string ext) =>
            AllowedExtensions.Contains(ext.ToLowerInvariant());
    }
}
