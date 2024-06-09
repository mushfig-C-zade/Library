using Library_Final_Task.Exceptions;
using Library_Final_Task.Model.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Model
{
    public class Library
    {
        private readonly BookManager bookManager = new();
        private readonly ReaderManager readerManager = new();
       


        public bool AssignBookToReaderFromLibrary(string readerId, string bookId)
        {

            if (bookManager.SearchById(bookId) == null)
            {
                throw new NotFoundSameBookAsThisIdException();
                return false; 
            }

            if (readerManager.SearchById(readerId)==null)
            {
                throw new NotFoundSameReaderAsThisIdException();
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
        public void AddReader(Reader reader)
        {
            readerManager.Add(reader);
        }
        public void RemoveReader(Reader reader)
        {
            readerManager.Remove(reader);
        }
        public void RemoveByIdFromReader(string id)
        {
            Reader? reader = readerManager.SearchById(id);

            if (reader != null)
            {
                readerManager.Remove(reader);
            }

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
        public void ShowAllReader()
        {
            readerManager.ShowAll();
        }


    }

}
