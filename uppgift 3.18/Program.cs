using System;
namespace Uppgift_3_18
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in förnamn och efternamn");
            string x=Console.ReadLine();
            int mellanslagsindex = x.IndexOf(" ");
           
            string förnamn=x[..mellanslagsindex];
            string efternamn = x [(mellanslagsindex + 1)..];
            if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine(förnamn + "kommer före " + efternamn + " i bokstavsordning");
            }
            else
            {
                Console.WriteLine(efternamn + " kommer före " + förnamn + " i bokstavsordning ");
            }

        }
    }
}