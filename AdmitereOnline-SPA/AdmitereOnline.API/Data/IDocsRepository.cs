using System.Collections.Generic;
using System.Threading.Tasks;
using AdmitereOnline.API.Models;

namespace AdmitereOnline.API.Data
{
    public interface IDocsRepository
    {
        List<Document> GetDocumentsByUserId(int userId);		
		
    }
}