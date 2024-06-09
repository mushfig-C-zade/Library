using Library_Final_Task.Configuration;
using Library_Final_Task.Model.Managers;
using Library_Final_Task.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_Final_Task.Model
{
    public class ReaderBook
    {
        public int penalty = 0;

        Dictionary<string, string> ReaderBookDictionary = new Dictionary<string, string>();       

        public ReaderBook()
        {
            if (File.Exists(AppFilesPath.ReaderBookDockPath))
            {
                IFileService fileService = new FileService();
                string json = File.ReadAllText(AppFilesPath.ReaderBookDockPath);

                if (json != string.Empty)
                {
                    ReaderBookDictionary = JsonSerializer.Deserialize<Dictionary<string,string>>(json);
                }
            }
            else
            {
                File.Create(AppFilesPath.ReaderBookDockPath).Close();
            }
        }

        public void Add(string readerID, string bookId)
        {
            ReaderBookDictionary.Add(readerID,bookId);

            IFileService fileService = new FileService();
            string json = JsonSerializer.Serialize(ReaderBookDictionary);
            fileService.Write(AppFilesPath.ReaderBookDockPath, json);
        }

        public void Remove(string readerId,string bookId)
        {
            ReaderBookDictionary.Remove(readerId);

            IFileService fileService = new FileService();
            string json = JsonSerializer.Serialize(ReaderBookDictionary);

            fileService.Write(AppFilesPath.ReaderBookDockPath, json);
        }
        public void ShowAllDictionary()
        {
            foreach (var item in ReaderBookDictionary)
            {
                Console.WriteLine(item);
            }
        }

        public void Penalty(int durationPeriod)
        {
            durationPeriod++;
            if (durationPeriod>20)
            {
                penalty = penalty + 3;
            }
        } 



    }

}
