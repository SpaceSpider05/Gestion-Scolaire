using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string prenom, nom;
                int age, note;
                Console.WriteLine("Bienvenue dans le SdS system devlopemant scolaire ");
                Console.WriteLine("pour savoir est-ce-que vous etes admis entrer votre cordonnee: ");
                Console.WriteLine("Prenom: ");
                prenom = Console.ReadLine();
                Console.WriteLine("Nom: ");
                nom = Console.ReadLine();
                Console.WriteLine("Age: ");
                age = int.Parse(Console.ReadLine());


                if (age < 10 && age > 30)
                {
                    
                        Console.WriteLine("Note: ");
                        note = int.Parse(Console.ReadLine());

                        if (note >= 10 && note < 20)
                        {
                            Console.WriteLine($"Felicitation! {prenom} {nom} vous etes admis");
                            Console.WriteLine("Soit serieux !");
                        }
                        else if (note < 7)
                        {
                            Console.WriteLine($"Mr {prenom} {nom} vous etes non-admis autre fois");
                        }
                        else if (note <= 9 && note > 7)
                        {
                            Console.WriteLine($"Mr {prenom} {nom} vous aurai un rattrapage");
                        }

                      
                }
                else
                {
                    Console.WriteLine("Try later");
                }
                Console.ReadLine(); 
            } 
        }


        }
}
