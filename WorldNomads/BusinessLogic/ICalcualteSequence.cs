using System;
using System.Collections.Generic;

namespace WorldNomads.BusinessLogic
{
    public interface ICalcualteSequence
    {
        IEnumerable<long> Sequence(long number);
        IEnumerable<long> OddSequence(long number);
        IEnumerable<long> EvenSequence(long number);
        string SequenceWithCondition(long number);
        IEnumerable<long> FibonacciSequence(long number);
    }
}
