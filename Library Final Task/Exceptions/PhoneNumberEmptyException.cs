using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class PhoneNumberEmptyException:ApplicationException
    {
        public PhoneNumberEmptyException(string message = "Phone Number mustn't empty") : base(message)
        {

        }
    }
}
