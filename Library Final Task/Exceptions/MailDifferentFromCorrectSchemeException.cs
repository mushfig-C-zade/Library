using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class MailDifferentFromCorrectSchemeException:ApplicationException
    {
        public MailDifferentFromCorrectSchemeException(string message = "Mail must match the correct scheme") : base(message)
        {

        }
    }
}
