using MedClaimX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Core.Contracts
{
    public interface IDocumentService
    {
        Task<List<Document>> GetAllDocumentsAsync();
        Task<int> UploadDocumentAsync(string filePath);
        Task<Document> DownloadDocumentAsync(int documentId);
        Task DeleteDocumentAsync(int documentId);
    }
}
