using Library_Final_Task.Exceptions;
using Library_Final_Task.Model.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Model
{
    public class Archive
    {
        private readonly BookManager bookManager = new();

        public bool AssignBookToReaderFromArchive(string bookId)
        {

            if (bookManager.SearchById(bookId) == null)
            {
                throw new NotFoundSameBookAsThisIdException();
                return false;
            }         

            return true;
        }
        public void AddBook(Book book)
        {
            bookManager.Add(book);
        }
        public void RemoveBook(Book book)
        {
            bookManager.Remove(book);
        }
                
        public void RemoveByIdFromBook(string id)
        {
            Book? book = bookManager.SearchById(id);

            if (book != null)
            {
                bookManager.Remove(book);
            }
        }

        public void ShowAllBook()
        {
            bookManager.ShowAll();
        }        
    }
}
