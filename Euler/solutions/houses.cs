using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.solutions
{
    class houses
    {
        public int[] cellCompete(int[] states, int days)
        {
            //assume state[-1] = 0 and state[length] = 0
            //if houses state[n-1] = state[n+1] then state[n] = 0 else state[n] = 1 
            //all house change simultaneuosly.
            int[] newState = states.ToArray();

            for (int day = 1; day <= days; day++)
            {
                for (int n = 0; n < states.Length; n++)
                {
                    if (n == 0)
                    {
                        newState[n] = states[n + 1] == 0 ? 0 : 1;
                    }
                    else if (n == states.Length - 1)
                    {
                        newState[n] = states[n - 1] == 0 ? 0 : 1;
                    }
                    else
                    {
                        newState[n] = states[n - 1] == states[n + 1] ? 0 : 1;
                    }
                }
                states = newState.ToArray();
            }
            return states;
        }
    }
}
