using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        string filename = @"C:\Users\Subham Kumar Ojha\Desktop\day3\testcase.txt";
        void createfile()
        {
            FileStream fs = File.Create(filename);
            Console.WriteLine("File name testcase is created");
            Console.ReadLine();
            fs.Close();
        }
        void deletefile()
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine("File name testcase is deleted");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("File of name testcase doesn't exists");
                Console.ReadLine();
            }
        }
        void checkexistance()
            {
                if (File.Exists(filename))
                {
                    Console.WriteLine("File already exists");
                }
                else
                {
                    FileStream fs = File.Create(filename);
                    Console.WriteLine("New File name testcase is created");
                    Console.ReadLine();
                    fs.Close();

                }
            }
        void writetext()
        {
            FileStream fs = new FileStream(@"C:\Users\Subham Kumar Ojha\Desktop\day3\testcase.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello and Welcome this is the first content of testcase file");
            sw.Close();
            fs.Close();
        }

        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.createfile();
            obj.deletefile();
            obj.checkexistance();
            obj.writetext();
        }
    }
}
