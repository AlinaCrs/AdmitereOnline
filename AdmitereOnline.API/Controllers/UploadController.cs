﻿using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdmitereOnline.API.Data;
using AdmitereOnline.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace UploadFilesServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly DataContext _context;
        public UploadController(DataContext context)
        {
            _context = context;
        }
        [HttpPost, DisableRequestSizeLimit]
        // public IActionResult Upload()
        // {
        //     try
        //     {
        //         var file = Request.Form.Files[0];
        //         var folderName = Path.Combine("StaticFiles", "Images");
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

        public IActionResult Upload()
        {
            try
            {
                var files = Request.Form.Files;
                var folderName = Path.Combine("StaticFiles", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (files.Any(f => f.Length == 0))
                {
                    return BadRequest();
                }

                foreach (var file in files)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    var document = new Document(){
                        FileName = dbPath
                    };
                    var createdUser =  SaveDocument(document);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                return Ok("All the files are successfully uploaded.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        public async Task<Document> SaveDocument(Document document)
        {
            _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return document;
        }
    }
}