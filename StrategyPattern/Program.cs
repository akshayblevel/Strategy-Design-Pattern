using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HashingContext context;

            context = new HashingContext(new MD5Hash());
            string strSHA1 = context.HashPassword("Akshay Patel");
            Console.WriteLine("Akshay Patel - " + strSHA1);

            context = new HashingContext(new SHA384Hash());
            string StrSHA384 = context.HashPassword("Panth Patel");
            Console.WriteLine("Panth Patel - " + StrSHA384);

            Console.ReadLine();
        }
    }
}
