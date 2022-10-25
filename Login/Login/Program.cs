using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Pedro\\Desktop\\login.txt", user, pass, save;
            int optMenu;
            
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath))
                    Console.WriteLine("");
            }
            menu:
            Console.WriteLine("Welcome to the Login Platform!");
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Create Login");
            Console.WriteLine("3 - Exit app");
            Console.WriteLine("");
            Console.Write("Option: ");
            optMenu = int.Parse(Console.ReadLine());
            var lines = File.ReadAllLines(filePath);

            switch (optMenu)
            {
                case 1:
                    Login:
                    Console.Clear();
                    Console.Write("Insert your username: ");
                    user = Console.ReadLine();
                    Console.Write("Insert your password: ");
                    pass = Console.ReadLine();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        var fields = lines[i].Split(';');
                        if (user == fields[0])
                        {
                            if (pass != fields[1])
                            {
                                Console.WriteLine("Incorrect password! Please try again.");
                                Console.ReadKey();
                                goto Login;
                            }
                            else
                            {
                                Console.WriteLine("Welcome, " + user + "!");
                                Console.ReadKey();
                            }
                        }
                    }
                    break;
                case 2:
                    Create:
                    Console.Clear();
                    Console.Write("Choose your username: ");
                    user = Console.ReadLine();
                    Console.Write("Choose your password: ");
                    pass = Console.ReadLine();


                        for (int i = 0; i < lines.Length; i++)
                        {
                            var fields = lines[i].Split(';');
                            if (fields[0] == user)
                            {
                            wUser:
                                int opt2;
                                Console.WriteLine("Username already in use! Try to log in or use another username!");
                                Console.WriteLine("1 - Go back to menu");
                                Console.WriteLine("2 - Use another username");
                                Console.WriteLine("");
                                Console.Write("Option: ");
                                opt2 = int.Parse(Console.ReadLine());

                                switch (opt2)
                                {
                                    case 1:
                                        goto menu;
                                    case 2:
                                        goto Create;
                                    default:
                                        Console.WriteLine("Invalid option. Please choose again.");
                                        goto wUser;

                                }
                            }
                        }

                        //save in file
                        save = user + ";" + pass;
                    FileStream fS = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                    StreamWriter write = new StreamWriter(fS);
                    write.BaseStream.Seek(0, SeekOrigin.End);
                    write.WriteLine(save);
                    write.Flush();
                    write.Close();
                    Console.WriteLine("Login created! Returning to menu...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    goto menu;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option! Choose another option.");
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;
            }

        }
    }
}
