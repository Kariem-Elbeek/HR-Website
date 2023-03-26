using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Demo.PL.Helpers
{
    public static class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            // 1. Get Located Folder to storage files
            //string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\files\\images\\" + folderName;
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);

            // 2. Get File Name and Make it Unique
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            // 3. Get File Path
            string filePath = Path.Combine(folderPath, fileName);

            // 4. Save File as Streams (use "using" as it uncontrolled by CLR )
            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyToAsync(fileStream);
            return fileName;
        }

        public static void DeleteFile(string fileName, string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
