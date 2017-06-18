using System;
using System.Collections;
using System.Collections.Generic;

namespace WorldNomads.ViewModels
{
    public class CalculateViewModel
    {
        public IEnumerable<long> Sequence
        {
            get;
            set;
        }
        public IEnumerable<long> OddSequence
        {
            get;
            set;
        }
        public IEnumerable<long> EvenSequence
        {
            get;
            set;
        }
        public IEnumerable<long> FibonacciSequence
        {
            get;
            set;
        }
		public IEnumerable GetSequenceWithCondition
		{
			get;
			set;
		}
    }
}
