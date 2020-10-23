using System;
using System.IO;

namespace mycrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "-enc":
                    Console.Write("The magic key (32chars) = ");
                    File.WriteAllText(args[2], AES.Encrypt(File.ReadAllText(args[1]), Console.ReadLine()));
                    break;
                case "-dec":
                    Console.Write("The magic key (32chars) = ");
                    Console.WriteLine(AES.Decrypt(File.ReadAllText(args[2]), Console.ReadLine()));
                    break;
                case "-key":
                    Console.WriteLine(AES.Decrypt(File.ReadAllText(args[4]), File.ReadAllText(args[1])));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
