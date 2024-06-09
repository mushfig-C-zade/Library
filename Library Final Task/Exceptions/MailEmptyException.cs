using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class MailEmptyException:ApplicationException
    {
        public MailEmptyException(string message = "Mail mustn't empty") : base(message)
        {

        }
    }
}
