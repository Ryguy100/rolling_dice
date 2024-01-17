using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rolling_dice
{
    public class Simulation
    {
        public int[] Simulate(int rolls)
        {
            int[] output = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            
            for (int i = 0; i < rolls; i++)
            {
                int rand1;
                int rand2;
                int sum;

                Random rnd = new Random();

                rand1 = rnd.Next(1, 7);
                rand2 = rnd.Next(1, 7);

                sum = rand1 + rand2;

                output[sum] += 1;
            }

            return output;
        }
    }
}
