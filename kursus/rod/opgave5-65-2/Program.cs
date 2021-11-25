using System;

namespace opgave5_65_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");

            try
            {
                Console.WriteLine(SmartToUpper("mikkel"));
                Console.WriteLine(SmartToUpper("mAtHiAs"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }


            try
            {
                Console.WriteLine(SmartToUpper(null));
            }
            catch (Exception ex)
            {

                // prøv også 
                Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }

            //Console.WriteLine(SmartToUpper(null));


            static string SmartToUpper(string tekst)
            {
                string output = "";

                if(tekst == null)
                {
                    throw new ApplicationException("tekst was null");
                }

                if(tekst.Length > 4)
                {
                    throw new ApplicationException("tekst was longer than 4");
                }

                try
                {
                    output = tekst.ToUpper();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());


                    throw;
                }
                // mangler kode
                

                return output;
            }
        }


    }
}
