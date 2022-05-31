using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Name_Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                Console.WriteLine("----------:Random Name Generator:----------");
                Console.Write("Enter species of the desired character: ");
                string speciesInput = Console.ReadLine();
                string speciesInputLower = speciesInput.ToLower();
                Console.Write("Type 'male' or 'female': ");
                string genderInput = Console.ReadLine();
                string genderInputLower = genderInput.ToLower();
                Console.WriteLine("Press 'enter' to cycle through names.");
                Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");

                //human male
                if (speciesInputLower == "human" && genderInputLower == "male")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        {
                            string HMname1 = HumanMale.FirstNames(Randomizer.D100a());
                            string HMname2 = HumanLast.LastNames(Randomizer.D100a());
                            Console.WriteLine(HMname1 + HMname2);
                            Console.ReadLine();
                        }
                    }
                }
                //human female
                if (speciesInputLower == "human" && genderInputLower == "female")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        {
                            string HMname1 = HumanFemale.FirstNames(Randomizer.D100a());
                            string HMname2 = HumanLast.LastNames(Randomizer.D100a());
                            Console.WriteLine(HMname1 + HMname2);
                            Console.ReadLine();
                        }
                    }
                }
                //invalid entry catcher
                if (speciesInputLower != "human")
                {
                    Console.WriteLine("INVALID ENTRY, TRY AGAIN.");
                }

                Console.Write("Press enter to continue, or type 'exit' to close app.");
                string endEntry = Console.ReadLine();

                //exit app
                if (endEntry == "exit")
                {
                    break;
                }
            }
        }
    }
}
