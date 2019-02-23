using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {

        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("The input contains invalid characters. Enter again: ");

                foreach (char character in input.ToCharArray())
                {

                    if (character == 0x1F)
                    {
                        // do something about the character being 0x1F
                    }
                    // check each character to see if it matches any of the not-allowed control characters
                }

            } while (true);
        }

       

        


        // Try to encode the characters?

        static string Encode(string value)
        {
            string encodedValue = "";
            foreach (char character in value.ToCharArray(" ", ";", "/", "?", ":", "@", "&", "=", "+", "$"))
            {
                
                char = " ";
                char = ; 
                char == "/";
                char == "?";
                char == ":";
                char == "@";
                char == "&";
                char == "=";

                // build the encodedValue string by getting each character
                // in the original string and adding it to encodedValue if the original is ok
                // OR changing it to an encoded value and adding the encoded value to the string
                // if it is one of the values that needs to change
            }
            return encodedValue;
        }

        static bool flag = false;

        static void Main(string[] args)
        {







            Console.WriteLine(" This is a Url Encoder \n" );
            do
            {
                string project_name = " ";
                string activity_name = " ";




                try
                {
                    Console.WriteLine("Enter the project name");
                    project_name = Console.ReadLine();

                    Console.WriteLine("Enter the activity name");
                    activity_name = Console.ReadLine();

                    string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                    Console.WriteLine("\n");
                    Console.WriteLine(url);
                }

                catch
                {


                    Console.WriteLine("PLease enter vaild details");


                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want another URL say y/n");
                char res = Convert.ToChar(Console.ReadLine());
                if (res == 'y')
                {
                    flag = true;
                }
            }
            while (flag == true);
        }
    }
}

