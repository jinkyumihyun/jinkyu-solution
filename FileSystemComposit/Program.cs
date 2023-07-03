using FileSystemComposit.Interfaces;
using FileSystemComposit.NewFolder;

namespace FileSystemComposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Composit\n");
            Test();
        }
        static void Test()
        {
            AbstractFileSystemItem MyBook = FileItem.Create("MyBook.txt", 12000); //
            AbstractFileSystemItem MyVideo = FileItem.Create("MyVideo.mp4", 1000000); //
            AbstractFileSystemItem MyMusic = FileItem.Create("MyMusic.mp3", 20000); //
            AbstractFileSystemItem MyResume = FileItem.Create("MyResume.pdf", 18000); //
            AbstractFileSystemItem MySoftware = FileItem.Create("MySoftware.exe", 250000); //
            AbstractFileSystemItem MyDocument = FileItem.Create("MyDocument.doc", 87000000); //
            Console.WriteLine($"Total size of MyBook File: {MyBook.GetSize()}");
            Console.WriteLine($"Total size of MyVideo File: {MyVideo.GetSize()}");
            Console.WriteLine($"Total size of MyMusic File: {MyMusic.GetSize()}");
            Console.WriteLine($"Total size of MyResume File: {MyResume.GetSize()}");
            Console.WriteLine($"Total size of MySoftware File: {MySoftware.GetSize()}");
            Console.WriteLine($"Total size of MyDocument File: {MyDocument.GetSize()} \n");

            DirectoryItem SubFolder1 = new DirectoryItem("Sub Folder1");
            SubFolder1.AddComponent(MyMusic);
            SubFolder1.AddComponent(MyResume);
            Console.WriteLine($"Total size of (SubFolder 1): {SubFolder1.GetSize()}\n");

            DirectoryItem Folder1 = new DirectoryItem("Folder1");
            Folder1.AddComponent(SubFolder1);
            Folder1.AddComponent(MyBook);
            Folder1.AddComponent(MyVideo);
            Console.WriteLine($"Total size of (Folder 1): {Folder1.GetSize()}\n");

            DirectoryItem Folder2 = new DirectoryItem("Folder2");
            Folder2.AddComponent(MySoftware);
            Folder2.AddComponent(MyDocument);
            Console.WriteLine($"Total size of (Folder 2): {Folder2.GetSize()} \n");

            DirectoryItem RootDirectory = new DirectoryItem("RootDirectory");
            RootDirectory.AddComponent(Folder1);
            RootDirectory.AddComponent(Folder2);
            Console.WriteLine($"Total size of (RootDirectory): {RootDirectory.GetSize()} ");
        }
    }
}