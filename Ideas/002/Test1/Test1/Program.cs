using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        //Main Method
        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.Write("Enter a path to read txt contents [x to quit]:>>> ");
                string path = RemoveQuot(Console.ReadLine());
                Console.WriteLine("\n" + path);

                
                if (path.ToUpper() == "X")
                {
                    running = false;
                    Console.WriteLine("\nBye...\n");
                } else
                {
                    //if the path exists in my pc
                    if (File.Exists(path))
                    {
                        //store contents into it
                        string content = File.ReadAllText(path);

                        //output contents into console
                        Console.WriteLine("\nFile Found\nContent>>>> ");
                        Console.WriteLine("\n" + content);
                    }
                    else
                    {
                        Console.WriteLine("\nFile not found");
                    }
                }
                
                Console.Write("\nPress any key to continue");
                Console.ReadKey(); //wait for any key to be pressed

            }
            

        }



        //Method to remove front and end quotations
        static string RemoveQuot(string s)
        {
            int sSize = s.Length;

            // double or single quoates 
            char sQ = '\'';
            char dQ = '"';

            //if there is two ""... 
            if (s[0] == sQ && s[sSize - 1] == sQ ||
                s[0] == dQ && s[sSize - 1] == dQ)
            {
                s = s.Remove((sSize - 1), 1);
                s = s.Remove(0, 1);
            }

            return s; // return string

        }

    }
}
