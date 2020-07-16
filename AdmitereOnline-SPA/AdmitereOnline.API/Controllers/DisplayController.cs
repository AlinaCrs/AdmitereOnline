using AdmitereOnline.API.Data;
using AdmitereOnline.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AdmitereOnline.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisplayController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IDocsRepository _repo;
        public DisplayController(DataContext context, IDocsRepository repo)
        {
            _repo = repo;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Document>>> GetAllDocuments()
        {
            return await _context.Documents.ToListAsync();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<Document>>> GetDocumentsByUserId(int userId)
        {
          return await Task.FromResult(_repo.GetDocumentsByUserId(userId));
        }

    }
}
