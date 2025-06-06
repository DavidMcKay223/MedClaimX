using MedClaimX.Core.Common;
using MedClaimX.Core.Contracts;
using MedClaimX.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Infrastructure.Repositories
{
    public class DocumentService : IDocumentService
    {
        private readonly AppDbContext _db;
        public DocumentService(AppDbContext db)
        {
            _db = db;
        }

        public Task DeleteDocumentAsync(int documentId)
        {
            throw new NotImplementedException();
        }

        public Task<Document> DownloadDocumentAsync(int documentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Document>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UploadDocumentAsync(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
