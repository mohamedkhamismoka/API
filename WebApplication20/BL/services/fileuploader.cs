using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace WebApplication20.BL.services
{
    public class fileuploader
    {
        
        
        public static string upload(string foldername,IFormFile img)
        {
          
            string path = Directory.GetCurrentDirectory()+"/"+foldername;
            string imgname=Guid.NewGuid()+Path.GetFileName(img.FileName);
            string finalpath = path + "/" + imgname;
            using (var stream = new FileStream(finalpath,FileMode.Create))
            {
               img.CopyTo(stream);
            }
            return finalpath;

        }

        public static void delete(string imgname)
        {
            if (File.Exists(imgname))
            {
                File.Delete(imgname);
            }
        }
    }
}
