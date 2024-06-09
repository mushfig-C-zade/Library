using Library_Final_Task.Configuration;

namespace Library_Final_Task.Model.Managers
{
    public class ReaderManager : BaseManager<Reader>
    {
        protected override string Path => AppFilesPath.ReaderDocsPath;
               

        public IEnumerable<Reader> SearchByName(string name)
        {
            return Search(s => s.Name == name);
        }

        public IEnumerable<Reader> SearchBySurname(string surname)
        {
            return Search(s => s.Surname == surname);
        }

        public IEnumerable<Reader> SearchByAge(int age)
        {
            return Search(s => s.Age == age);
        }

        public IEnumerable<Reader> SearchByPhoneNumber(string phoneNumber)
        {            
            return Search(s => s.PhoneNumber == phoneNumber);
        }

        public IEnumerable<Reader> SearchByMail(string mail)
        {
            return Search(s => s.Mail == mail);
        }
        public IEnumerable<Reader> SearchByHomeAddress(string homeAddress)
        {
            return Search(s => s.HomeAddress == homeAddress);
        }

        public Reader? SearchById(string id)
        {
            return Search(r => r.CardId.ToString() == id).SingleOrDefault();
        }
    }
}
