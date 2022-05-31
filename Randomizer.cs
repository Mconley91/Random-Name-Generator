using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Name_Generator
{
    public class Randomizer
    {
        public static int D100a()
        {
            Random random1 = new Random();
            int num1 = random1.Next(434127228);
            while (num1 > 100)
            {
                num1 = random1.Next(774236419);
            }
            return num1;
        }
    }
}

