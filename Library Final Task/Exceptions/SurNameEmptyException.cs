using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class SurNameEmptyException: ApplicationException
    {
        public SurNameEmptyException(string message = "Surname mustn't empty") : base(message)
        {

        }
    }
}
