using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Collusion
    {

        static int collision(int[] speed, int pos)
        {
            int result = 0;

            int ourSpeed = speed[pos];
            for (int i = 0; i < speed.Length; i++)
            {
                if ((i < pos && speed[i] > ourSpeed) || (i > pos && ourSpeed > speed[i]))
                    result++;


            }
            return result;

        }
    }
}
