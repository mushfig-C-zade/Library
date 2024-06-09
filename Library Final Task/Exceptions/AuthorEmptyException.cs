using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class AuthorEmptyException:ApplicationException
    {
        public AuthorEmptyException(string message = "Author mustn't empty") : base(message)
        {

        }
    }
}
