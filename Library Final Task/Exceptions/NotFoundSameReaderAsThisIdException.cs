using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class NotFoundSameReaderAsThisIdException:ApplicationException
    {
        public NotFoundSameReaderAsThisIdException(string message = "The reader with this id does not exist") : base(message)
        {

        }
    }
}
