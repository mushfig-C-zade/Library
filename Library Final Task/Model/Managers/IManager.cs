namespace Library_Final_Task.Model.Managers
{
    public interface IManager<T> where T : class
    {
        void Add(T obj);
        void Remove(T obj);
        ICollection<T> GetAll();
    }
}
