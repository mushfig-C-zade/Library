using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class AgeOlderThanSixteenException:ApplicationException
    {
        public AgeOlderThanSixteenException(string message = "Age mustn't older than Sixteen") : base(message)
        {

        }
    }
}
