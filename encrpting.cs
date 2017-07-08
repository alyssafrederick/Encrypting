using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.Write("Password: ");
            string password = Console.ReadLine();
            

            byte[] asciiCode = Encoding.Unicode.GetBytes(password);

            //for (int i = 0; i < asciiCode.Length; i++)
            //{
            //    Console.Write("{0} ", asciiCode[i]);
            //}

            System.Security.Cryptography.SHA512 converter = System.Security.Cryptography.SHA512.Create();
            //encrypt = 1 way
            //encode = 2 ways

            Console.WriteLine("Without salt");
            string encryptedValue = Convert.ToBase64String(converter.ComputeHash(asciiCode));
            Console.WriteLine("Encrypted Value:\n{0}", encryptedValue);
            Console.WriteLine("\n\n");

            Console.WriteLine("With salt");
            asciiCode = Encoding.Unicode.GetBytes(password + "1");
            encryptedValue = Convert.ToBase64String(converter.ComputeHash(asciiCode));
            Console.WriteLine("Encrypted Value:\n{0}", encryptedValue);

            Console.ReadKey();
        }
    }
}
