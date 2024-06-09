using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class ISBnDifferentFromEightException:ApplicationException
    {
        public ISBnDifferentFromEightException(string message = "ISBM mustn't be older than eight") : base(message) 
        { 

        }
    }
}
