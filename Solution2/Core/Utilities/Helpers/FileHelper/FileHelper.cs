using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string Add(IFormFile file, string root) //Dosya yükleme metodu. Parametre dosya ve dosyanın kaydedileceği dizin
        {
            if (file != null)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName); //Verilen dosyanın uzantısını al
                string filePath = Guid.NewGuid() + extension; //Eşsiz bir isim oluşturup, uzantıyı ekle
                using (FileStream stream = File.Create(root + filePath))
                {
                    file.CopyTo(stream);
                    stream.Flush();
                    return filePath;
                }
            }
            return null;
        }

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Add(file, root);
        }
    }
}
