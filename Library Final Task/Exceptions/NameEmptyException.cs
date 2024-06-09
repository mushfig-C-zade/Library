using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    public class NameEmptyException:ApplicationException
    {
        public NameEmptyException(string message ="Name mustn't empty"):base(message) 
        {
            
        }
    }
}
