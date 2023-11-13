using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class GasStationSolution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int stationNum = gas.Length;
            int currentGas = 0;
            int totalGas = 0;
            int totalCost = 0;
            int startPosition = 0;
            for (int i = 0; i < stationNum; i++)
            {
                totalCost += cost[i];
                totalGas += gas[i];
                currentGas += gas[i] - cost[i];
                if (currentGas < 0)
                {
                    startPosition = i + 1;
                    currentGas = 0;
                }
            }
            if (totalCost < totalGas)
            {
                return startPosition;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
