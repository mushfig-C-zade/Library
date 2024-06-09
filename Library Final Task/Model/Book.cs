using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Model
{
    public class Book(string name, string author, int ISBN, int circulation, int durationPeriod)
    {
        public override string ToString()
        {
            return $"Card İd: {CardId} Name: {name} Author: {author} ISBN: {ISBN} Circulation {circulation} Duration Period: {durationPeriod}";
        }
        public string Name { get; set; } = name;
        public string Author { get; set; } = author;
        public int ISBN { get; set; } = ISBN;
        public int Circulation { get; set; } = circulation;
        public int DurationPeriod { get; set; } = durationPeriod;
        public Guid CardId { get; set; } = Guid.NewGuid();
    }
}
