using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOSess
{
    internal class FileIO
    {
        public static void ReadText()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\input.txt";
            //File.Create(path);
            //string content = "Hello world";
            //File.WriteAllText(path, content);
            Console.WriteLine("Contents of file: ");
            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            
        }
        public static void WriteText()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\output.txt";
            //File.Create(path);
            Console.WriteLine("Enter the text you want to write in the file");
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
            Console.WriteLine("Data successfully written");

        }

        public static void AppendText()
        {
            //string source = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\output.txt";
            //string dest = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\log.txt";
            //File.Copy(source, dest, true);

            string path = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\log.txt";
            string appendText = "Hiiii";
            File.AppendAllText(path, appendText);
            Console.WriteLine("Text appended");

        }

        public static void CountWords()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\log.txt";
            string content = File.ReadAllText(path);
            int count = content.Split(' ').Length;
            Console.WriteLine($"There are {count} words");
        }

        public static void FindWord()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOSess\FileIOSess\log.txt";
            Console.WriteLine("Enter the term you want to search:");
            string input = Console.ReadLine();
            string[] content = File.ReadAllLines(path);
            bool found = false;
            for(int i = 0; i < content.Length; i++)
            {
                string[] words = content[i].Split(' ');
                foreach(string word in words)
                {
                    if (string.Equals(word, input))
                    {
                        Console.WriteLine($"Found at line {i+1}");
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"{input} not in file");
            }

        }
    }
}
