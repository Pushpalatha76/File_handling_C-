using System;
using System.IO;

namespace Filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Filehandling!");
            FileStream fs = new FileStream("C:\\Users\\pushpalatha.boya\\OneDrive - Trianz\\Desktop\\pushpa.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            System.Console.WriteLine("We can Read and Display from file");
            string str = sr.ReadLine();
            while(str!=null)
            {
                System.Console.WriteLine(str);
                str = sr.ReadLine();

            }
            



        }
    }
}
