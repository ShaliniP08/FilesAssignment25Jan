using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAssignment25Jan
{
    class Program
    {
        static void WriteToFile()
        {
            try
            {
                using (FileStream fs = new FileStream("E:\\DotNetBatchJan2021\\Files\\StringFile.txt",
                                                         FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Writing contents into the file :");
                    Console.WriteLine("Enter the text below");
                    string s = null;
                    
                    while (s!= "abc")
                    {
                        s = Console.ReadLine();
                        if (s !="abc")
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadFromFile()
        {
            using (FileStream fs = new FileStream("E:\\DotNetBatchJan2021\\Files\\StringFile.txt",
                                                        FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader("E:\\DotNetBatchJan2021\\Files\\StringFile.txt"))
            {
                Console.WriteLine("Reading contents of StringFile.txt :\n" + sr.ReadToEnd());

            }
        }

        static void Main(string[] args)
        {
            WriteToFile();
            ReadFromFile();
            Console.ReadLine();
        }
    }
}