using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_Final_Task.Model
{
    public class Reader(string name,string surname,int age,string phoneNumber,string mail,string homeAddress)
    {
        public override string ToString()
        {
            return $"Card İd: {CardId} Name: {name} Surname: {surname} Age: {age} Phone Number: {phoneNumber} Mail: {mail} Home Address: {homeAddress}";
        }
        public int Debt = 0;
        public string Name { get; set; } = name;
        public string Surname { get; set; } = surname;
        public int Age { get; set; } = age;
        public string PhoneNumber { get; set; }= phoneNumber;
        public string Mail { get; set; }=mail;
        public string HomeAddress { get; set; } = homeAddress;      
        public DateTime Date { get; set; }

        public Guid CardId { get; set; } = Guid.NewGuid();


    }
}
