using Library_Final_Task.Configuration;
using System.Text.RegularExpressions;

namespace Library_Final_Task.Model.Managers
{

    public class BookManager : BaseManager<Book>
    {
        protected override string Path => AppFilesPath.BookDocsPath;

        public IEnumerable<Book> SearchByBookName(string name)
        {
            return Search(s => s.Name == name);
        }
        public IEnumerable<Book> SearchByAuthorName(string name)
        {
            return Search(s => s.Author == name);
        }
        public IEnumerable<Book> SearchByISBN(int ISBN)
        {
            return Search(s => s.ISBN == ISBN);
        }
        public IEnumerable<Book> SearchByCirculation(int circulation)
        {
            return Search(s => s.Circulation == circulation);
        }
        public IEnumerable<Book> SearchByDurtionPeriod(int durationPeriod)
        {
            return Search(s => s.DurationPeriod == durationPeriod);
        }

        public Book? SearchById(string id)
        {
            return Search(r => r.CardId.ToString() == id).SingleOrDefault();
        }

        public bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
    }
}


