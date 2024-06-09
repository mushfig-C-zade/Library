using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Exceptions
{
    internal class CirculationNotBetweenOneAndTen:ApplicationException
    {
        public CirculationNotBetweenOneAndTen(string message = "Circulation must between one and ten") : base(message)
        {

        }
    }
}
