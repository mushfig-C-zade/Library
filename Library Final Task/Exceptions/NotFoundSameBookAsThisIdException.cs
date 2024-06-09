using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class NotFoundSameBookAsThisIdException:ApplicationException
    {
        public NotFoundSameBookAsThisIdException(string message = "The book with this id does not exist") : base(message)
        {

        }
    }
}
