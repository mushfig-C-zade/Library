namespace Library_Final_Task.Utilities
{
    public interface IFileService
    {
        void Write(string path, string data);
        string Read(string path);
    }
}
