// using System.Threading.Tasks;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using AdmitereOnline.API.Models;
// using System.IO;
// using System.Net.Http.Headers;

// namespace AdmitereOnline.API.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class DocumentsController : ControllerBase
//     {


//         [HttpPost]
//         public async Task<ActionResult<Documents>> PostDocument(Documents muscle)
//         {

//             // _context.Muscle.Add(muscle);
//             // await _context.SaveChangesAsync();
//             // var returnValue = CreatedAtAction("GetMuscle", new { id = muscle.MuscleId }, muscle);

//             // return returnValue;
//         }
//         [HttpPost("FileUpload")]
//         public async Task<IActionResult> Index(List<IFormFile> files)
//         {
//             long size = files.Sum(f => f.Length);

//             var filePaths = new List<string>();
//             foreach (var formFile in files)
//             {
//                 if (formFile.Length > 0)
//                 {
//                     // full path to file in temp location
//                     var filePath = Path.GetTempFileName(); //we are using Temp file name just for the example. Add your own file path.
//                     filePaths.Add(filePath);

//                     using (var stream = new FileStream(filePath, FileMode.Create))
//                     {
//                         await formFile.CopyToAsync(stream);
//                     }
//                 }
//             }

//             // process uploaded files
//             // Don't rely on or trust the FileName property without validation.

//             return Ok(new { count = files.Count, size, filePaths });
//         }
//         [HttpPost, DisableRequestSizeLimit]
// public IActionResult Upload()
// {
//     try
//     {
//         var file = Request.Form.Files[0];
//         var folderName = Path.Combine("Resources", "Images");
//         var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
 
//         if (file.Length > 0)
//         {
//             var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
//             var fullPath = Path.Combine(pathToSave, fileName);
//             var dbPath = Path.Combine(folderName, fileName);
 
//             using (var stream = new FileStream(fullPath, FileMode.Create))
//             {
//                 file.CopyTo(stream);
//             }
 
//             return Ok(new { dbPath });
//         }
//         else
//         {
//             return BadRequest();
//         }
//     }
//     catch (Exception ex)
//     {
//         return StatusCode(500, $"Internal server error: {ex}");
//     }
// }
//     }
// }