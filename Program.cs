//written by kass woods on 11/13/2025

using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Homework3


{

    public class Program
    {
        static void Main(string[] args)  //main method where we input our string 
        {

            List<int> aNew = ReverseAndNot("1234");
            Console.WriteLine(string.Join("", aNew));
        }


        public static List<int> ReverseAndNot(string input) //method 
        {




            List<int> reverse = new List<int>();


            for (int i = input.Length - 1; i >= 0; i--) //reverse through input
            {
                reverse.Add(input[i] - '0');

            }
            for (int i = 0; i < input.Length; i++) //input 
            {
                reverse.Add(input[i] - '0');
            }
            return reverse;
            

            






        }


    }


}



