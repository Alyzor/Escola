using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testes
{
    class Information //used to store information about user.
        {
            public string Name;
            public string Age;
            public string Email;
            public string Phone;
            public string City;
            public string Address;
}
    internal class Program
    {

            static void Main(string[] args)
            {
                string filePath = "C:\\Users\\Pedro\\Desktop\\file.txt";
                Information info = new Information();

                if (File.Exists(filePath) == false)
                {
                    Console.WriteLine("File doesn't exist. Creating file...");
                    using(File.Create(filePath)) //Creates file and instantly closes it, allowing for FileStream to use it without any problem.
                    Console.WriteLine("File created.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                Console.WriteLine("Insert your information:");
                Console.Write("Name: ");
                info.Name = Console.ReadLine();
                Console.Write("Age: ");
                info.Age = Console.ReadLine();
                Console.Write("Email: ");
                info.Email = Console.ReadLine();
                Console.Write("Phone: ");
                info.Phone = Console.ReadLine();
                Console.Write("City: ");
                info.City = Console.ReadLine();
                Console.Write("Address: ");
                info.Address = Console.ReadLine();


                string save = info.Name + ";" + info.Age + ";" + info.Email + ";" + info.Phone + ";" + info.City + ";" + info.Address;
                FileStream fParameter = new FileStream(filePath, FileMode.Open, FileAccess.Write); //Parameter used to open file, StreamWriter uses it to know what file to use and what actions to do.
                StreamWriter write = new StreamWriter(fParameter);

                write.BaseStream.Seek(0, SeekOrigin.End);
                write.WriteLine(save);
                write.Flush();
                    write.Close();
            }

                //File exists, reading file

                var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var fields = lines[i].Split(';');

                info.Name = fields[0];
                info.Age = fields[1];
                info.Email = fields[2];
                info.Phone = fields[3];
                info.City = fields[4];
                info.Address = fields[5];
            }

            Console.WriteLine("Name: " + info.Name);
            Console.WriteLine("Age: " + info.Age);
            Console.WriteLine("Email: " + info.Email);
            Console.WriteLine("Phone: "+ info.Phone);
            Console.WriteLine("City: " + info.City);
            Console.WriteLine("Address: " + info.Address);


            Console.ReadKey();
            }
        }


    }   

