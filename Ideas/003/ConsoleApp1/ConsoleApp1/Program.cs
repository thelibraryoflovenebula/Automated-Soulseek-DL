using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFile = @"C:\Users\patri\Desktop\GITHUB PROJECTS\Automated Soulseek DL\Ideas\003\ConsoleApp1\ConsoleApp1\fileChange.txt";

            bool running = true;
            if (File.Exists(textFile))
            {
                while(running)
                {
                    Console.Clear();        //Clears the console!

                    string contents = File.ReadAllText(textFile);

                    Console.WriteLine(">>> The current contents of the file are");
                    Console.WriteLine("\t" + contents);
                    Console.Write(">>> Change text contents? [y/n] ");

                    string option = Console.ReadLine();

                    switch(option.ToUpper())
                    {
                    
                        case "Y":       //user says yes
                            Console.WriteLine(">>> Entered desired changed text");
                            Console.Write("\t");
                            string newContent = Console.ReadLine();
                            File.WriteAllText(textFile, newContent);

                            Console.WriteLine(">>> Text file changed !!!");

                            break;
                        case "N":       //user says no
                            running = false;
                            break;
                        default:
                            Console.Error.WriteLine(">>> Invalid option entered");
                            break;
                    }
                    Console.Write("\n>>> Hit a key to continue ... ");
                    Console.ReadKey();   // Will wait for any key to be pressed 
                }
            } else
            {
                Console.WriteLine(">>> Something went wrong...");
            }

            Console.Write(">>> Have a great day...");

        }
    }
}
