using AdmitereOnline.API.Data;
using AdmitereOnline.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdmitereOnline.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class DisplayController : ControllerBase
  {
    private readonly DataContext _context;
    public DisplayController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Document>>> GetAllDocuments()
    {
      return await _context.Documents.ToListAsync();
    }

  }
}
