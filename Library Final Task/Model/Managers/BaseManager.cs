using Library_Final_Task.Utilities;
using System.Text.Json;

namespace Library_Final_Task.Model.Managers
{
    public abstract class BaseManager<T> : IManager<T> where T : class
    {

        private readonly List<T> _collection = [];
        protected abstract string Path { get; }

        public BaseManager()
        {
            if (File.Exists(Path))
            {
                IFileService fileService = new FileService();
                string json = File.ReadAllText(Path);

                if (json != string.Empty)
                {
                    _collection = JsonSerializer.Deserialize<List<T>>(json);
                }
            }
            else
            {
                File.Create(Path).Close();
            }
        }
        public void Add(T obj)
        {
            _collection.Add(obj);

            IFileService fileService = new FileService();
            string json = JsonSerializer.Serialize(_collection);

            fileService.Write(Path, json);
        }

        public ICollection<T> GetAll()
        {
            return _collection;
        }

        public void Remove(T obj)
        {
            _collection.Remove(obj);

            IFileService fileService = new FileService();
            string json = JsonSerializer.Serialize(_collection);

            fileService.Write(Path, json);
        }
        public void ShowAll()
        {
            foreach (var item in _collection)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerable<T> Search(Func<T, bool> filter)
        {
            return _collection.Where(filter);
        }

    }
}
