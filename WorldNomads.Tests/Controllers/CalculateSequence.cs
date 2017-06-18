using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WorldNomads.BusinessLogic;
using System.Collections;

namespace WorldNomads.Tests.Controllers
{
    [TestFixture]
    public class CalculateSequence
    {
        [Test]
        public void Sequence_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable<long> sequence = calculate.Sequence(10);

            Assert.IsNotNull(sequence);
            Assert.AreEqual(11, sequence.Count());
            Assert.AreEqual(1, sequence.ElementAt(1));
            Assert.AreEqual(5, sequence.ElementAt(5));
        }

        [Test]
        public void EvenSequence_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable<long> evenSequence = calculate.EvenSequence(10);

            Assert.IsNotNull(evenSequence);
            Assert.AreEqual(6, evenSequence.Count());
            Assert.AreEqual(4, evenSequence.ElementAt(2));
            Assert.AreEqual(8, evenSequence.ElementAt(4));
        }

        [Test]
        public void OddSequence_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable<long> oddSequence = calculate.OddSequence(10);

            Assert.IsNotNull(oddSequence);
            Assert.AreEqual(5, oddSequence.Count());
            Assert.AreEqual(5, oddSequence.ElementAt(2));
            Assert.AreEqual(9, oddSequence.ElementAt(4));
        }

        [Test]
        public void FibonacciSequence_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable<long> fibSequence = calculate.FibonacciSequence(10);

            Assert.IsNotNull(fibSequence);
            Assert.AreEqual(11, fibSequence.Count());
            Assert.AreEqual(2, fibSequence.ElementAt(3));
            Assert.AreEqual(5, fibSequence.ElementAt(5));
        }

        [Test]
        public void SequenceWithCondition_Five_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable condSequence = calculate.SequenceWithCondition(10);

            Assert.IsNotNull(condSequence);
            Assert.AreEqual("E", condSequence);
        }

        [Test]
        public void SequenceWithCondition_Three_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable condSequence = calculate.SequenceWithCondition(9);

            Assert.IsNotNull(condSequence);
            Assert.AreEqual("C", condSequence);
        }

        [Test]
        public void SequenceWithCondition_Five_And_Three_Test()
        {
            ICalcualteSequence calculate = CalcualteSequence.Instance;
            IEnumerable condSequence = calculate.SequenceWithCondition(15);

            Assert.IsNotNull(condSequence);
            Assert.AreEqual("Z", condSequence);
        }
    }
}
