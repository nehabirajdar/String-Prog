using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
                string name = "Riddam";


                char[] chars = new char[] { 'M', 'u', 's', 'i', 'c' };
                string msg = new string(chars);
                Console.WriteLine(msg);


                for (int i = 0; i < name.Length; i++)
                {
                    Console.Write(name[i] + " ");
                }


                string str1 = "Song";
                string str2 = "Musical World";
                string str4 = string.Empty;
                //or
                string str5 = "";
                string str6 = null;
                string str3 = String.Concat(str1, " ", str2);
                Console.WriteLine(str3);


                // to check whether word or a character is present in the given string
                // contains method returns true if word is present and returns false if not present
                bool result = str2.Contains('G');
                Console.WriteLine(result);


            //Equals check for the value, if both have same value based on ASCII then return same else different
                if (str1.Equals(str4))
            {
                Console.WriteLine("Both strings are same");
            }
            else
            {
                Console.WriteLine("Both strings are different");
            }




            Console.WriteLine(str1.GetHashCode());
                Console.WriteLine(str2.GetHashCode());
                // which converts string to char array
                char[] ch = str2.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    Console.WriteLine(ch[i]);
                }


                if (String.IsNullOrEmpty(str4))
                {
                    Console.WriteLine("str4 is empty or null");
                }
                else
                {
                    Console.WriteLine($"str4 = {str4}");
                }


                Console.WriteLine(str2.ToUpper());
                Console.WriteLine(str2.ToLower());
                // trim function remove the spaces before & after the sting
                str2.Trim();
                // TrimEnd() removes the spaces after the string
                str2.TrimEnd();
                //TrimStart() remvoes teh spaces which is before the string
                str2.TrimStart();


                string newstring = str2.Substring(5, 5);
                Console.WriteLine(newstring);
            }
    }
}
