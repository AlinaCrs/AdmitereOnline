using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdmitereOnline.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdmitereOnline.API.Data
{
  public class DocsRepository : IDocsRepository
  {
    private readonly DataContext _context;
    public DocsRepository(DataContext context)
    {
      _context = context;

    }
        public List<Document> GetDocumentsByUserId(int userId)
        {

         return _context.Documents.Where(x => x.UserId == userId).ToList();

        }
    }
}
