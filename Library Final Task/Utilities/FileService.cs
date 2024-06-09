using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Utilities
{
    public class FileService : IFileService
    {
        public string Read(string path)
        {
            using StreamReader reader = new(path);

            return reader.ReadToEnd();
        }

        public void Write(string path, string data)
        {
            using StreamWriter writer = new(path);

            writer.Write(data);
        }
    }
}
