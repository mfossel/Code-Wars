using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {

            if (numbers.Count == 0)
            {
                return numbers;
            }

            int smallest = numbers[0];
            int j = 0;
            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    j = i;
                }

            }
            numbers.RemoveAt(j);

            return numbers;

        }

    }

}


