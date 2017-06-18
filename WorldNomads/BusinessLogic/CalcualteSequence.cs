using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldNomads.BusinessLogic
{
    public class CalcualteSequence : ICalcualteSequence
    {
        static CalcualteSequence _instance = null;
        CalcualteSequence() { }
        public static CalcualteSequence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CalcualteSequence();
                }
                return _instance;
            }
        }
        public IEnumerable<long> EvenSequence(long number)
        {
            return GetAllNumbers(number).Where(x => x % 2 == 0);
        }

        public IEnumerable<long> FibonacciSequence(long number)
        {
            return GetFibonacci(number);
        }

        public IEnumerable<long> OddSequence(long number)
        {
            return GetAllNumbers(number).Where(x => x % 2 != 0);
        }

        public IEnumerable<long> Sequence(long number)
        {
            return GetAllNumbers(number);
        }

        public string SequenceWithCondition(long number)
        {
            string result = null;

            if (number % 3 == 0)
            {
                result = "C";
            }
            if (number % 5 == 0)
            {
                result = "E";
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "Z";
            }

            return result;
        }

        IEnumerable<long> GetFibonacci(long number)
        {
            long firstNumber = 0; long secondNumber = 1; long result = 0;

            for (int i = 0; i <= number; i++)
            {
                result = firstNumber;
                firstNumber = secondNumber;
                secondNumber = result + secondNumber;
                yield return result;
            }
        }

        IEnumerable<long> GetAllNumbers(long number)
        {
            for (long i = 0; i <= number; i++)
            {
                yield return i;
            }
        }
    }
}
