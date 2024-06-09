using Library_Final_Task.Model;

namespace Library_Final_Task.Configuration
{
    public static class AppFilesPath
    {
        public static string BookDocsPath = $"{nameof(Book)}.json";
        public static string ReaderDocsPath = $"{nameof(Reader)}.json";        
        public static string ReaderBookDockPath = $"{nameof(ReaderBook)}.json";

    }
}
