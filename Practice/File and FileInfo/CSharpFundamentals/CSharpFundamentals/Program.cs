
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            //Delete method
            File.Delete(path);

            if(File.Exists(path) )
            {
                //
            }
            var content = File.ReadAllBytes(path);

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...");

            fileInfo.Delete();

            if(fileInfo.Exists )
            {
                //....
            }


        }
    }
}