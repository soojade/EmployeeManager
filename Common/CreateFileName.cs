using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common {
    public static class CreateFileName {
        public static string CreatePhotoName(string file) {
            string photoName = DateTime.Now.ToString("yyyyMMdd");
            Random random = new Random();
            photoName += random.Next(0, 100).ToString("00");
            string extension= Path.GetExtension(file); // 获取文件扩展名
            //string fileName = Path.GetFileName(file); // 获取带扩展的文件名
            //string name = Path.GetFileNameWithoutExtension(file); // 获取不带扩展的文件名
            photoName += extension;
            return photoName;
        }
    }
}
