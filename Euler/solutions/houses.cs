using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.solutions
{
    class houses
    {
        public int[] housesSolution(int numDays, int[] state)
        {
            //assume state[-1] = 0 and state[length] = 0
            //if houses state[n-1] = state[n+1] then state[n] = 0 else state[n] = 1 
            //all house change simultaneuosly.
            int[] newState = state.ToArray();

            for(int day = 1; day <= numDays; day++)
            {
                for (int n = 0; n < state.Length; n++)
                {
                    switch (n)
                    {
                        case 0:
                            newState[n] = state[n + 1] == 0 ? 0 : 1;
                            break;
                        case 7:
                            newState[n] = state[n - 1] == 0 ? 0 : 1;
                            break;
                        default:
                            newState[n] = state[n - 1] == state[n + 1] ? 0 : 1;
                            break;
                    }
                }
                state = newState.ToArray();
            }
            return state;
        }
    }
}
