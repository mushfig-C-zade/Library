using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class HomeAddressEmptyException:ApplicationException
    {
        public HomeAddressEmptyException(string message = "Home Adress mustn't empty") : base(message)
        {

        }
    }
}
