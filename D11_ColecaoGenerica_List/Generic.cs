using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_ColecaoGenerica_List
{

    public class Generic
    {

        public IList<int> EvenNumbers(int quantity)
        {
            var evenNumbers = new List<int>(quantity);
            var currentNumber = 0;
            while (evenNumbers.Count <= quantity)
            {
                if (++currentNumber % 2 == 0)
                    evenNumbers.Add(currentNumber);
            }
            return evenNumbers;
        }

        public IEnumerable<int> EvenNumbersImproved(int quantity)
        {
            var currentNumber = 0;
            while (++currentNumber <= quantity)
            {
                if (currentNumber % 2 == 0)
                    yield return currentNumber;
            }
        }

    }

}
