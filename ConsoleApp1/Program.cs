using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "Vilket är bästa laget i Premier League?";
            frågor[1] = "Hur gammal är du om du föddes för 10 år sedan?";
            frågor[2] = "Vilket land är största landet i världen?";
            frågor[3] = "Messi eller Ronaldo?";

            svar[0] = "Arsenal";
            svar[1] = "10";
            svar[2] = "Ryssland";
            svar[3] = "Messi";

            Console.Write("Välj ett alternativ mellan 1-4 för att få en fråga \nSkriv här: "); int nr = int.Parse(Console.ReadLine()) ;
            Console.WriteLine($"{frågor[nr -1]}");  
            Console.Write("Ditt svar: "); string Svar = Console.ReadLine();

            if (Svar == svar[nr - 1]) 
            {
                Console.WriteLine("Du svarade rätt, grattis.");
            }

                
            else

            {
                Console.WriteLine("Du svarade tyvärr fel");
            }
            

            

        }
    }
}
